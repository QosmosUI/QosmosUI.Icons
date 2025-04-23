// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundContactEmergency : ComponentBase
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
		builder.AddAttribute(24, "d", "M22,3H2C0.9,3,0,3.9,0,5v14c0,1.1,0.9,2,2,2h20c1.1,0,1.99-0.9,1.99-2L24,5C24,3.9,23.1,3,22,3z M9,8c1.65,0,3,1.35,3,3 s-1.35,3-3,3s-3-1.35-3-3S7.35,8,9,8z M2.08,19c1.38-2.39,3.96-4,6.92-4s5.54,1.61,6.92,4H2.08z M20.6,10.5L20.6,10.5 c-0.21,0.36-0.67,0.48-1.02,0.27l-0.82-0.48v0.95c0,0.41-0.34,0.75-0.75,0.75h0c-0.41,0-0.75-0.34-0.75-0.75V10.3l-0.82,0.48 c-0.36,0.21-0.82,0.08-1.02-0.27l0,0c-0.21-0.36-0.08-0.82,0.27-1.02L16.5,9l-0.82-0.48c-0.36-0.21-0.48-0.67-0.27-1.02l0,0 c0.21-0.36,0.67-0.48,1.02-0.27l0.82,0.48V6.75C17.25,6.34,17.59,6,18,6h0c0.41,0,0.75,0.34,0.75,0.75V7.7l0.82-0.48 c0.36-0.21,0.82-0.08,1.02,0.27v0c0.21,0.36,0.08,0.82-0.27,1.02L19.5,9l0.82,0.48C20.68,9.68,20.81,10.14,20.6,10.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
