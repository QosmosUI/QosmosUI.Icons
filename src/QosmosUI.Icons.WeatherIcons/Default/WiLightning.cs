// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiLightning : ComponentBase
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
		builder.AddAttribute(14, "d", "M7.96,24.51h0.39l6.88-10.18c0.09-0.18,0.04-0.27-0.15-0.27h-2.84l2.99-5.45c0.09-0.18,0.02-0.27-0.2-0.27h-3.81	c-0.11,0-0.2,0.06-0.29,0.18l-2.78,7.4c-0.02,0.18,0.04,0.27,0.19,0.27h2.75L7.96,24.51z M16.46,18.18h0.27l5.22-7.67	c0.05-0.08,0.06-0.15,0.04-0.2s-0.08-0.07-0.17-0.07h-2.1l2.18-4.03c0.12-0.2,0.06-0.3-0.18-0.3h-2.74c-0.13,0-0.23,0.06-0.3,0.19	l-2.08,5.48c-0.03,0.09-0.03,0.16,0.01,0.21c0.04,0.05,0.1,0.07,0.19,0.07h2.04L16.46,18.18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
