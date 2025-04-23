// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneMosque : ComponentBase
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
		builder.AddAttribute(21, "d", "M9.91,9h4.18C15.14,9,16,8.14,16,7.09c0-0.64-0.32-1.23-0.85-1.59L12,3.4L8.85,5.5C8.32,5.86,8,6.45,8,7.09 C8,8.14,8.86,9,9.91,9z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M17,11H7v4H3v4h6v-2c0-1.65,1.35-3,3-3c1.65,0,3,1.35,3,3v2h6v-4h-4V11z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M22,4c0,0-2,1.9-2,3c0,0.74,0.4,1.38,1,1.72V13h-2v-2c0-0.95-0.66-1.74-1.55-1.94C17.79,8.48,18,7.81,18,7.09 c0-1.31-0.65-2.53-1.74-3.25L12,1L7.74,3.84C6.65,4.56,6,5.78,6,7.09c0,0.72,0.21,1.39,0.55,1.96C5.66,9.26,5,10.05,5,11v2H3V8.72 C3.6,8.38,4,7.74,4,7c0-1.1-2-3-2-3S0,5.9,0,7c0,0.74,0.4,1.38,1,1.72V21h10v-4c0-0.55,0.45-1,1-1s1,0.45,1,1v4h10V8.72 c0.6-0.35,1-0.98,1-1.72C24,5.9,22,4,22,4z M8.85,5.5L12,3.4l3.15,2.1C15.68,5.86,16,6.45,16,7.09C16,8.14,15.14,9,14.09,9H9.91 C8.86,9,8,8.14,8,7.09C8,6.45,8.32,5.86,8.85,5.5z M21,19h-6v-2c0-1.65-1.35-3-3-3c-1.65,0-3,1.35-3,3v2H3v-4h4v-4h10v4h4V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
