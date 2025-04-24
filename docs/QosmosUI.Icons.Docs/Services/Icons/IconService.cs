// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Diagnostics;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using QosmosUI.Icons.Docs.Models;

namespace QosmosUI.Icons.Docs.Services.Icons;

/// <summary>
/// Provides services for managing and retrieving icon manifest items.
/// </summary>
public sealed class IconService : IIconService
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Stores the collection of icon manifest items.
    /// </summary>
    private IEnumerable<IconManifestItem> _manifests;

    /// <summary>
    /// Initializes a new instance of the <see cref="IconService"/> class.
    /// </summary>
    /// <param name="httpClient">The <see cref="HttpClient"/> used to fetch icon manifest data.</param>
    public IconService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _manifests = [];
    }

    /// <summary>
    /// Asynchronously initializes the icon service by loading and organizing icon manifest data.
    /// </summary>
    /// <returns>A task that represents the asynchronous initialization operation.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown if an icon type does not match the expected namespace format,
    /// or if an icon set or type is not found in the manifest.
    /// </exception>
    public async Task InitializeAsync()
    {
        var manifests = await _httpClient.GetFromJsonAsync<IconManifestItem[]>("data/manifest.json");

        Debug.Assert(manifests is not null);

        _manifests = manifests.OrderBy(static x => x.Name);

        var assemblies = new[]
        {
            typeof(BoxIcons.Logo.BiLogoBxl99designs).Assembly,
            typeof(Octicons.Default.GoAccessibility).Assembly,
            typeof(AntDesignIcons.Fill.AiFillAccountBook).Assembly,
            typeof(BootstrapIcons.Default.Bs0Circle).Assembly,
            typeof(CircumIcons.Default.CiAirportSign1).Assembly,
            typeof(Devicons.Default.DiAndroid).Assembly,
            typeof(Feather.Default.FiActivity).Assembly,
            typeof(FlatColorIcons.Default.FcAbout).Assembly,
            typeof(FontAwesome.Brands.Fa42Group).Assembly,
            typeof(GameIcons.Default.Gi3dGlasses).Assembly,
            typeof(GrommetIcons.Default.GrAccessibility).Assembly,
            typeof(Heroicons.Mini.HiMiniAcademicCap).Assembly,
            typeof(IcoMoonFree.Default.Im500px).Assembly,
            typeof(Icons8LineAwesome.Default.Lia500px).Assembly,
            typeof(Ionicons.Default.IoAccessibility).Assembly,
            typeof(Lucide.Default.LuAArrowDown).Assembly,
            typeof(MaterialDesignIcons.Default.Md1k).Assembly,
            typeof(RadixIcons.Default.RxAccessibility).Assembly,
            typeof(RemixIcons.Default.Ri4kFill).Assembly,
            typeof(SimpleIcons.Default.Si1and1).Assembly,
            typeof(TablerIcons.Fill.TbFillAccessible).Assembly,
            typeof(Themify.Default.TfiAgenda).Assembly,
            typeof(Typicons.Default.TiAdjustBrightness).Assembly,
            typeof(VsCodeIcons.Default.VscAccount).Assembly,
            typeof(WeatherIcons.Default.WiAlien).Assembly
        };

        foreach (var type in assemblies
                     .SelectMany(static a => a.GetTypes())
                     .Where(static t => t is { IsClass: true, IsAbstract: false } && t.BaseType == typeof(ComponentBase) && t != typeof(DynamicIcon)))
        {
            if (type.Namespace!.Split('.') is not ["QosmosUI", "Icons", var setName, var subSetName])
                throw new InvalidOperationException($"Icon type '{type.FullName}' does not match the expected namespace format.");

            var manifest = manifests.FirstOrDefault(x => x.Name == setName);

            if (manifest is null)
                throw new InvalidOperationException($"Icon set '{setName}' not found in manifest.");

            if (!manifest.Sets.TryGetValue(subSetName, out var set))
                manifest.Sets[subSetName] = set = [];

            if (set.Contains(type))
                throw new InvalidOperationException($"Icon type '{type.FullName}' already exists in the manifest.");

            set.Add(type);
        }
    }

    /// <summary>
    /// Retrieves the collection of icon manifest items.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> containing <see cref="IconManifestItem"/> objects.</returns>
    public IEnumerable<IconManifestItem> GetManifests()
    {
        return _manifests;
    }
}
