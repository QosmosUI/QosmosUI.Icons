// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDoNotStep : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M2.1,3.51c-0.39,0.39-0.39,1.02,0,1.41l7.19,7.19c0.18,0.2,0.18,0.5-0.01,0.7c-0.1,0.1-0.23,0.15-0.35,0.15 s-0.26-0.05-0.35-0.15L6.87,11.1c-0.11,0.4-0.26,0.78-0.45,1.12l1.4,1.4c0.2,0.2,0.2,0.51,0,0.71c-0.1,0.1-0.23,0.15-0.35,0.15 s-0.26-0.05-0.35-0.15l-1.27-1.27c-0.24,0.29-0.5,0.56-0.77,0.8l1.28,1.28c0.2,0.2,0.2,0.51,0,0.71C6.26,15.95,6.13,16,6,16 s-0.26-0.05-0.35-0.15l-1.38-1.38c-0.71,0.47-1.43,0.81-2.02,1.04C1.49,15.81,1,16.55,1,17.37L1,18c0,1.1,0.9,2,2,2h6.67 c0.53,0,1.04-0.21,1.41-0.59l2.74-2.74l5.23,5.23c0.39,0.39,1.02,0.39,1.41,0l0,0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51 C3.12,3.12,2.49,3.12,2.1,3.51L2.1,3.51z M18.51,15.68l-1.41-1.41l4.48-4.48l0,0c0.78,0.78,0.78,2.05,0,2.83L18.51,15.68z M20.88,9.08l-4.48,4.48L9.3,6.47l3.09-3.07c0.78-0.78,2.04-0.77,2.82,0L20.88,9.08z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
