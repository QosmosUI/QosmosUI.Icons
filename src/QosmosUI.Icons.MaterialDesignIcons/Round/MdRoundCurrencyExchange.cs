// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCurrencyExchange : ComponentBase
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
		builder.AddAttribute(20, "d", "M12,23c5.7,0,10.39-4.34,10.95-9.9c0.06-0.59-0.41-1.1-1-1.1c-0.51,0-0.94,0.38-0.99,0.88C20.52,17.44,16.67,21,12,21 c-3.12,0-5.87-1.59-7.48-4L6,17c0.55,0,1-0.45,1-1s-0.45-1-1-1H2c-0.55,0-1,0.45-1,1v4c0,0.55,0.45,1,1,1c0.55,0,1-0.45,1-1l0-1.67 C4.99,21.15,8.28,23,12,23z M12,1C6.3,1,1.61,5.34,1.05,10.9C1,11.49,1.46,12,2.05,12c0.51,0,0.94-0.38,0.99-0.88 C3.48,6.56,7.33,3,12,3c3.12,0,5.87,1.59,7.48,4L18,7c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1V4 c0-0.55-0.45-1-1-1s-1,0.45-1,1l0,1.67C19.01,2.85,15.72,1,12,1z M11.12,5.88C11.12,5.39,11.52,5,12,5s0.88,0.39,0.88,0.88l0,0.37 c1.07,0.19,1.75,0.76,2.16,1.3c0.34,0.44,0.16,1.08-0.36,1.3C14.32,9,13.9,8.88,13.66,8.57c-0.28-0.38-0.78-0.77-1.6-0.77 c-0.7,0-1.81,0.37-1.81,1.39c0,0.95,0.86,1.31,2.64,1.9c2.4,0.83,3.01,2.05,3.01,3.45c0,2.62-2.5,3.13-3.02,3.22l0,0.37 c0,0.48-0.39,0.88-0.88,0.88s-0.88-0.39-0.88-0.88l0-0.42c-0.63-0.15-1.93-0.61-2.69-2.1c-0.23-0.44,0.03-1.02,0.49-1.2 c0.41-0.16,0.9-0.01,1.11,0.38c0.32,0.61,0.95,1.37,2.12,1.37c0.93,0,1.98-0.48,1.98-1.61c0-0.96-0.7-1.46-2.28-2.03 c-1.1-0.39-3.35-1.03-3.35-3.31c0-0.1,0.01-2.4,2.62-2.96L11.12,5.88z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
