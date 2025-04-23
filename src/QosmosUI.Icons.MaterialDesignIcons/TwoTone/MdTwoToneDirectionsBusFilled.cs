// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDirectionsBusFilled : ComponentBase
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
		builder.AddAttribute(21, "enable-background", "new");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M6,15c0,1.1,0.9,2,2,2h8c1.1,0,2-0.9,2-2v-3H6V15z M15.5,13 c0.83,0,1.5,0.67,1.5,1.5S16.33,16,15.5,16S14,15.33,14,14.5S14.67,13,15.5,13z M8.5,13c0.83,0,1.5,0.67,1.5,1.5S9.33,16,8.5,16 S7,15.33,7,14.5S7.67,13,8.5,13z");
		builder.AddAttribute(24, "enable-background", "new");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,4C8.48,4,7.03,4.48,6.43,5h11.24C17.13,4.46,15.71,4,12,4z");
		builder.AddAttribute(28, "enable-background", "new");
		builder.AddAttribute(29, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M12,2C8,2,4,2.5,4,6v9.5c0,0.95,0.38,1.81,1,2.44V20c0,0.55,0.45,1,1,1h1c0.55,0,1-0.45,1-1v-1h8v1c0,0.55,0.45,1,1,1h1 c0.55,0,1-0.45,1-1v-2.06c0.62-0.63,1-1.49,1-2.44V6C20,2.5,16.42,2,12,2z M12,4c3.71,0,5.13,0.46,5.67,1H6.43 C7.03,4.48,8.48,4,12,4z M18,15c0,1.1-0.9,2-2,2H8c-1.1,0-2-0.9-2-2v-3h12V15z M18,10H6V7h12V10z");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "8.5");
		builder.AddAttribute(34, "cy", "14.5");
		builder.AddAttribute(35, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "15.5");
		builder.AddAttribute(38, "cy", "14.5");
		builder.AddAttribute(39, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
