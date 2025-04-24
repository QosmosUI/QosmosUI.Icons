// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiAnchor : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M15.291 12.592l-1.57-3.127-3.127 1.568 0.448 0.895 1.871-0.939c-0.373 1.907-1.956 3.365-3.913 3.585v-7.574h1.5v-1h-1.5v-1.051c1.14-0.232 2-1.241 2-2.449 0-1.379-1.122-2.5-2.5-2.5s-2.5 1.121-2.5 2.5c0 1.208 0.86 2.217 2 2.449v1.051h-1.5v1h1.5v7.574c-1.955-0.22-3.538-1.676-3.912-3.58l1.86 0.934 0.448-0.895-3.127-1.568-1.57 3.127 0.894 0.449 0.651-1.298c0.693 2.245 2.787 3.882 5.256 3.882 2.464 0 4.556-1.63 5.252-3.867l0.645 1.283 0.894-0.449zM7 2.5c0-0.827 0.673-1.5 1.5-1.5s1.5 0.673 1.5 1.5-0.673 1.5-1.5 1.5-1.5-0.673-1.5-1.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
