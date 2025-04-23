// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEmojiObjects : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "height", "1");
		builder.AddAttribute(23, "opacity", ".3");
		builder.AddAttribute(24, "width", "4");
		builder.AddAttribute(25, "x", "10");
		builder.AddAttribute(26, "y", "18");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "1");
		builder.AddAttribute(29, "opacity", ".3");
		builder.AddAttribute(30, "width", "4");
		builder.AddAttribute(31, "x", "10");
		builder.AddAttribute(32, "y", "16");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M12,3c-0.46,0-0.93,0.04-1.4,0.14C7.84,3.67,5.64,5.9,5.12,8.66c-0.48,2.61,0.48,5.01,2.22,6.56 C7.77,15.6,8,16.13,8,16.69V19c0,1.1,0.9,2,2,2h0.28c0.35,0.6,0.98,1,1.72,1s1.38-0.4,1.72-1H14c1.1,0,2-0.9,2-2v-2.31 c0-0.55,0.22-1.09,0.64-1.46C18.09,13.95,19,12.08,19,10C19,6.13,15.87,3,12,3z M14,19h-4v-1h4V19z M14,17h-4v-1h4V17z M15.31,13.74c-0.09,0.08-0.16,0.18-0.24,0.26H8.92c-0.08-0.09-0.15-0.19-0.24-0.27c-1.32-1.18-1.91-2.94-1.59-4.7 c0.36-1.94,1.96-3.55,3.89-3.93C11.32,5.03,11.66,5,12,5c2.76,0,5,2.24,5,5C17,11.43,16.39,12.79,15.31,13.74z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(35, "g");
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "height", "3");
		builder.AddAttribute(38, "width", "1");
		builder.AddAttribute(39, "x", "11.5");
		builder.AddAttribute(40, "y", "11");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "height", "3");
		builder.AddAttribute(43, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -4.0312 10.8536)");
		builder.AddAttribute(44, "width", "1");
		builder.AddAttribute(45, "x", "10.59");
		builder.AddAttribute(46, "y", "8.79");
		builder.CloseElement();
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "height", "3");
		builder.AddAttribute(49, "transform", "matrix(-0.7071 -0.7071 0.7071 -0.7071 14.7678 26.7028)");
		builder.AddAttribute(50, "width", "1");
		builder.AddAttribute(51, "x", "12.41");
		builder.AddAttribute(52, "y", "8.79");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
