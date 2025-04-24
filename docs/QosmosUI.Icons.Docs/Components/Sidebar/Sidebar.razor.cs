// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;

namespace QosmosUI.Icons.Docs.Components.Sidebar;

public partial class Sidebar : ComponentBase
{
    [Parameter]
    [NotNull]
    public RenderFragment? ChildContent { get; set; }
}
