// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFace6 : ComponentBase
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
		builder.AddAttribute(21, "d", "M6.55,7.66C7.06,6.64,8.09,6,9.24,6h5.53c1.14,0,2.17,0.64,2.68,1.66c0.94,1.87,1.66,2.08,2.26,2.24 C18.78,6.51,15.68,4,12,4S5.22,6.51,4.29,9.9C4.97,9.72,5.62,9.52,6.55,7.66z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M12,2C6.48,2,2,6.48,2,12s4.48,10,10,10s10-4.48,10-10S17.52,2,12,2z M12,4c3.68,0,6.78,2.51,7.71,5.9 c-0.6-0.16-1.33-0.37-2.26-2.24C16.94,6.64,15.91,6,14.76,6H9.24C8.09,6,7.06,6.64,6.55,7.66C5.62,9.52,4.97,9.72,4.29,9.9 C5.22,6.51,8.32,4,12,4z M12,20c-4.41,0-8-3.59-8-8c0-0.01,0-0.02,0-0.03c2.31-0.22,3.43-1.59,4.34-3.41C8.51,8.21,8.85,8,9.24,8 h5.53c0.38,0,0.72,0.21,0.89,0.55c0.9,1.8,1.99,3.19,4.34,3.41c0,0.01,0,0.02,0,0.03C20,16.41,16.41,20,12,20z");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "9");
		builder.AddAttribute(27, "cy", "13");
		builder.AddAttribute(28, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "cx", "15");
		builder.AddAttribute(31, "cy", "13");
		builder.AddAttribute(32, "r", "1.25");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
