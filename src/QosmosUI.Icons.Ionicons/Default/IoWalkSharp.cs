// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoWalkSharp : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M315.09,481.38,258.14,366.26l-45-57.56a73.11,73.11,0,0,1-10.16-37.17V142h15.73A40.36,40.36,0,0,1,259,182.32V344.84");
		builder.AddAttribute(15, "stroke-linecap", "square");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "polyline");
		builder.AddAttribute(19, "points", "128.18 291.5 128.18 216.73 193.13 151.63");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "square");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "points", "376.35 295.73 292.4 239.35 292.4 194.67 397.08 267.62 376.35 295.73");
		builder.CloseElement();
		builder.OpenElement(26, "polygon");
		builder.AddAttribute(27, "points", "175.13 498.58 153.7 471.67 234.03 390.13 249.56 422.2 175.13 498.58");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "259.02");
		builder.AddAttribute(30, "cy", "67.21");
		builder.AddAttribute(31, "r", "37.38");
		builder.AddAttribute(32, "stroke-linecap", "square");
		builder.AddAttribute(33, "stroke-linejoin", "round");
		builder.AddAttribute(34, "stroke-width", "16px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
