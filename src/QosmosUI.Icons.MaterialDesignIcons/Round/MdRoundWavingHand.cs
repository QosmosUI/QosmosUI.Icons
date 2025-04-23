// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWavingHand : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M6.07,9.8c-0.2,0.2-0.2,0.51,0,0.71l0,0c1.07,1.07,1.16,2.75,0.28,3.92c-0.15,0.2-0.12,0.47,0.05,0.65 c0.22,0.22,0.57,0.19,0.76-0.05c1.07-1.43,1.06-3.43-0.04-4.85l7.62-7.62c0.49-0.49,1.28-0.49,1.77,0s0.49,1.28,0,1.77l-5.13,5.13 c-0.2,0.2-0.2,0.51,0,0.71s0.51,0.2,0.71,0l6.54-6.54c0.49-0.49,1.28-0.49,1.77,0s0.49,1.28,0,1.77l-6.54,6.54 c-0.2,0.2-0.2,0.51,0,0.71s0.51,0.2,0.71,0l5.48-5.48c0.49-0.49,1.28-0.49,1.77,0s0.49,1.28,0,1.77l-6.19,6.19 c-0.2,0.2-0.2,0.51,0,0.71c0.2,0.2,0.51,0.2,0.71,0l4.07-4.07c0.49-0.49,1.28-0.49,1.77,0c0.49,0.49,0.49,1.28,0,1.77l-7.07,7.07 c-3.22,3.22-8.45,3.22-11.67,0s-3.22-8.45,0-11.67l4.6-4.6c0.49-0.49,1.28-0.49,1.77,0c0.49,0.49,0.49,1.28,0,1.77L6.07,9.8z M7,1.8 c0-0.41-0.34-0.75-0.75-0.75c-0.04,0-0.07,0-0.11,0.01c-2.63,0.38-4.7,2.46-5.08,5.08c0,0.03-0.01,0.07-0.01,0.11 C1.05,6.66,1.39,7,1.8,7c0.38,0,0.69-0.28,0.74-0.64c0.28-1.97,1.84-3.53,3.81-3.81C6.72,2.49,7,2.18,7,1.8z M17,22.2 c0,0.41,0.34,0.75,0.75,0.75c0.04,0,0.07,0,0.11-0.01c2.63-0.38,4.7-2.46,5.08-5.08c0-0.03,0.01-0.07,0.01-0.11 c0-0.41-0.34-0.75-0.75-0.75c-0.38,0-0.69,0.28-0.74,0.64c-0.28,1.97-1.84,3.53-3.81,3.81C17.28,21.51,17,21.82,17,22.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
