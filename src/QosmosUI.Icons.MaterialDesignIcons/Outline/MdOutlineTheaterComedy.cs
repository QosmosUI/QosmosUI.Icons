// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineTheaterComedy : ComponentBase
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
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "19");
		builder.AddAttribute(22, "cy", "6.5");
		builder.AddAttribute(23, "r", "1");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "15");
		builder.AddAttribute(26, "cy", "6.5");
		builder.AddAttribute(27, "r", "1");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M16.99,9c-1.38,0-2.5,0.84-2.5,1.88h5C19.49,9.84,18.37,9,16.99,9z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M1,16c0,3.31,2.69,6,6,6s6-2.69,6-6V9H1V16z M3,11h8v5c0,2.21-1.79,4-4,4s-4-1.79-4-4V11z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M11,2v5.5h2V4h8v5c0,2.21-1.79,4-4,4c-0.95,0-1.81-0.35-2.5-0.9v2.35C15.26,14.8,16.11,15,17,15c3.31,0,6-2.69,6-6V2H11z");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "5");
		builder.AddAttribute(36, "cy", "13.5");
		builder.AddAttribute(37, "r", "1");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "9");
		builder.AddAttribute(40, "cy", "13.5");
		builder.AddAttribute(41, "r", "1");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M7,17.88c1.38,0,2.5-0.84,2.5-1.88h-5C4.5,17.04,5.62,17.88,7,17.88z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
