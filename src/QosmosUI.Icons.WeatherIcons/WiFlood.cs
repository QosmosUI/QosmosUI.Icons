// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons;

public class WiFlood : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 30 30";

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
		builder.AddAttribute(14, "d", "M6.72,20.76c0-0.05,0.01-0.12,0.02-0.21v-4.76c0.28,0.49,0.66,0.89,1.15,1.19c0.49,0.3,1.03,0.45,1.61,0.45	c0.59,0,1.13-0.15,1.62-0.45c0.49-0.3,0.87-0.69,1.15-1.19c0.27,0.49,0.66,0.89,1.15,1.19c0.49,0.3,1.03,0.45,1.62,0.45	c0.58,0,1.12-0.15,1.61-0.45c0.49-0.3,0.87-0.69,1.15-1.19c0.28,0.49,0.67,0.89,1.15,1.19c0.49,0.3,1.02,0.45,1.6,0.45	c0.58,0,1.12-0.15,1.61-0.45c0.49-0.3,0.88-0.69,1.15-1.19v4.81c0,0.02,0,0.05,0,0.08c0,0.03,0,0.06,0,0.08c0,0.01,0,0.04,0,0.07	s0,0.06,0,0.08c-0.03,0.23-0.13,0.43-0.3,0.6c-0.17,0.17-0.37,0.27-0.6,0.3c-0.02,0-0.05,0-0.08,0.01	c-0.03,0.01-0.06,0.01-0.08,0.01c-0.01,0-0.04,0-0.07-0.01c-0.03-0.01-0.06-0.01-0.08-0.01H7.94c-0.02,0-0.04,0-0.08,0.01	c-0.03,0.01-0.06,0.01-0.07,0.01c-0.02,0-0.05,0-0.08-0.01c-0.03-0.01-0.06-0.01-0.07-0.01c-0.22-0.03-0.42-0.12-0.58-0.28	c-0.16-0.16-0.27-0.34-0.32-0.56C6.73,20.88,6.72,20.81,6.72,20.76z M12.23,9.67c0-0.16,0.06-0.3,0.17-0.42l2.21-2.22l0.03-0.02	c0.01,0,0.01,0,0.01-0.01c0.01,0,0.01,0,0.01-0.01c0.01,0,0.01,0,0.01-0.01h0.01c0.01,0,0.01,0,0.01-0.01s0-0.01,0.01-0.02h0.02	l0.01-0.01h0.01l0.01-0.01h0.01l0.01-0.01h0.01c0.01-0.01,0.01-0.01,0.02-0.01h0.01c0-0.01,0.01-0.01,0.02-0.01	c0.01-0.01,0.01-0.01,0.02-0.01l0.04-0.02h0.01c0.01,0,0.01,0,0.01-0.01h0.07l0.01-0.01h0.12c0.01,0,0.01,0,0.02,0.01h0.06	c0,0.01,0,0.01,0.01,0.01h0.02c0.01,0.01,0.02,0.02,0.03,0.02l0.02,0.01h0.02l0.01,0.01h0.01l0.01,0.01c0.01,0,0.01,0,0.01,0.01	h0.02c0.01,0,0.01,0,0.01,0c0,0,0,0,0.01,0c0.01,0.01,0.01,0.01,0.02,0.01c0,0.01,0,0.02,0.01,0.02l0.01,0.01h0.02l0.01,0.01	L15.41,7l0.01,0.01l0.02,0.02l2.22,2.22c0.12,0.12,0.18,0.26,0.18,0.42c0,0.16-0.06,0.3-0.18,0.41c-0.11,0.12-0.25,0.18-0.41,0.18	c-0.16,0-0.3-0.06-0.41-0.18l-1.23-1.22v6.9c0,0.16-0.06,0.29-0.17,0.4c-0.11,0.11-0.25,0.17-0.41,0.17c-0.16,0-0.3-0.06-0.42-0.17	c-0.12-0.11-0.17-0.25-0.17-0.4v-6.9l-1.22,1.22c-0.12,0.12-0.26,0.18-0.42,0.18c-0.16,0-0.3-0.06-0.41-0.18	C12.29,9.97,12.23,9.83,12.23,9.67z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
