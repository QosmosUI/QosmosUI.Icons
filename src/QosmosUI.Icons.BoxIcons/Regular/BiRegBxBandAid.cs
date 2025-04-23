// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxBandAid : ComponentBase
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
		builder.AddAttribute(14, "d", "M8.111 21.889a5.962 5.962 0 0 0 4.242-1.757l7.778-7.778a6.007 6.007 0 0 0 0-8.485 5.965 5.965 0 0 0-4.243-1.757 5.962 5.962 0 0 0-4.242 1.757l-7.778 7.778a6.007 6.007 0 0 0 0 8.485 5.965 5.965 0 0 0 4.243 1.757zm-2.829-8.828 7.778-7.778a3.976 3.976 0 0 1 2.828-1.171c1.069 0 2.073.416 2.829 1.171a4.006 4.006 0 0 1 0 5.657l-7.778 7.778a3.976 3.976 0 0 1-2.828 1.171 3.977 3.977 0 0 1-2.829-1.171 4.008 4.008 0 0 1 0-5.657z");
		builder.CloseElement();
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "9");
		builder.AddAttribute(17, "cy", "12");
		builder.AddAttribute(18, "r", "1");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "15");
		builder.AddAttribute(21, "cy", "12");
		builder.AddAttribute(22, "r", "1");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "12");
		builder.AddAttribute(25, "cy", "15");
		builder.AddAttribute(26, "r", "1");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "12");
		builder.AddAttribute(29, "cy", "9");
		builder.AddAttribute(30, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
