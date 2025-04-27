<p align="center">
  <img src="QosmosUI.png" alt="QosmosUI" width="160" />
  <h1 align="center">QosmosUI</h1>
</p>

<p align="center">
  <a href="https://github.com/QosmosUI/QosmosUI.Icons/actions">
    <img src="https://img.shields.io/github/actions/workflow/status/QosmosUI/QosmosUI.Icons/dotnet.yml?branch=main&logo=github&style=flat-square" alt="Build Status">
  </a>
  <a href="https://github.com/QosmosUI/QosmosUI.Icons/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/QosmosUI/QosmosUI.Icons?style=flat-square" alt="License">
  </a>
</p>

---

<p align="center">
  A comprehensive and high-performance icon library for Blazor, inspired by react-icons.
</p>

---

## Table of Contents

- [Installation](#installation)
- [Basic Usage](#basic-usage)
- [Advanced Usage](#advanced-usage)
- [Customization](#customization)
- [Using DynamicIcon](#using-dynamicicon)
- [Available Icon Libraries](#available-icon-libraries)

## NuGet Packages

### Main Package

| Package | Version | Downloads | Description |
|---------|---------|-----------|-------------|
| QosmosUI.Icons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.svg)](https://www.nuget.org/packages/QosmosUI.Icons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.svg)](https://www.nuget.org/packages/QosmosUI.Icons/) | Meta-package that includes all QosmosUI icon libraries |

### Individual Icon Libraries

| Package | Version | Downloads |
|--------------|---------------|------------------------|
| QosmosUI.Icons.AntDesignIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.AntDesignIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.AntDesignIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.AntDesignIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.AntDesignIcons/) |
| QosmosUI.Icons.BootstrapIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.BootstrapIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.BootstrapIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.BootstrapIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.BootstrapIcons/) |
| QosmosUI.Icons.BoxIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.BoxIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.BoxIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.BoxIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.BoxIcons/) |
| QosmosUI.Icons.CircumIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.CircumIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.CircumIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.CircumIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.CircumIcons/) |
| QosmosUI.Icons.DevIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.DevIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.DevIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.DevIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.DevIcons/) |
| QosmosUI.Icons.Feather | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.Feather.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Feather/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.Feather.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Feather/) |
| QosmosUI.Icons.FlatColorIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.FlatColorIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.FlatColorIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.FlatColorIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.FlatColorIcons/) |
| QosmosUI.Icons.FontAwesome | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.FontAwesome.svg)](https://www.nuget.org/packages/QosmosUI.Icons.FontAwesome/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.FontAwesome.svg)](https://www.nuget.org/packages/QosmosUI.Icons.FontAwesome/) |
| QosmosUI.Icons.GameIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.GameIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.GameIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.GameIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.GameIcons/) |
| QosmosUI.Icons.GrommetIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.GrommetIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.GrommetIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.GrommetIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.GrommetIcons/) |
| QosmosUI.Icons.HeroIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.HeroIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.HeroIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.HeroIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.HeroIcons/) |
| QosmosUI.Icons.IcoMoonFree | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.IcoMoonFree.svg)](https://www.nuget.org/packages/QosmosUI.Icons.IcoMoonFree/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.IcoMoonFree.svg)](https://www.nuget.org/packages/QosmosUI.Icons.IcoMoonFree/) |
| QosmosUI.Icons.Icons8LineAwesome | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.Icons8LineAwesome.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Icons8LineAwesome/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.Icons8LineAwesome.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Icons8LineAwesome/) |
| QosmosUI.Icons.IonIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.IonIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.IonIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.IonIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.IonIcons/) |
| QosmosUI.Icons.Lucide | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.Lucide.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Lucide/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.Lucide.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Lucide/) |
| QosmosUI.Icons.MaterialDesignIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.MaterialDesignIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.MaterialDesignIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.MaterialDesignIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.MaterialDesignIcons/) |
| QosmosUI.Icons.OctIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.OctIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.OctIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.OctIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.OctIcons/) |
| QosmosUI.Icons.RadixIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.RadixIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.RadixIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.RadixIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.RadixIcons/) |
| QosmosUI.Icons.RemixIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.RemixIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.RemixIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.RemixIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.RemixIcons/) |
| QosmosUI.Icons.SimpleIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.SimpleIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.SimpleIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.SimpleIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.SimpleIcons/) |
| QosmosUI.Icons.TablerIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.TablerIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.TablerIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.TablerIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.TablerIcons/) |
| QosmosUI.Icons.Themify | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.Themify.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Themify/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.Themify.svg)](https://www.nuget.org/packages/QosmosUI.Icons.Themify/) |
| QosmosUI.Icons.TypIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.TypIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.TypIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.TypIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.TypIcons/) |
| QosmosUI.Icons.VsCodeIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.VsCodeIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.VsCodeIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.VsCodeIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.VsCodeIcons/) |
| QosmosUI.Icons.WeatherIcons | [![NuGet](https://img.shields.io/nuget/v/QosmosUI.Icons.WeatherIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.WeatherIcons/) | [![NuGet](https://img.shields.io/nuget/dt/QosmosUI.Icons.WeatherIcons.svg)](https://www.nuget.org/packages/QosmosUI.Icons.WeatherIcons/) |

## Installation

### Main Package

Install all icon libraries in a single package:

```bash
dotnet add package QosmosUI.Icons
```

### Individual Packages

If you prefer to install only the specific icon libraries you need:

```bash
# For example, to install only FontAwesome icons
dotnet add package QosmosUI.Icons.FontAwesome

# Or Bootstrap icons
dotnet add package QosmosUI.Icons.BootstrapIcons
```

## Basic Usage

### 1. Add the appropriate namespace

```razor
@using QosmosUI.Icons.FontAwesome.Solid
```

### 2. Use the icon in your Blazor component

```razor
<FaHouse />
```

## Advanced Usage

### Importing multiple libraries

```razor
@using QosmosUI.Icons.FontAwesome.Solid
@using QosmosUI.Icons.MaterialDesignIcons.Fill

<div>
    <FaHouse />
    <MdFillHome />
</div>
```

### Customization

All icons accept the following parameters for customization:

| Parameter | Description | Default Value    |
|-----------|-------------|------------------|
| `Title` | Adds an accessible title to the icon | `""`             |
| `Size` | Sets the icon size | `"1em"`          |
| `Stroke` | Outline color | `"currentColor"` |
| `Fill` | Fill color | `"currentColor"` |
| `StrokeWidth` | Outline thickness | `"0"`            |
| `StrokeLinecap` | Style of line endings | `"round"`        |
| `StrokeLinejoin` | Style of line joins | `"round"`        |
| `ViewBox` | Defines the SVG viewport | `"0 0 24 24"`    |
| `AdditionalAttributes` | Dictionary that captures all other unmatched parameters | `null` |          |

Example with customization:

```razor
<AiFillAccountBook
    Size="24px"
    Fill="red"
    Title="Account Book" />
```

### Additional attributes

You can also pass any additional HTML attributes to the icon:

```razor
<FaHouse
    class="my-icon"
    style="margin-right: 8px;" />
```

## Using DynamicIcon

The `DynamicIcon` component allows you to dynamically load any icon based on its Type:

```razor
@using QosmosUI.Icons
@using QosmosUI.Icons.FontAwesome.Solid

<DynamicIcon IconType="typeof(FaHouse)" Size="24px" Fill="blue" />
```

This is particularly useful when you want to change icons dynamically based on certain conditions:

```razor
@using QosmosUI.Icons
@using QosmosUI.Icons.FontAwesome.Solid
@using QosmosUI.Icons.FontAwesome.Regular

<button @onclick="ToggleIcon">Toggle Icon</button>
<DynamicIcon IconType="IconType" Size="24px" />

@code {
    private Type IconType { get; set; } = typeof(FaHouse);

    private void ToggleIcon()
    {
        IconType = IconType == typeof(FaHouse)
            ? typeof(FaRegHouse)
            : typeof(FaHouse);
    }
}
```

## Available Icon Libraries

QosmosUI.Icons offers a vast collection of popular icon libraries:

- **AntDesignIcons** - Icons from Ant Design system
- **BootstrapIcons** - Bootstrap's icon collection
- **BoxIcons** - Simple and elegant open source icon collection
- **CircumIcons** - Minimalist and consistent icons
- **DevIcons** - Icons representing programming languages and development tools
- **Feather** - Simply beautiful open source icons
- **FlatColorIcons** - Colored icons with flat design
- **FontAwesome** - The web's most popular icon library
- **GameIcons** - Collection of game-oriented icons
- **GrommetIcons** - Icon set for the Grommet design system
- **HeroIcons** - Beautiful SVG icons by the Tailwind CSS team
- **IcoMoonFree** - Free icon pack from IcoMoon
- **Icons8LineAwesome** - Font Awesome alternative icon pack
- **IonIcons** - Premium icons designed for iOS, Android, and web applications
- **Lucide** - Neat and consistent icon library
- **MaterialDesignIcons** - Google's Material Design icons
- **OctIcons** - GitHub's icons
- **RadixIcons** - A carefully designed icon set by the Radix team
- **RemixIcons** - Set of neutral and consistent open source symbols
- **SimpleIcons** - Free SVG brand icons
- **TablerIcons** - Set of over 4,200 free and open source icons
- **Themify** - Themify user interface icon collection
- **TypIcons** - Set of minimal and free web icons
- **VsCodeIcons** - Icons inspired by Visual Studio Code
- **WeatherIcons** - Collection of weather icons

## Contributing

Please read the [contributing guide](CONTRIBUTING.md).

## License

Licensed under the [MIT license](LICENSE).
