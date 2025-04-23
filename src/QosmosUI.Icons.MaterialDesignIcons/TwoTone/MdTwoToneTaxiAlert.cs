// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneTaxiAlert : ComponentBase
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
		builder.AddAttribute(21, "d", "M4,18h14v-5H4V18z M15.5,14c0.83,0,1.5,0.67,1.5,1.5S16.33,17,15.5,17 S14,16.33,14,15.5S14.67,14,15.5,14z M6.5,14C7.33,14,8,14.67,8,15.5S7.33,17,6.5,17S5,16.33,5,15.5S5.67,14,6.5,14z");
		builder.AddAttribute(22, "enable-background", "new");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "6.5");
		builder.AddAttribute(26, "cy", "15.5");
		builder.AddAttribute(27, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "15.5");
		builder.AddAttribute(30, "cy", "15.5");
		builder.AddAttribute(31, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M18,18H4v-5h14c-1.91,0-3.63-0.76-4.89-2H4.81l1.04-3h5.44C11.1,7.37,11,6.7,11,6s0.1-1.37,0.29-2H8v2H5.5 C4.84,6,4.29,6.42,4.08,7.01L2,13v8c0,0.55,0.45,1,1,1h1c0.55,0,1-0.45,1-1v-1h12v1c0,0.55,0.45,1,1,1h1c0.55,0,1-0.45,1-1v-8 l-0.09-0.27C19.3,12.9,18.66,13,18,13V18z");
		builder.CloseElement();
		builder.OpenElement(34, "g");
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M18,1c-2.76,0-5,2.24-5,5s2.24,5,5,5s5-2.24,5-5S20.76,1,18,1z M18.5,3v4h-1V3H18.5z M18.5,9h-1V8h1V9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
