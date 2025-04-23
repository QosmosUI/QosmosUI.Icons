// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons;

public class WiEarthquake : ComponentBase
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
		builder.AddAttribute(14, "d", "M5.25,15.3c0,0.16,0.06,0.29,0.17,0.4c0.11,0.11,0.25,0.16,0.4,0.16H8.8c0.14,0,0.27-0.04,0.38-0.13	c0.11-0.09,0.17-0.2,0.2-0.34l0.9-5.27l1.62,13.18c0.02,0.14,0.09,0.26,0.19,0.36c0.1,0.09,0.22,0.14,0.36,0.14	c0.15,0,0.28-0.05,0.38-0.14s0.17-0.21,0.2-0.36l1.25-9.67l1.04,2.8c0.04,0.11,0.1,0.2,0.2,0.27s0.2,0.1,0.32,0.1h0.05	c0.12-0.01,0.23-0.05,0.32-0.13c0.1-0.08,0.16-0.18,0.19-0.31l1.53-6.86l0.71,13.18c0.01,0.14,0.06,0.27,0.15,0.37	c0.09,0.1,0.21,0.16,0.36,0.17c0.14,0.01,0.27-0.02,0.38-0.1c0.11-0.08,0.18-0.19,0.22-0.33l1.65-6.94h2.77	c0.16,0,0.29-0.05,0.4-0.16c0.11-0.11,0.17-0.24,0.17-0.4c0-0.16-0.06-0.29-0.17-0.4c-0.11-0.11-0.25-0.17-0.4-0.17h-3.23	c-0.13,0-0.25,0.04-0.35,0.12s-0.17,0.18-0.2,0.31l-0.83,3.54L18.84,5.33c-0.01-0.14-0.06-0.27-0.16-0.37	c-0.1-0.1-0.22-0.16-0.36-0.16c-0.14-0.01-0.27,0.02-0.39,0.11s-0.19,0.2-0.22,0.34l-2,8.97l-1.16-3.16	c-0.04-0.12-0.12-0.21-0.24-0.28s-0.24-0.1-0.36-0.08c-0.13,0.01-0.24,0.07-0.33,0.16c-0.09,0.09-0.15,0.21-0.17,0.34l-0.98,7.51	L10.94,6.15c-0.03-0.14-0.09-0.26-0.19-0.35c-0.1-0.09-0.22-0.14-0.36-0.15c-0.14-0.01-0.27,0.03-0.38,0.12	c-0.11,0.09-0.18,0.2-0.2,0.35l-1.48,8.61H5.82c-0.16,0-0.29,0.06-0.4,0.17C5.31,15.01,5.25,15.14,5.25,15.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
