// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons;

public class WiRaindrops : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.01,12.23c0-0.26,0.13-0.59,0.38-1.01c0.25-0.42,0.5-0.77,0.73-1.04c0.06-0.07,0.14-0.17,0.23-0.28s0.15-0.17,0.16-0.18	l0.37,0.43c0.28,0.31,0.53,0.66,0.76,1.07c0.23,0.41,0.35,0.74,0.35,1.01c0,0.41-0.14,0.77-0.43,1.06	c-0.28,0.29-0.63,0.44-1.05,0.44c-0.41,0-0.77-0.15-1.06-0.44C11.16,12.99,11.01,12.64,11.01,12.23z M14.13,16.38	c0-0.29,0.08-0.62,0.24-1.01c0.16-0.38,0.36-0.74,0.6-1.06c0.46-0.61,0.89-1.12,1.31-1.53c0.04-0.03,0.13-0.11,0.26-0.24l0.25,0.24	c0.39,0.37,0.83,0.88,1.32,1.52c0.26,0.34,0.46,0.7,0.62,1.08s0.24,0.71,0.24,1c0,0.69-0.23,1.26-0.7,1.73	c-0.47,0.47-1.05,0.7-1.73,0.7c-0.68,0-1.25-0.24-1.72-0.71S14.13,17.05,14.13,16.38z M15.65,9.48c0-0.43,0.33-1,1-1.7l0.25,0.28	c0.19,0.22,0.36,0.46,0.51,0.74c0.15,0.27,0.23,0.5,0.23,0.68c0,0.28-0.1,0.5-0.29,0.69c-0.19,0.18-0.42,0.28-0.7,0.28	c-0.29,0-0.53-0.09-0.72-0.28C15.75,9.98,15.65,9.75,15.65,9.48z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
