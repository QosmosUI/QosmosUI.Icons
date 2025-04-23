// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTonePalette : ComponentBase
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
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M12,4c-4.41,0-8,3.59-8,8s3.59,8,8,8c0.28,0,0.5-0.22,0.5-0.5 c0-0.16-0.08-0.28-0.14-0.35c-0.41-0.46-0.63-1.05-0.63-1.65c0-1.38,1.12-2.5,2.5-2.5H16c2.21,0,4-1.79,4-4 C20,7.14,16.41,4,12,4z M6.5,13C5.67,13,5,12.33,5,11.5S5.67,10,6.5,10S8,10.67,8,11.5S7.33,13,6.5,13z M9.5,9 C8.67,9,8,8.33,8,7.5S8.67,6,9.5,6S11,6.67,11,7.5S10.33,9,9.5,9z M14.5,9C13.67,9,13,8.33,13,7.5S13.67,6,14.5,6 S16,6.67,16,7.5S15.33,9,14.5,9z M19,11.5c0,0.83-0.67,1.5-1.5,1.5S16,12.33,16,11.5s0.67-1.5,1.5-1.5S19,10.67,19,11.5z");
		builder.AddAttribute(24, "enable-background", "new");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,2C6.49,2,2,6.49,2,12s4.49,10,10,10c1.38,0,2.5-1.12,2.5-2.5c0-0.61-0.23-1.21-0.64-1.67 c-0.08-0.09-0.13-0.21-0.13-0.33c0-0.28,0.22-0.5,0.5-0.5H16c3.31,0,6-2.69,6-6C22,6.04,17.51,2,12,2z M16,15h-1.77 c-1.38,0-2.5,1.12-2.5,2.5c0,0.61,0.22,1.19,0.63,1.65c0.06,0.07,0.14,0.19,0.14,0.35c0,0.28-0.22,0.5-0.5,0.5 c-4.41,0-8-3.59-8-8s3.59-8,8-8s8,3.14,8,7C20,13.21,18.21,15,16,15z");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "6.5");
		builder.AddAttribute(30, "cy", "11.5");
		builder.AddAttribute(31, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "9.5");
		builder.AddAttribute(34, "cy", "7.5");
		builder.AddAttribute(35, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "14.5");
		builder.AddAttribute(38, "cy", "7.5");
		builder.AddAttribute(39, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "17.5");
		builder.AddAttribute(42, "cy", "11.5");
		builder.AddAttribute(43, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
