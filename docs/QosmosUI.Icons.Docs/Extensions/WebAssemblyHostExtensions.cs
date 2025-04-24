// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using QosmosUI.Icons.Docs.Services;
using QosmosUI.Icons.Docs.Services.Icons;

namespace QosmosUI.Icons.Docs.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="WebAssemblyHost"/> class.
/// </summary>
public static class WebAssemblyHostExtensions
{
    /// <summary>
    /// Runs the WebAssembly host as a Qosmos application.
    /// </summary>
    /// <param name="host">The <see cref="WebAssemblyHost"/> instance.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    /// <remarks>
    /// This method initializes the <see cref="IconService"/> and starts the WebAssembly host.
    /// </remarks>
    public static async Task RunAsQosmosApp(this WebAssemblyHost host)
    {
        await host.Services.GetRequiredService<IconService>().InitializeAsync();
        await host.RunAsync();
    }
}
