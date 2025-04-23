// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundEmojiSymbols : ComponentBase
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
		builder.AddAttribute(26, "d", "M10,5H4C3.45,5,3,5.45,3,6c0,0.55,0.45,1,1,1h2v3c0,0.55,0.45,1,1,1s1-0.45,1-1V7h2c0.55,0,1-0.45,1-1 C11,5.45,10.55,5,10,5z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M10,2H4C3.45,2,3,2.45,3,3s0.45,1,1,1h6c0.55,0,1-0.45,1-1S10.55,2,10,2z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M20.89,13.11c-0.39-0.39-1.02-0.39-1.41,0l-6.36,6.36c-0.39,0.39-0.39,1.02,0,1.41c0.39,0.39,1.02,0.39,1.41,0l6.36-6.36 C21.28,14.13,21.28,13.5,20.89,13.11z");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "14.5");
		builder.AddAttribute(33, "cy", "14.5");
		builder.AddAttribute(34, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "19.5");
		builder.AddAttribute(37, "cy", "19.5");
		builder.AddAttribute(38, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M15.5,11c1.38,0,2.5-1.12,2.5-2.5V4h2c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1h-2c-0.55,0-1,0.45-1,1v3.51 C16.58,6.19,16.07,6,15.5,6C14.12,6,13,7.12,13,8.5C13,9.88,14.12,11,15.5,11z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M10.45,18.09c0.39-0.39,0.39-1.02,0-1.41c-0.39-0.39-1.02-0.39-1.41,0l-0.71,0.71l-0.71-0.71l0.35-0.35 c0.98-0.98,0.98-2.56,0-3.54h0c-0.49-0.49-1.13-0.73-1.77-0.73c-0.64,0-1.28,0.24-1.77,0.73c-0.98,0.98-0.98,2.56,0,3.54 l0.35,0.35l-1.06,1.06c-0.98,0.98-0.98,2.56,0,3.54C4.22,21.76,4.86,22,5.5,22c0.64,0,1.28-0.24,1.77-0.73l1.06-1.06l0.71,0.71 c0.39,0.39,1.02,0.39,1.41,0c0.39-0.39,0.39-1.02,0-1.41l-0.71-0.71v0L10.45,18.09z M5.85,14.2c0.12-0.12,0.26-0.15,0.35-0.15 s0.23,0.03,0.35,0.15c0.19,0.2,0.19,0.51,0,0.71l-0.35,0.35L5.85,14.9c-0.12-0.12-0.15-0.26-0.15-0.35S5.73,14.32,5.85,14.2z M5.85,19.85C5.73,19.97,5.59,20,5.5,20s-0.23-0.03-0.35-0.15C5.03,19.73,5,19.59,5,19.5s0.03-0.23,0.15-0.35l1.06-1.06l0.71,0.71 L5.85,19.85z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
