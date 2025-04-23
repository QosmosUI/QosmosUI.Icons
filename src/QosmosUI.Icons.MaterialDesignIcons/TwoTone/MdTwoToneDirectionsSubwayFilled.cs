// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDirectionsSubwayFilled : ComponentBase
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
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M13,5h4.67C17.13,4.46,15.71,4,12,4C8.48,4,7.03,4.48,6.43,5H11H13z");
		builder.AddAttribute(23, "enable-background", "new");
		builder.AddAttribute(24, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M6,15.5C6,16.33,6.67,17,7.5,17h9c0.83,0,1.5-0.67,1.5-1.5V12H6V15.5z M15.5,13c0.83,0,1.5,0.67,1.5,1.5S16.33,16,15.5,16S14,15.33,14,14.5S14.67,13,15.5,13z M8.5,13c0.83,0,1.5,0.67,1.5,1.5 S9.33,16,8.5,16S7,15.33,7,14.5S7.67,13,8.5,13z");
		builder.AddAttribute(27, "enable-background", "new");
		builder.AddAttribute(28, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M12,2C8,2,4,2.5,4,6v9.5C4,17.43,5.57,19,7.5,19L6,20v1h12v-1l-1.5-1c1.93,0,3.5-1.57,3.5-3.5V6C20,2.5,16.42,2,12,2z M12,4c3.71,0,5.13,0.46,5.67,1H13h-2H6.43C7.03,4.48,8.48,4,12,4z M6,7h5v3H6V7z M18,15.5c0,0.83-0.67,1.5-1.5,1.5h-9 C6.67,17,6,16.33,6,15.5V12h12V15.5z M18,10h-5V7h5V10z");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "8.5");
		builder.AddAttribute(33, "cy", "14.5");
		builder.AddAttribute(34, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "15.5");
		builder.AddAttribute(37, "cy", "14.5");
		builder.AddAttribute(38, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
