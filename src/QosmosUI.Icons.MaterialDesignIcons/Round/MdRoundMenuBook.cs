// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMenuBook : ComponentBase
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
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M17.5,4.5c-1.95,0-4.05,0.4-5.5,1.5c-1.45-1.1-3.55-1.5-5.5-1.5c-1.45,0-2.99,0.22-4.28,0.79C1.49,5.62,1,6.33,1,7.14 l0,11.28c0,1.3,1.22,2.26,2.48,1.94C4.46,20.11,5.5,20,6.5,20c1.56,0,3.22,0.26,4.56,0.92c0.6,0.3,1.28,0.3,1.87,0 c1.34-0.67,3-0.92,4.56-0.92c1,0,2.04,0.11,3.02,0.36c1.26,0.33,2.48-0.63,2.48-1.94l0-11.28c0-0.81-0.49-1.52-1.22-1.85 C20.49,4.72,18.95,4.5,17.5,4.5z M21,17.23c0,0.63-0.58,1.09-1.2,0.98c-0.75-0.14-1.53-0.2-2.3-0.2c-1.7,0-4.15,0.65-5.5,1.5V8 c1.35-0.85,3.8-1.5,5.5-1.5c0.92,0,1.83,0.09,2.7,0.28c0.46,0.1,0.8,0.51,0.8,0.98V17.23z");
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M13.98,11.01c-0.32,0-0.61-0.2-0.71-0.52c-0.13-0.39,0.09-0.82,0.48-0.94c1.54-0.5,3.53-0.66,5.36-0.45 c0.41,0.05,0.71,0.42,0.66,0.83c-0.05,0.41-0.42,0.71-0.83,0.66c-1.62-0.19-3.39-0.04-4.73,0.39 C14.13,10.99,14.05,11.01,13.98,11.01z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M13.98,13.67c-0.32,0-0.61-0.2-0.71-0.52c-0.13-0.39,0.09-0.82,0.48-0.94c1.53-0.5,3.53-0.66,5.36-0.45 c0.41,0.05,0.71,0.42,0.66,0.83c-0.05,0.41-0.42,0.71-0.83,0.66c-1.62-0.19-3.39-0.04-4.73,0.39 C14.13,13.66,14.05,13.67,13.98,13.67z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M13.98,16.33c-0.32,0-0.61-0.2-0.71-0.52c-0.13-0.39,0.09-0.82,0.48-0.94c1.53-0.5,3.53-0.66,5.36-0.45 c0.41,0.05,0.71,0.42,0.66,0.83c-0.05,0.41-0.42,0.7-0.83,0.66c-1.62-0.19-3.39-0.04-4.73,0.39 C14.13,16.32,14.05,16.33,13.98,16.33z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
