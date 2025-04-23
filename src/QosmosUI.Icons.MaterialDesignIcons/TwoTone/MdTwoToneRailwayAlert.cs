// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneRailwayAlert : ComponentBase
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
		builder.AddAttribute(21, "opacity", ".3");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M4,16.5C4,17.33,4.67,18,5.5,18h9c0.83,0,1.5-0.67,1.5-1.5V13H4V16.5z M10,14c0.83,0,1.5,0.67,1.5,1.5S10.83,17,10,17 s-1.5-0.67-1.5-1.5S9.17,14,10,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.AddAttribute(25, "opacity", ".3");
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M4.43,6H11c0-0.33,0.03-0.66,0.08-0.98C7.71,4.92,5.33,5.23,4.43,6z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M4,11V8h7.29C11.1,7.37,11,6.7,11,6H4.43c0.9-0.77,3.28-1.08,6.65-0.98c0.1-0.7,0.3-1.37,0.59-1.99C2.97,2.67,2,5.02,2,7 v9.5C2,18.43,3.57,20,5.5,20L4,21v1h12v-1l-1.5-1c1.93,0,3.5-1.57,3.5-3.5V13c-1.91,0-3.63-0.76-4.89-2H4z M16,16.5 c0,0.83-0.67,1.5-1.5,1.5h-9C4.67,18,4,17.33,4,16.5V13h12V16.5z");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "10");
		builder.AddAttribute(32, "cy", "15.5");
		builder.AddAttribute(33, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(34, "g");
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M18,1c-2.76,0-5,2.24-5,5s2.24,5,5,5s5-2.24,5-5S20.76,1,18,1z M18.5,9h-1V8h1V9z M18.5,7h-1V3h1V7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
