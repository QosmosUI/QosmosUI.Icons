// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundEmojiTransportation : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M21.99,14.77l-1.43-4.11c-0.14-0.4-0.52-0.66-0.97-0.66H12.4c-0.46,0-0.83,0.26-0.98,0.66L10,14.77v5.24 c0,0.55,0.45,0.99,1,0.99s1-0.45,1-1v-1h8v1c0,0.55,0.45,1,1,1s0.99-0.44,1-0.99L21.99,14.77z M11.61,13.34l0.69-2 c0.05-0.2,0.24-0.34,0.46-0.34h6.48c0.21,0,0.4,0.14,0.47,0.34l0.69,2c0.11,0.32-0.13,0.66-0.47,0.66h-7.85 C11.74,14,11.5,13.66,11.61,13.34z M11.99,17c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S12.54,17,11.99,17z M19.99,17 c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S20.54,17,19.99,17z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M14,4.5V9h1V4c0-0.55-0.45-1-1-1H8C7.45,3,7,3.45,7,4v4H3C2.45,8,2,8.45,2,9v12h1V9.5C3,9.22,3.22,9,3.5,9h4 C7.78,9,8,8.78,8,8.5v-4C8,4.22,8.22,4,8.5,4h5C13.78,4,14,4.22,14,4.5z");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "2");
		builder.AddAttribute(31, "width", "2");
		builder.AddAttribute(32, "x", "5");
		builder.AddAttribute(33, "y", "11");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "height", "2");
		builder.AddAttribute(36, "width", "2");
		builder.AddAttribute(37, "x", "10");
		builder.AddAttribute(38, "y", "5");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "height", "2");
		builder.AddAttribute(41, "width", "2");
		builder.AddAttribute(42, "x", "5");
		builder.AddAttribute(43, "y", "15");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "height", "2");
		builder.AddAttribute(46, "width", "2");
		builder.AddAttribute(47, "x", "5");
		builder.AddAttribute(48, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
