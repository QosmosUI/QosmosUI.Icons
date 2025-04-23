// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSelfImprovement : ComponentBase
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
		builder.AddAttribute(25, "cx", "12");
		builder.AddAttribute(26, "cy", "6");
		builder.AddAttribute(27, "r", "2");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M21,14.94L21,14.94c0-0.5-0.36-0.93-0.85-0.98c-1.88-0.21-3.49-1.13-4.75-2.63l-1.34-1.6C13.68,9.26,13.12,9,12.53,9 h-1.05c-0.59,0-1.15,0.26-1.53,0.72l-1.34,1.6c-1.25,1.5-2.87,2.42-4.75,2.63C3.36,14.01,3,14.44,3,14.94v0 c0,0.6,0.53,1.07,1.13,1c2.3-0.27,4.32-1.39,5.87-3.19V15l-3.76,1.5c-0.65,0.26-1.16,0.83-1.23,1.53C4.91,19.1,5.74,20,6.79,20H9 v-0.5c0-1.38,1.12-2.5,2.5-2.5h3c0.28,0,0.5,0.22,0.5,0.5S14.78,18,14.5,18h-3c-0.83,0-1.5,0.67-1.5,1.5V20l7.1,0 c0.85,0,1.65-0.54,1.85-1.37c0.21-0.89-0.27-1.76-1.08-2.08L14,15v-2.25c1.56,1.8,3.57,2.91,5.87,3.19C20.47,16,21,15.54,21,14.94 z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
