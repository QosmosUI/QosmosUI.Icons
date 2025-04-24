using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using QosmosUI.Icons.Docs;
using QosmosUI.Icons.Docs.Extensions;
using QosmosUI.Icons.Docs.Services.Icons;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddSingleton<IconService>()
    .AddSingleton<IIconService>(static provider => provider.GetRequiredService<IconService>())
    .AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsQosmosApp();
