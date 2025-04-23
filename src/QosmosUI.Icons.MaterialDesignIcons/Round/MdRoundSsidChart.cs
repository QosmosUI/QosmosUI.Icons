// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSsidChart : ComponentBase
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
		builder.AddAttribute(20, "d", "M3,9.03c0-0.32,0.15-0.62,0.41-0.81L7.14,5.5c0.4-0.29,0.95-0.25,1.3,0.1l3.78,3.78l7.2-5.23C20.07,3.67,21,4.14,21,4.96 c0,0.32-0.15,0.62-0.41,0.81l-7.9,5.73c-0.4,0.29-0.95,0.25-1.29-0.1L7.62,7.62L4.59,9.84C3.93,10.32,3,9.85,3,9.03z M21,16 c0-0.55-0.45-1-1-1h-3.35c-0.23,0-0.45,0.08-0.62,0.22l-3.9,3.12L6.6,12.99c-0.35-0.34-0.88-0.38-1.27-0.1l-1.9,1.35 C3.16,14.43,3,14.74,3,15.06c0,0.81,0.92,1.29,1.58,0.81L5.8,15l5.57,5.39c0.36,0.35,0.93,0.38,1.32,0.06L17,17h3 C20.55,17,21,16.55,21,16z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
