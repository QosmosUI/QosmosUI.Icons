// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneHandyman : ComponentBase
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
		builder.OpenElement(22, "polygon");
		builder.AddAttribute(23, "points", "8.66,14.64 4.41,18.88 5.12,19.59 9.36,15.34 9.36,15.34 8.66,14.64");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.AddAttribute(25, "opacity", ".3");
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "6");
		builder.AddAttribute(28, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -7.0983 17.0848)");
		builder.AddAttribute(29, "width", "1");
		builder.AddAttribute(30, "x", "16.57");
		builder.AddAttribute(31, "y", "14.11");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M21.67,18.17l-5.3-5.3h-0.99l-2.54,2.54v0.99l5.3,5.3c0.39,0.39,1.02,0.39,1.41,0l2.12-2.12 C22.06,19.2,22.06,18.56,21.67,18.17z M18.84,19.59l-4.24-4.24l0.71-0.71l4.24,4.24L18.84,19.59z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(35, "g");
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M17.34,10.19l1.41-1.41l2.12,2.12c1.17-1.17,1.17-3.07,0-4.24l-3.54-3.54l-1.41,1.41V1.71L15.22,1l-3.54,3.54l0.71,0.71 h2.83l-1.41,1.41l1.06,1.06l-2.89,2.89L7.85,6.48V5.06L4.83,2.04L2,4.87l3.03,3.03h1.41l4.13,4.13l-0.85,0.85H7.6l-5.3,5.3 c-0.39,0.39-0.39,1.02,0,1.41l2.12,2.12c0.39,0.39,1.02,0.39,1.41,0l5.3-5.3v-2.12l5.15-5.15L17.34,10.19z M9.36,15.34 l-4.24,4.24l-0.71-0.71l4.24-4.24l0,0L9.36,15.34L9.36,15.34z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
