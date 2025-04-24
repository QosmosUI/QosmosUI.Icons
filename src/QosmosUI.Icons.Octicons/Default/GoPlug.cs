// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons.Default;

public class GoPlug : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M7 11.5H2.938c-.794 0-1.438.644-1.438 1.437v8.313a.75.75 0 0 1-1.5 0v-8.312A2.939 2.939 0 0 1 2.937 10H7V6.151c0-.897.678-1.648 1.57-1.74l6.055-.626 1.006-1.174A1.752 1.752 0 0 1 16.96 2h1.29c.966 0 1.75.784 1.75 1.75V6h3.25a.75.75 0 0 1 0 1.5H20V14h3.25a.75.75 0 0 1 0 1.5H20v2.25a1.75 1.75 0 0 1-1.75 1.75h-1.29a1.75 1.75 0 0 1-1.329-.611l-1.006-1.174-6.055-.627A1.749 1.749 0 0 1 7 15.348Zm9.77-7.913v.001l-1.201 1.4a.75.75 0 0 1-.492.258l-6.353.657a.25.25 0 0 0-.224.249v9.196a.25.25 0 0 0 .224.249l6.353.657c.191.02.368.112.493.258l1.2 1.401a.252.252 0 0 0 .19.087h1.29a.25.25 0 0 0 .25-.25v-14a.25.25 0 0 0-.25-.25h-1.29a.252.252 0 0 0-.19.087Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
