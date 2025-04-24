// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using QosmosUI.Icons.Generator.Extensions;
using QosmosUI.Icons.Generator.Models;

namespace QosmosUI.Icons.Generator.Services.Providers;

/// <summary>
/// Provides functionality for retrieving icon metadata.
/// </summary>
public sealed class IconProvider : IIconProvider
{
    /// <summary>
    /// Retrieves a collection of icon metadata.
    /// </summary>
    /// <returns>An enumerable collection of <see cref="IconMetadata"/> objects representing the icons.</returns>
    public IEnumerable<IconMetadata> GetIcons()
    {
        return
        [
            new IconMetadata
            {
                Id = "ci",
                Name = "CircumIcons",
                ProjectName = "Circum Icons",
                ProjectUrl = "https://circumicons.com",
                LicenseUrl = "https://github.com/Klarr-Agency/Circum-Icons/blob/main/LICENSE",
                License = "MPL-2.0 license",
                Source = new IconSource
                {
                    Git = "https://github.com/Klarr-Agency/Circum-Icons.git",
                    Branch = "main",
                    Hash = "cec1364b5199f55e946a9a8360385a958b98cc60",
                    Path = "svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "svg/*.svg",
                        NamePattern = static (_, name) => $"Ci{name.Replace("&", "And").ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "fa",
                Name = "FontAwesome",
                ProjectName = "Font Awesome",
                ProjectUrl = "https://fontawesome.com",
                LicenseUrl = "https://creativecommons.org/licenses/by/4.0",
                License = "CC BY 4.0 License",
                Source = new IconSource
                {
                    Git = "https://github.com/FortAwesome/Font-Awesome.git",
                    Branch = "6.x",
                    Hash = "af620534bfc3c2d4cbefcfeec29603bbe7809e64",
                    Path = "svgs/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Solid",
                        GlobPattern = "svgs/solid/*.svg",
                        NamePattern = static (_, name) => $"Fa{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Regular",
                        GlobPattern = "svgs/regular/*.svg",
                        NamePattern = static (_, name) => $"FaReg{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Brands",
                        GlobPattern = "svgs/brands/*.svg",
                        NamePattern = static (_, name) => $"Fa{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "io",
                Name = "Ionicons",
                ProjectName = "Ionicons",
                ProjectUrl = "https://ionicons.com",
                LicenseUrl = "https://github.com/ionic-team/ionicons/blob/master/LICENSE",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/ionic-team/ionicons.git",
                    Branch = "7.0.x",
                    Hash = "e358a4f4181d781af5fa308541ff07439174f6fe",
                    Path = "src/svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "src/svg/*.svg",
                        NamePattern = static (_, name) => $"Io{name.ToPascalCase()}",
                        Svgo = true
                    }
                ]
            },

            new IconMetadata
            {
                Id = "md",
                Name = "MaterialDesignIcons",
                ProjectName = "Material Design Icons",
                ProjectUrl = "https://google.github.io/material-design-icons",
                LicenseUrl = "https://github.com/google/material-design-icons/blob/master/LICENSE",
                License = "Apache License Version 2.0",
                Source = new IconSource
                {
                    Git = "https://github.com/google/material-design-icons.git",
                    Branch = "master",
                    Hash = "941fa95d7f6084a599a54ca71bc565f48e7c6d9e",
                    Path = "src/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "src/*/*/materialicons/24px.svg",
                        NamePattern = static (path, _) => $"Md{path.Split('/')[^3].ToPascalCase()}",
                        Svgo = true
                    },
                    new IconSet
                    {
                        Name = "Outline",
                        GlobPattern = "src/*/*/materialiconsoutlined/24px.svg",
                        NamePattern = static (path, _) => $"MdOutline{path.Split('/')[^3].ToPascalCase()}",
                        Svgo = true
                    },
                    new IconSet
                    {
                        Name = "Round",
                        GlobPattern = "src/*/*/materialiconsround/24px.svg",
                        NamePattern = static (path, _) => $"MdRound{path.Split('/')[^3].ToPascalCase()}",
                        Svgo = true
                    },
                    new IconSet
                    {
                        Name = "Sharp",
                        GlobPattern = "src/*/*/materialiconssharp/24px.svg",
                        NamePattern = static (path, _) => $"MdSharp{path.Split('/')[^3].ToPascalCase()}",
                        Svgo = true
                    },
                    new IconSet
                    {
                        Name = "TwoTone",
                        GlobPattern = "src/*/*/materialiconstwotone/24px.svg",
                        NamePattern = static (path, _) => $"MdTwoTone{path.Split('/')[^3].ToPascalCase()}",
                        Svgo = true
                    }
                ]
            },

            new IconMetadata
            {
                Id = "ti",
                Name = "Typicons",
                ProjectName = "Typicons",
                ProjectUrl = "https://s-ings.com/typicons",
                LicenseUrl = "https://creativecommons.org/licenses/by-sa/3.0",
                License = "CC BY-SA 3.0",
                Source = new IconSource
                {
                    Git = "https://github.com/stephenhutchings/typicons.font.git",
                    Branch = "master",
                    Hash = "0aa64f6ce8b892a83aeeafa42c74fb9c1f22ec84",
                    Path = "src/svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "src/svg/*.svg",
                        NamePattern = static (_, name) => $"Ti{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "go",
                Name = "Octicons",
                ProjectName = "Github Octicons icons",
                ProjectUrl = "https://octicons.github.com",
                LicenseUrl = "https://github.com/primer/octicons/blob/master/LICENSE",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/primer/octicons.git",
                    Branch = "main",
                    Hash = "ede8e1acef3c7c036799af286f1ee2d755f04225",
                    Path = "icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "icons/*-24.svg",
                        NamePattern = static (_, name) => $"Go{name.Replace("-24", string.Empty).ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "fi",
                Name = "Feather",
                ProjectName = "Feather",
                ProjectUrl = "https://feathericons.com",
                LicenseUrl = "https://github.com/feathericons/feather/blob/master/LICENSE",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/feathericons/feather.git",
                    Branch = "main",
                    Hash = "3dc050d97405062eba78aa57115c0a15c63abdaa",
                    Path = "icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "icons/*.svg",
                        NamePattern = static (_, name) => $"Fi{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "lu",
                Name = "Lucide",
                ProjectName = "Lucide",
                ProjectUrl = "https://lucide.dev",
                LicenseUrl = "https://github.com/lucide-icons/lucide/blob/main/LICENSE",
                License = "ISC",
                Source = new IconSource
                {
                    Git = "https://github.com/lucide-icons/lucide.git",
                    Branch = "main",
                    Hash = "a01c15cc8c791aa02052c09b04546dd13c26ddd1",
                    Path = "icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "icons/*.svg",
                        NamePattern = static (_, name) => $"Lu{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "gi",
                Name = "GameIcons",
                ProjectName = "Game Icons",
                ProjectUrl = "https://game-icons.net",
                LicenseUrl = "https://creativecommons.org/licenses/by/3.0",
                License = "CC BY 3.0",
                Source = new IconSource
                {
                    Git = "https://github.com/delacannon/game-icons-inverted.git",
                    Branch = "master",
                    Hash = "12920d6565588f0512542a3cb0cdfd36a497f910",
                    Path = "all-icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "all-icons/*.svg",
                        NamePattern = static (_, name) => $"Gi{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "wi",
                Name = "WeatherIcons",
                ProjectName = "Weather Icons",
                ProjectUrl = "https://erikflowers.github.io/weather-icons",
                LicenseUrl = "https://scripts.sil.org/OFL",
                License = "SIL OFL 1.1",
                Source = new IconSource
                {
                    Git = "https://github.com/erikflowers/weather-icons.git",
                    Branch = "master",
                    Hash = "bb80982bf1f43f2d57f9dd753e7413bf88beb9ed",
                    Path = "svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "svg/*.svg",
                        NamePattern = static (_, name) => name.ToPascalCase()
                    }
                ]
            },

            new IconMetadata
            {
                Id = "di",
                Name = "Devicons",
                ProjectName = "Devicons",
                ProjectUrl = "https://vorillaz.github.io/devicons",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/vorillaz/devicons.git",
                    Branch = "master",
                    Hash = "ba75593fdf8d66496676a90cbf127d721f73e961",
                    Path = "!SVG/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "!SVG/*.svg",
                        NamePattern = static (_, name) => $"Di{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "ai",
                Name = "AntDesignIcons",
                ProjectName = "Ant Design Icons",
                ProjectUrl = "https://github.com/ant-design/ant-design-icons",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/ant-design/ant-design-icons.git",
                    Branch = "master",
                    Hash = "5542f4848a0bfecf3a8c20e30f22272b5a508d4e",
                    Path = "packages/icons-svg/svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Fill",
                        GlobPattern = "packages/icons-svg/svg/filled/*.svg",
                        NamePattern = static (_, name) => $"AiFill{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Outline",
                        GlobPattern = "packages/icons-svg/svg/outlined/*.svg",
                        NamePattern = static (_, name) => $"AiOutline{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "TwoTone",
                        GlobPattern = "packages/icons-svg/svg/filled/*.svg",
                        NamePattern = static (_, name) => $"AiTwoTone{name.ToPascalCase()}",
                        MultiColor = true
                    }
                ]
            },

            new IconMetadata
            {
                Id = "bs",
                Name = "BootstrapIcons",
                ProjectName = "Bootstrap Icons",
                ProjectUrl = "https://github.com/twbs/icons",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/twbs/icons.git",
                    Branch = "main",
                    Hash = "7211bb3526c4f9b81da736a41aedf21a24f182be",
                    Path = "icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "icons/*.svg",
                        ExcludePatterns = ["icons/*-fill.svg", "icons/*-reverse.svg", "icons/*reverse-*.svg"],
                        NamePattern = static (_, name) => $"Bs{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Fill",
                        GlobPattern = "icons/*-fill.svg",
                        ExcludePatterns = ["icons/*-reverse-fill.svg"],
                        NamePattern = static (_, name) => $"BsFill{name.Replace("fill", string.Empty).ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Reverse",
                        GlobPattern = "icons/*-reverse*.svg",
                        ExcludePatterns = ["icons/*-reverse-fill.svg"],
                        NamePattern = static (_, name) => $"BsReverse{name.Replace("reverse", string.Empty).ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "ri",
                Name = "RemixIcons",
                ProjectName = "Remix Icons",
                ProjectUrl = "https://github.com/Remix-Design/RemixIcon",
                LicenseUrl = "https://www.apache.org/licenses",
                License = "Apache License Version 2.0",
                Source = new IconSource
                {
                    Git = "https://github.com/Remix-Design/RemixIcon.git",
                    Branch = "master",
                    Hash = "8bc436bdd329cf342958d8effdd078bfa74354c6",
                    Path = "icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "icons/*/*.svg",
                        NamePattern = static (_, name) => $"Ri{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "fc",
                Name = "FlatColorIcons",
                ProjectName = "Flat Color Icons",
                ProjectUrl = "https://github.com/icons8/flat-color-icons",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/icons8/flat-color-icons.git",
                    Branch = "master",
                    Hash = "8eccbbbd8b2af1d2c9593e7cfba5ecb0d68ee378",
                    Path = "svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "svg/*.svg",
                        NamePattern = static (_, name) => $"Fc{name.ToPascalCase()}",
                        MultiColor = true
                    }
                ]
            },

            new IconMetadata
            {
                Id = "gr",
                Name = "GrommetIcons",
                ProjectName = "Grommet-Icons",
                ProjectUrl = "https://github.com/grommet/grommet-icons",
                LicenseUrl = "https://www.apache.org/licenses",
                License = "Apache License Version 2.0",
                Source = new IconSource
                {
                    Git = "https://github.com/grommet/grommet-icons.git",
                    Branch = "master",
                    Hash = "469590e6fb8b7a684756308f96a45a8425580f05",
                    Path = "public/img/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "public/img/*.svg",
                        NamePattern = static (_, name) => $"Gr{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "hi",
                Name = "Heroicons",
                ProjectName = "Heroicons",
                ProjectUrl = "https://github.com/tailwindlabs/heroicons",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/tailwindlabs/heroicons.git",
                    Branch = "master",
                    Hash = "fa902f44d071eac776758cfd6e0522cb7c37b1c3",
                    Path = "optimized/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Solid",
                        GlobPattern = "optimized/24/solid/*.svg",
                        NamePattern = static (_, name) => $"HiSolid{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Outline",
                        GlobPattern = "optimized/24/outline/*.svg",
                        NamePattern = static (_, name) => $"HiOutline{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Mini",
                        GlobPattern = "optimized/20/solid/*.svg",
                        NamePattern = static (_, name) => $"HiMini{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "si",
                Name = "SimpleIcons",
                ProjectName = "Simple Icons",
                ProjectUrl = "https://simpleicons.org",
                LicenseUrl = "https://creativecommons.org/publicdomain/zero/1.0",
                License = "CC0 1.0 Universal",
                Source = new IconSource
                {
                    Git = "https://github.com/simple-icons/simple-icons.git",
                    Branch = "develop",
                    Hash = "4a3c704ae73348bc1b8ecccd40d6a73d9497dfad",
                    Path = "icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "icons/*.svg",
                        NamePattern = static (_, name) => $"Si{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "sl",
                Name = "SimpleLineIcons",
                ProjectName = "Simple Line Icons",
                ProjectUrl = "https://thesabbir.github.io/simple-line-icons",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/simple-icons/simple-icons.git",
                    Branch = "master",
                    Hash = "f3ed94dd797bdcab52d6f27ba589aea4bb6f3e4d",
                    Path = "src/svgs/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "src/svgs/*.svg",
                        NamePattern = static (_, name) => $"Sl{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "im",
                Name = "IcoMoonFree",
                ProjectName = "IcoMoon Free",
                ProjectUrl = "https://github.com/Keyamoon/IcoMoon-Free",
                LicenseUrl = "https://github.com/Keyamoon/IcoMoon-Free/blob/master/License.txt",
                License = "CC BY 4.0 License",
                Source = new IconSource
                {
                    Git = "https://github.com/Keyamoon/IcoMoon-Free.git",
                    Branch = "master",
                    Hash = "d006795ede82361e1bac1ee76f215cf1dc51e4ca",
                    Path = "SVG/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "SVG/*.svg",
                        NamePattern = static (_, name) => $"Im{name[3..].ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "bi",
                Name = "BoxIcons",
                ProjectName = "BoxIcons",
                ProjectUrl = "https://github.com/atisawd/boxicons",
                LicenseUrl = "https://github.com/atisawd/boxicons/blob/master/LICENSE",
                License = "CC BY 4.0 License",
                Source = new IconSource
                {
                    Git = "https://github.com/atisawd/boxicons.git",
                    Branch = "master",
                    Hash = "9ffa9136e8681886bb7bd2145cd4098717ce1c11",
                    Path = "svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Regular",
                        GlobPattern = "svg/regular/*.svg",
                        NamePattern = static (_, name) => $"BiReg{name.Replace("Bx", string.Empty).ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Solid",
                        GlobPattern = "svg/solid/*.svg",
                        NamePattern = static (_, name) => $"BiSolid{name.Replace("Bxs", string.Empty).ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Logo",
                        GlobPattern = "svg/logos/*.svg",
                        NamePattern = static (_, name) => $"BiLogo{name.Replace("Bxl", string.Empty).ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "cg",
                Name = "Css",
                ProjectName = "css.gg",
                ProjectUrl = "https://github.com/astrit/css.gg",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/astrit/css.gg.git",
                    Branch = "main",
                    Hash = "ad0428df5491082b29a81d64dbdc59b9602cc059",
                    Path = "svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "svg/*.svg",
                        NamePattern = static (_, name) => $"Cg{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "vsc",
                Name = "VsCodeIcons",
                ProjectName = "VS Code Icons",
                ProjectUrl = "https://github.com/microsoft/vscode-codicons",
                LicenseUrl = "https://creativecommons.org/licenses/by/4.0",
                License = "CC BY 4.0",
                Source = new IconSource
                {
                    Git = "https://github.com/microsoft/vscode-codicons.git",
                    Branch = "main",
                    Hash = "17ce4c853be20e26901867ab3442c1e353096f6d",
                    Path = "src/icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "src/icons/*.svg",
                        NamePattern = static (_, name) => $"Vsc{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "tb",
                Name = "TablerIcons",
                ProjectName = "Tabler Icons",
                ProjectUrl = "https://github.com/tabler/tabler-icons",
                LicenseUrl = "https://opensource.org/licenses/MIT",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/tabler/tabler-icons.git",
                    Branch = "main",
                    Hash = "cade2ac67f6c09f96363f096410172ebd1cc9eb3",
                    Path = "icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Fill",
                        GlobPattern = "icons/filled/*.svg",
                        NamePattern = static (_, name) => $"TbFill{name.ToPascalCase()}"
                    },
                    new IconSet
                    {
                        Name = "Outline",
                        GlobPattern = "icons/outline/*.svg",
                        NamePattern = static (_, name) => $"TbOutline{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "tfi",
                Name = "Themify",
                ProjectName = "Themify Icons",
                ProjectUrl = "https://github.com/lykmapipo/themify-icons",
                LicenseUrl = "https://github.com/thecreation/standard-icons/blob/master/modules/themify-icons/LICENSE",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/lykmapipo/themify-icons.git",
                    Branch = "master",
                    Hash = "9600186b24a7242f0e1e0a186983e6253301bb5d",
                    Path = "SVG/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "SVG/*.svg",
                        NamePattern = static (_, name) => $"Tfi{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "rx",
                Name = "RadixIcons",
                ProjectName = "Radix Icons",
                ProjectUrl = "https://icons.radix-ui.com",
                LicenseUrl = "https://github.com/radix-ui/icons/blob/master/LICENSE",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/radix-ui/icons.git",
                    Branch = "master",
                    Hash = "bde33b13aa5848555f5512ac12155930fb4beb7d",
                    Path = "packages/radix-icons/icons/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "packages/radix-icons/icons/*.svg",
                        NamePattern = static (_, name) => $"Rx{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "pi",
                Name = "PhosphorIcons",
                ProjectName = "Phosphor Icons",
                ProjectUrl = "https://github.com/phosphor-icons/core",
                LicenseUrl = "https://github.com/phosphor-icons/core/blob/main/LICENSE",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/phosphor-icons/core.git",
                    Branch = "main",
                    Hash = "6cd298063c98c8b198b0da7e6dd78400f631bdc3",
                    Path = "assets/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "assets/*.svg",
                        NamePattern = static (_, name) => $"Pi{name.ToPascalCase()}"
                    }
                ]
            },

            new IconMetadata
            {
                Id = "lia",
                Name = "Icons8LineAwesome",
                ProjectName = "Icons8 Line Awesome",
                ProjectUrl = "https://icons8.com/line-awesome",
                LicenseUrl = "https://github.com/icons8/line-awesome/blob/master/LICENSE.md",
                License = "MIT",
                Source = new IconSource
                {
                    Git = "https://github.com/icons8/line-awesome.git",
                    Branch = "master",
                    Hash = "78a101217707c9b1c4dcf2a821be75684e36307f",
                    Path = "svg/"
                },
                Sets =
                [
                    new IconSet
                    {
                        Name = "Default",
                        GlobPattern = "svg/*.svg",
                        NamePattern = static (_, name) => $"Lia{name.ToPascalCase()}"
                    }
                ]
            }
        ];
    }
}
