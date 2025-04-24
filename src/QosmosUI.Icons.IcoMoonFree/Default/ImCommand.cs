// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImCommand : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M11.5 14c-1.379 0-2.5-1.121-2.5-2.5v-1.5h-2v1.5c0 1.379-1.122 2.5-2.5 2.5s-2.5-1.121-2.5-2.5 1.122-2.5 2.5-2.5h1.5v-2h-1.5c-1.378 0-2.5-1.122-2.5-2.5s1.122-2.5 2.5-2.5 2.5 1.122 2.5 2.5v1.5h2v-1.5c0-1.378 1.121-2.5 2.5-2.5s2.5 1.122 2.5 2.5-1.121 2.5-2.5 2.5h-1.5v2h1.5c1.379 0 2.5 1.121 2.5 2.5s-1.121 2.5-2.5 2.5zM10 10v1.5c0 0.827 0.673 1.5 1.5 1.5s1.5-0.673 1.5-1.5-0.673-1.5-1.5-1.5h-1.5zM4.5 10c-0.827 0-1.5 0.673-1.5 1.5s0.673 1.5 1.5 1.5 1.5-0.673 1.5-1.5v-1.5h-1.5zM7 9h2v-2h-2v2zM10 6h1.5c0.827 0 1.5-0.673 1.5-1.5s-0.673-1.5-1.5-1.5-1.5 0.673-1.5 1.5v1.5zM4.5 3c-0.827 0-1.5 0.673-1.5 1.5s0.673 1.5 1.5 1.5h1.5v-1.5c0-0.827-0.673-1.5-1.5-1.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
