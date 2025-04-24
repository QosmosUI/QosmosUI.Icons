using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using QosmosUI.Icons.Generator.Services.Git;
using QosmosUI.Icons.Generator.Services.Orchestrators;
using QosmosUI.Icons.Generator.Services.Processors;
using QosmosUI.Icons.Generator.Services.Providers;
using QosmosUI.Icons.Generator.Services.Renderers;

new ServiceCollection()
    .AddLogging(static builder => builder.ClearProviders().AddConsole())
    .AddSingleton<IRepository, GitRepository>()
    .AddSingleton<IIconProvider, IconProvider>()
    .AddSingleton<ISvgProcessor, SvgProcessor>()
    .AddSingleton<IComponentRenderer, RazorComponentRenderer>()
    .AddSingleton<ICsprojRenderer, CsprojRenderer>()
    .AddSingleton<IIconOrchestrator, IconOrchestrator>()
    .BuildServiceProvider(true)
    .GetRequiredService<IIconOrchestrator>()
    .GenerateIcons();
