// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons;

/// <summary>
/// A Blazor component that dynamically renders another component based on the specified type.
/// </summary>
public class DynamicIcon : ComponentBase
{
    /// <summary>
    /// Gets or sets the type of the component to render.
    /// </summary>
    [Parameter]
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
    public Type? IconType { get; set; }

    /// <summary>
    /// Gets or sets additional attributes to be passed to the dynamically rendered component.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    /// <summary>
    /// Builds the render tree for the component.
    /// </summary>
    /// <param name="builder">The <see cref="RenderTreeBuilder"/> used to build the component's render tree.</param>
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (IconType is null)
            return;

        builder.OpenComponent(0, IconType);
        builder.AddMultipleAttributes(1, AdditionalAttributes);
        builder.CloseComponent();
    }
}
