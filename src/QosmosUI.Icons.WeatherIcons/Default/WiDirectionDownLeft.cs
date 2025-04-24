// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiDirectionDownLeft : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.83,16.77c0,0.19,0.06,0.35,0.19,0.48c0.13,0.13,0.29,0.19,0.47,0.19h2.87c0.19,0,0.35-0.06,0.47-0.19	c0.13-0.13,0.19-0.29,0.19-0.48c0-0.19-0.06-0.34-0.19-0.46c-0.13-0.12-0.29-0.18-0.47-0.18h-1.24L18,12.24	c0.12-0.14,0.18-0.3,0.18-0.5c0-0.18-0.06-0.33-0.18-0.46c-0.12-0.12-0.29-0.18-0.5-0.18c-0.2,0-0.36,0.06-0.48,0.18l-3.86,3.87	v-1.25c0-0.19-0.06-0.35-0.19-0.48c-0.13-0.13-0.29-0.19-0.48-0.19c-0.19,0-0.35,0.07-0.47,0.2c-0.13,0.13-0.19,0.29-0.19,0.48	V16.77z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
