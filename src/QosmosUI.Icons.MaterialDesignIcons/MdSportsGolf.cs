// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdSportsGolf : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,16c3.87,0,7-3.13,7-7c0-3.87-3.13-7-7-7S5,5.13,5,9C5,12.87,8.13,16,12,16z M12,4c2.76,0,5,2.24,5,5s-2.24,5-5,5 s-5-2.24-5-5S9.24,4,12,4z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "10");
		builder.AddAttribute(24, "cy", "8");
		builder.AddAttribute(25, "r", "1");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "14");
		builder.AddAttribute(28, "cy", "8");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "12");
		builder.AddAttribute(32, "cy", "6");
		builder.AddAttribute(33, "r", "1");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M7,19h2c1.1,0,2,0.9,2,2v1h2v-1c0-1.1,0.9-2,2-2h2v-2H7V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
