// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Collections.Concurrent;
using System.Text.Json;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
using Microsoft.Extensions.Logging;
using QosmosUI.Icons.Generator.Models;
using QosmosUI.Icons.Generator.Services.Git;
using QosmosUI.Icons.Generator.Services.Processors;
using QosmosUI.Icons.Generator.Services.Providers;
using QosmosUI.Icons.Generator.Services.Renderers;

namespace QosmosUI.Icons.Generator.Services.Orchestrators;

/// <summary>
/// Orchestrates the process of generating icons by coordinating various services.
/// </summary>
public sealed class IconOrchestrator : IIconOrchestrator
{
    private readonly IIconProvider _iconProvider;
    private readonly ISvgProcessor _svgProcessor;
    private readonly IComponentRenderer _componentRenderer;
    private readonly ICsprojRenderer _csprojRenderer;
    private readonly IRepository _repository;
    private readonly ILogger<IconOrchestrator> _logger;
    private readonly ParallelOptions _parallelOptions;

    /// <summary>
    /// Initializes a new instance of the <see cref="IconOrchestrator"/> class.
    /// </summary>
    /// <param name="iconProvider">Provides metadata about icons.</param>
    /// <param name="svgProcessor">Processes SVG content for icons.</param>
    /// <param name="componentRenderer">Generates components for icons.</param>
    /// <param name="csprojRenderer">Generates .csproj files for icons.</param>
    /// <param name="repository">Handles repository operations for icons.</param>
    /// <param name="logger">Logs information and errors during the orchestration process.</param>
    public IconOrchestrator(
        IIconProvider iconProvider,
        ISvgProcessor svgProcessor,
        IComponentRenderer componentRenderer,
        ICsprojRenderer csprojRenderer,
        IRepository repository,
        ILogger<IconOrchestrator> logger)
    {
        _iconProvider = iconProvider;
        _svgProcessor = svgProcessor;
        _componentRenderer = componentRenderer;
        _csprojRenderer = csprojRenderer;
        _repository = repository;
        _logger = logger;
        _parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount };
    }

    /// <summary>
    /// Generates icons by processing metadata, cloning repositories, and creating components and project files.
    /// </summary>
    public void GenerateIcons()
    {
        _logger.LogInformation("Starting icon generation process");

        var iconsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output", "Icons");

        if (!Directory.Exists(iconsDirectory))
            Directory.CreateDirectory(iconsDirectory);

        var generatedDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output", "Generated");

        if (!Directory.Exists(generatedDirectory))
            Directory.CreateDirectory(generatedDirectory);

        _logger.LogInformation("Retrieving icon metadata");

        var icons = _iconProvider.GetIcons().ToArray();

        _logger.LogInformation("Found {Count} icon sets to generate", icons.Length);

        var iconManifest = new List<IconManifestItem>();

        foreach (var metadata in icons)
        {
            _logger.LogInformation("Processing icon set: {Name}", metadata.Name);

            _repository.Clone(metadata);

            var iconDirectory = new DirectoryInfo(Path.Combine(iconsDirectory, metadata.Name));
            var iconDirectoryName = string.Concat("QosmosUI", '.', "Icons", '.', metadata.Name);

            var iconsCount = 0;

            foreach (var set in metadata.Sets)
            {
                try
                {
                    _logger.LogInformation("Processing set {SetName} for {IconName}", set.Name, metadata.Name);

                    var matcher = new Matcher().AddInclude(set.GlobPattern);

                    if (set.ExcludePatterns is { } excludePatterns)
                        matcher.AddExcludePatterns(excludePatterns);

                    var matchResult = matcher.Execute(new DirectoryInfoWrapper(iconDirectory));
                    var filePaths = matchResult.Files.Select(static x => x.Path);

                    _logger.LogInformation("Found {Count} files matching pattern {Pattern}", matchResult.Files.Count(), set.GlobPattern);

                    Parallel.ForEach(filePaths, _parallelOptions, filePath =>
                    {
                        try
                        {
                            Interlocked.Increment(ref iconsCount);

                            var fileName = Path.GetFileNameWithoutExtension(filePath);
                            var iconName = set.NamePattern(filePath, fileName);

                            var iconContent = File.ReadAllText(Path.Combine(iconDirectory.FullName, filePath));
                            var iconTree = _svgProcessor.ProcessSvg(iconContent, set.MultiColor, set.Svgo);
                            var iconComponent = _componentRenderer.GenerateComponent(metadata, set, iconName, iconTree);

                            var iconFilePath = Path.Combine(generatedDirectory, iconDirectoryName, set.Name, string.Concat(iconName, '.', "cs"));

                            var iconDirectoryPath = Path.GetDirectoryName(iconFilePath)!;

                            if (!Directory.Exists(iconDirectoryPath))
                                Directory.CreateDirectory(iconDirectoryPath);

                            File.WriteAllText(iconFilePath, iconComponent);
                        }
                        catch (Exception e)
                        {
                            _logger.LogError(e, "Error processing file {FilePath}: {Message}", filePath, e.Message);
                        }
                    });

                    _logger.LogInformation("Set {SetName} processed", set.Name);
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Error processing set {SetName}: {Message}", set.Name, e.Message);
                }
            }

            try
            {
                var csprojFileName = string.Concat(iconDirectoryName, '.', "csproj");
                var csprojFilePath = Path.Combine(generatedDirectory, iconDirectoryName, csprojFileName);
                var csprojFileContent = _csprojRenderer.GenerateProject(metadata);

                _logger.LogInformation("Generating project file: {FilePath}", csprojFilePath);

                File.WriteAllText(csprojFilePath, csprojFileContent);

                _logger.LogDebug("Project file generated successfully");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error generating project file: {Message}", e.Message);
            }

            iconManifest.Add(new IconManifestItem
            {
                Id = metadata.Id,
                Name = metadata.Name,
                ProjectName = metadata.ProjectName,
                ProjectUrl = metadata.ProjectUrl,
                LicenseUrl = metadata.LicenseUrl,
                License = metadata.License,
                IconsCount = iconsCount
            });
        }

        try
        {
            var manifestFilePath = Path.Combine(generatedDirectory, "manifest.json");
            var manifestContent = JsonSerializer.Serialize(iconManifest);

            _logger.LogInformation("Generating manifest file: {FilePath}", manifestFilePath);

            File.WriteAllText(manifestFilePath, manifestContent);

            _logger.LogDebug("Manifest file generated successfully");
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error generating manifest file: {Message}", e.Message);
        }

        _logger.LogInformation("Icon generation completed");
    }
}
