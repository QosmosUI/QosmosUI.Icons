// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoIdCardOutline : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "96");
		builder.AddAttribute(15, "y", "32");
		builder.AddAttribute(16, "width", "320");
		builder.AddAttribute(17, "height", "448");
		builder.AddAttribute(18, "rx", "48");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "208");
		builder.AddAttribute(24, "y1", "80");
		builder.AddAttribute(25, "x2", "304");
		builder.AddAttribute(26, "y2", "80");
		builder.AddAttribute(27, "fill", "none");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-linejoin", "round");
		builder.AddAttribute(30, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M333.48,284.51A39.65,39.65,0,0,0,304,272c-11.6,0-22.09,4.41-29.54,12.43s-11.2,19.12-10.34,31C265.83,338.91,283.72,358,304,358s38.14-19.09,39.87-42.55C344.75,303.67,341.05,292.68,333.48,284.51Z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M371.69,448H236.31a12.05,12.05,0,0,1-9.31-4.17,13,13,0,0,1-2.76-10.92c3.25-17.56,13.38-32.31,29.3-42.66C267.68,381.06,285.6,376,304,376s36.32,5.06,50.46,14.25c15.92,10.35,26.05,25.1,29.3,42.66A13,13,0,0,1,381,443.83,12.05,12.05,0,0,1,371.69,448Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
