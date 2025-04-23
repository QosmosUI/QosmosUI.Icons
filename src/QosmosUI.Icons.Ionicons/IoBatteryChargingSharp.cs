// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoBatteryChargingSharp : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M306.68,237.62h-66.5l15.33-54.7L261.94,160,265.88,146l4.29-15.33h0a3.56,3.56,0,0,0,.06-.44c0-.06,0-.12,0-.19a1.85,1.85,0,0,0,0-.23,2,2,0,0,0,0-.24l0-.14c0-.1-.07-.19-.11-.29l0-.05a2.33,2.33,0,0,0-2-1.35h-.1a2.25,2.25,0,0,0-1.8,1h0l-12.5,17.15L234.9,171.44l-8.36,11.48-35.41,48.6L160,274.26h66.44l-30,107a3.93,3.93,0,0,0-.06.48s0,.06,0,.1a1.94,1.94,0,0,0,0,.34.29.29,0,0,0,0,.09,3,3,0,0,0,.07.32l0,.06a1.83,1.83,0,0,0,.14.32v0a2.38,2.38,0,0,0,1.52,1.16l.11,0,.33,0h.13a2.1,2.1,0,0,0,1.31-.5l.06-.05a2.6,2.6,0,0,0,.42-.45h0L223.3,352l13-17.82Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M289.78,134.55l-.14.74-.21.73-6.72,24H417V352H248.05l-23.33,32H449V128H290.13A22.62,22.62,0,0,1,289.78,134.55Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M49,160H218.49l23.31-32H17V384H176.49a22.73,22.73,0,0,1,.34-6.67l.15-.75.2-.73L183.87,352H49Z");
		builder.CloseElement();
		builder.OpenElement(19, "polygon");
		builder.AddAttribute(20, "points", "264.76 329.08 395.31 329.08 395.31 182.92 276.28 182.92 266.55 217.62 306.68 217.62 346 217.62 322.84 249.4 264.76 329.08");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "160 294.26 120.69 294.26 143.84 262.48 201.79 182.92 70.69 182.92 70.69 329.08 190.29 329.08 200.06 294.26 160 294.26");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "465");
		builder.AddAttribute(25, "y", "202.67");
		builder.AddAttribute(26, "width", "32");
		builder.AddAttribute(27, "height", "106.67");
		builder.CloseElement();
		builder.CloseElement();
    }
}
