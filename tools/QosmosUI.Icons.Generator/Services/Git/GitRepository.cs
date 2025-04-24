// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;
using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Git;

/// <summary>
/// Provides functionality for interacting with Git repositories.
/// </summary>
public sealed class GitRepository : IRepository
{
    private readonly ILogger<GitRepository> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="GitRepository"/> class.
    /// </summary>
    /// <param name="logger">The logger used for logging Git operations.</param>
    public GitRepository(ILogger<GitRepository> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Clones a Git repository based on the provided icon metadata.
    /// </summary>
    /// <param name="metadata">The metadata of the icon used to determine the repository to clone.</param>
    public void Clone(IconMetadata metadata)
    {
        try
        {
            _logger.LogInformation("Cloning repository {Git}/{Path}@{Branch}", metadata.Source.Git, metadata.Source.Path, metadata.Source.Branch);

            var workingDirectory = Path.Combine("Output", "Icons");

            if (!Directory.Exists(workingDirectory))
                Directory.CreateDirectory(workingDirectory);

            ExecuteGitCommand(workingDirectory, "clone --filter=tree:0 --no-checkout {0} {1}", metadata.Source.Git, metadata.Name);

            workingDirectory = Path.Combine(workingDirectory, metadata.Name);

            ExecuteGitCommand(workingDirectory, "sparse-checkout set --cone --skip-checks {0}", metadata.Source.Path);
            ExecuteGitCommand(workingDirectory, "checkout {0}", metadata.Source.Hash);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to clone repository {Git}/{Path}@{Branch}", metadata.Source.Git, metadata.Source.Path, metadata.Source.Branch);
        }
        finally
        {
            _logger.LogInformation("Finished cloning repository {Git}/{Path}@{Branch}", metadata.Source.Git, metadata.Source.Path, metadata.Source.Branch);
        }
    }

    /// <summary>
    /// Executes a Git command in the specified working directory.
    /// </summary>
    /// <param name="workingDirectory">The directory in which to execute the Git command.</param>
    /// <param name="command">The Git command to execute, formatted as a composite string.</param>
    /// <param name="args">The arguments to format into the Git command.</param>
    private void ExecuteGitCommand(string workingDirectory, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string command, params object[] args)
    {
        try
        {
            var formattedCommand = string.Format(command, args);

            _logger.LogDebug("Executing Git command: git {Command} in {Directory}", formattedCommand, workingDirectory);

            var processStartInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = formattedCommand,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory
            };

            using var process = Process.Start(processStartInfo)!;

            process.WaitForExit();

            if (process.ExitCode is not 0)
                _logger.LogWarning("Git command returned non-zero exit code {ExitCode}: {Error}", process.ExitCode, process.StandardError.ReadToEnd());
            else
                _logger.LogTrace("Git command executed successfully: {Output}", process.StandardOutput.ReadToEnd());
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to execute Git command: {Command}", command);
        }
    }
}
