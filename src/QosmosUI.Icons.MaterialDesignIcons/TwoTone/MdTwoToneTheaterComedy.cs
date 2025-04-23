// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneTheaterComedy : ComponentBase
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
		builder.AddAttribute(21, "d", "M14.5,10.81C14.55,9.8,15.64,9,16.99,9c1.38,0,2.5,0.84,2.5,1.88H14.5v1.22c0.69,0.55,1.55,0.9,2.5,0.9 c2.21,0,4-1.79,4-4V4h-8v3.5h1.5V10.81z M19,5.5c0.55,0,1,0.45,1,1s-0.45,1-1,1s-1-0.45-1-1S18.45,5.5,19,5.5z M14,6.5 c0-0.55,0.45-1,1-1s1,0.45,1,1s-0.45,1-1,1S14,7.05,14,6.5z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M11,2v5.5h2V4h8v5c0,2.21-1.79,4-4,4c-0.95,0-1.81-0.35-2.5-0.9v2.35C15.26,14.8,16.11,15,17,15c3.31,0,6-2.69,6-6V2H11z");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "19");
		builder.AddAttribute(27, "cy", "6.5");
		builder.AddAttribute(28, "r", "1");
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "cx", "15");
		builder.AddAttribute(31, "cy", "6.5");
		builder.AddAttribute(32, "r", "1");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M16.99,9c-1.35,0-2.44,0.8-2.49,1.81v0.07h4.99C19.49,9.84,18.37,9,16.99,9z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M1,16c0,3.31,2.69,6,6,6s6-2.69,6-6V9H1V16z M3,11h8v5c0,2.21-1.79,4-4,4s-4-1.79-4-4V11z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M7,20c2.21,0,4-1.79,4-4v-5H3v5C3,18.21,4.79,20,7,20z M7,17.88c-1.38,0-2.5-0.84-2.5-1.88h5 C9.5,17.04,8.38,17.88,7,17.88z M9,12.5c0.55,0,1,0.45,1,1s-0.45,1-1,1s-1-0.45-1-1S8.45,12.5,9,12.5z M5,12.5c0.55,0,1,0.45,1,1 s-0.45,1-1,1s-1-0.45-1-1S4.45,12.5,5,12.5z");
		builder.AddAttribute(39, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "5");
		builder.AddAttribute(42, "cy", "13.5");
		builder.AddAttribute(43, "r", "1");
		builder.CloseElement();
		builder.OpenElement(44, "circle");
		builder.AddAttribute(45, "cx", "9");
		builder.AddAttribute(46, "cy", "13.5");
		builder.AddAttribute(47, "r", "1");
		builder.CloseElement();
		builder.OpenElement(48, "path");
		builder.AddAttribute(49, "d", "M7,17.88c1.38,0,2.5-0.84,2.5-1.88h-5C4.5,17.04,5.62,17.88,7,17.88z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
