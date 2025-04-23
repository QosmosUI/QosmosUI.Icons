// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAssistWalker : ComponentBase
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
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "12.5");
		builder.AddAttribute(26, "cy", "4.5");
		builder.AddAttribute(27, "r", "2");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M19.77,17.72l-0.64-6.37C19.06,10.58,18.41,10,17.64,10H16c-1.5-0.02-2.86-0.54-3.76-1.44l-2-1.98 C10.08,6.42,9.62,6,8.83,6C8.32,6,7.81,6.2,7.42,6.59L4.08,9.91c-0.53,0.68-0.51,1.57-0.21,2.13l1.43,2.8L2.75,18.1 c-0.34,0.43-0.26,1.06,0.17,1.4l0,0c0.44,0.34,1.07,0.26,1.41-0.17l2.56-3.29c0.33-0.42,0.47-0.95,0.41-1.48l-0.07-0.53L8,14.75 V19c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-4.29c0-0.53-0.21-1.04-0.59-1.41l-1.53-1.53l2.36-2.36c0.94,0.94,1.72,1.82,3.59,2.32 l-0.75,7.46c-0.04,0.44,0.3,0.83,0.75,0.83h0c0.38,0,0.7-0.29,0.75-0.66l0.33-2.84h3.18l0.14,1.22c-0.44,0.26-0.73,0.74-0.73,1.28 c0,0.83,0.67,1.5,1.5,1.5s1.5-0.67,1.5-1.5C20.5,18.46,20.21,17.98,19.77,17.72z M15.09,15l0.41-3.5h2l0.41,3.5H15.09z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
