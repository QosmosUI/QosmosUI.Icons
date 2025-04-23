// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneViewInAr : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "points", "13,17.17 17,14.87 17,10.24 13,12.57");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "opacity", ".3");
		builder.AddAttribute(26, "points", "12,6.25 8.04,8.53 12,10.84 15.96,8.53");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "opacity", ".3");
		builder.AddAttribute(29, "points", "7,14.87 11,17.17 11,12.57 7,10.24");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M3,4c0-0.55,0.45-1,1-1h2V1H4C2.34,1,1,2.34,1,4v2h2V4z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M3,20v-2H1v2c0,1.66,1.34,3,3,3h2v-2H4C3.45,21,3,20.55,3,20z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M20,1h-2v2h2c0.55,0,1,0.45,1,1v2h2V4C23,2.34,21.66,1,20,1z");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M21,20c0,0.55-0.45,1-1,1h-2v2h2c1.66,0,3-1.34,3-3v-2h-2V20z");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M19,14.87V9.13c0-0.72-0.38-1.38-1-1.73l-5-2.88c-0.31-0.18-0.65-0.27-1-0.27s-0.69,0.09-1,0.27L6,7.39 C5.38,7.75,5,8.41,5,9.13v5.74c0,0.72,0.38,1.38,1,1.73l5,2.88c0.31,0.18,0.65,0.27,1,0.27s0.69-0.09,1-0.27l5-2.88 C18.62,16.25,19,15.59,19,14.87z M11,17.17l-4-2.3v-4.63l4,2.33V17.17z M12,10.84L8.04,8.53L12,6.25l3.96,2.28L12,10.84z M17,14.87l-4,2.3v-4.6l4-2.33V14.87z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
