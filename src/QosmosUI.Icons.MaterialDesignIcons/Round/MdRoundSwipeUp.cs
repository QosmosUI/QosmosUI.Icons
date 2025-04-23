// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSwipeUp : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M8.83,19.1c-0.26-0.6,0.09-1.28,0.73-1.41l3.58-0.71L8.79,7.17c-0.34-0.76,0-1.64,0.76-1.98c0.76-0.34,1.64,0,1.98,0.76 l2.43,5.49l0.84-0.37c0.28-0.13,0.59-0.18,0.9-0.17l4.56,0.21c0.86,0.04,1.6,0.63,1.83,1.45l1.23,4.33 c0.27,0.96-0.2,1.97-1.11,2.37l-5.63,2.49c-0.48,0.21-1.26,0.33-1.76,0.14l-5.45-2.27C9.13,19.53,8.93,19.34,8.83,19.1z M6.75,13.38c0.26-0.26,0.29-0.66,0.09-0.95C5.68,10.74,5,8.7,5,6.5c0-0.88,0.11-1.74,0.32-2.56l1.09,1.09 c0.3,0.3,0.79,0.29,1.08-0.02c0.28-0.3,0.25-0.78-0.04-1.07L5.21,1.71c-0.39-0.39-1.02-0.39-1.41,0L1.53,3.97 c-0.3,0.3-0.29,0.79,0.02,1.08c0.3,0.28,0.78,0.25,1.07-0.04L3.8,3.82C3.6,4.68,3.5,5.58,3.5,6.5c0,2.51,0.77,4.85,2.09,6.77 C5.86,13.66,6.41,13.72,6.75,13.38z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
