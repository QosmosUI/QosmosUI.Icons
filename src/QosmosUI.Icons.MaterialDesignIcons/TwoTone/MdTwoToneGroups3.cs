// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneGroups3 : ComponentBase
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
		builder.AddAttribute(21, "d", "M15.43,15.48c-1.1-0.49-2.26-0.73-3.43-0.73c-1.18,0-2.33,0.25-3.43,0.73c-0.23,0.1-0.4,0.29-0.49,0.52 h7.85C15.83,15.77,15.66,15.58,15.43,15.48z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "12");
		builder.AddAttribute(25, "cy", "9");
		builder.AddAttribute(26, "opacity", ".3");
		builder.AddAttribute(27, "r", "1");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M16.24,13.65c-1.17-0.52-2.61-0.9-4.24-0.9c-1.63,0-3.07,0.39-4.24,0.9C6.68,14.13,6,15.21,6,16.39V18h12v-1.61 C18,15.21,17.32,14.13,16.24,13.65z M8.07,16c0.09-0.23,0.27-0.42,0.49-0.52c1.1-0.49,2.26-0.73,3.43-0.73 c1.18,0,2.33,0.25,3.43,0.73c0.23,0.1,0.4,0.29,0.49,0.52H8.07z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M1.22,14.58C0.48,14.9,0,15.62,0,16.43V18l4.5,0v-1.61c0-0.83,0.23-1.61,0.63-2.29C4.76,14.04,4.39,14,4,14 C3.01,14,2.07,14.21,1.22,14.58z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M22.78,14.58C21.93,14.21,20.99,14,20,14c-0.39,0-0.76,0.04-1.13,0.1c0.4,0.68,0.63,1.46,0.63,2.29V18l4.5,0v-1.57 C24,15.62,23.52,14.9,22.78,14.58z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M12,12c1.66,0,3-1.34,3-3c0-1.66-1.34-3-3-3S9,7.34,9,9C9,10.66,10.34,12,12,12z M12,8c0.55,0,1,0.45,1,1s-0.45,1-1,1 s-1-0.45-1-1S11.45,8,12,8z");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "height", "3.54");
		builder.AddAttribute(38, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -6.6066 6.0503)");
		builder.AddAttribute(39, "width", "3.54");
		builder.AddAttribute(40, "x", "2.23");
		builder.AddAttribute(41, "y", "9.23");
		builder.CloseElement();
		builder.OpenElement(42, "polygon");
		builder.AddAttribute(43, "points", "20,9 17.5,13 22.5,13");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
