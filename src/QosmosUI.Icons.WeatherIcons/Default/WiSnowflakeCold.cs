// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiSnowflakeCold : ComponentBase
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
		builder.AddAttribute(14, "d", "M7.46,14.41c0-0.19,0.07-0.36,0.2-0.5c0.13-0.14,0.29-0.21,0.48-0.21c0.19,0,0.36,0.07,0.49,0.21c0.13,0.14,0.2,0.3,0.2,0.5	c0,0.19-0.07,0.35-0.2,0.48c-0.13,0.13-0.3,0.2-0.48,0.2s-0.35-0.07-0.48-0.2C7.52,14.75,7.46,14.59,7.46,14.41z M9.44,14.41	c0-0.19,0.07-0.36,0.2-0.5c0.13-0.14,0.29-0.21,0.48-0.21h3.23l-2.28-2.28c-0.14-0.12-0.21-0.28-0.21-0.47	c0-0.19,0.07-0.35,0.21-0.49c0.14-0.14,0.3-0.21,0.49-0.21s0.35,0.07,0.49,0.21l2.27,2.27V9.52c0-0.19,0.07-0.36,0.21-0.5	s0.3-0.21,0.5-0.21c0.19,0,0.35,0.07,0.48,0.21c0.13,0.14,0.2,0.3,0.2,0.5v3.23l2.29-2.3c0.14-0.14,0.3-0.21,0.48-0.21	c0.18,0,0.35,0.07,0.49,0.21c0.12,0.14,0.18,0.3,0.18,0.49c0,0.19-0.06,0.35-0.18,0.47l-2.28,2.28h3.23c0.18,0,0.34,0.07,0.47,0.21	c0.13,0.14,0.2,0.3,0.2,0.5c0,0.18-0.07,0.34-0.2,0.47c-0.13,0.13-0.29,0.2-0.47,0.2h-3.23l2.29,2.29c0.12,0.12,0.18,0.28,0.18,0.47	s-0.06,0.35-0.18,0.49c-0.14,0.14-0.31,0.21-0.49,0.21c-0.18,0-0.35-0.07-0.48-0.21l-2.29-2.3v3.24c0,0.19-0.07,0.36-0.2,0.49	c-0.13,0.13-0.29,0.2-0.48,0.2c-0.19,0-0.36-0.07-0.5-0.2c-0.14-0.13-0.21-0.3-0.21-0.49v-3.22l-2.27,2.27	c-0.14,0.14-0.3,0.21-0.49,0.21s-0.35-0.07-0.49-0.21s-0.21-0.3-0.21-0.49s0.07-0.34,0.21-0.47l2.3-2.29h-3.24	c-0.19,0-0.35-0.07-0.48-0.2C9.5,14.75,9.44,14.59,9.44,14.41z M9.45,19.25c0-0.18,0.07-0.35,0.21-0.48	c0.12-0.14,0.28-0.21,0.47-0.21c0.19,0,0.35,0.07,0.49,0.21c0.14,0.14,0.21,0.3,0.21,0.48c0,0.18-0.07,0.35-0.21,0.48	c-0.14,0.14-0.3,0.21-0.49,0.21c-0.19,0-0.35-0.07-0.47-0.21C9.52,19.6,9.45,19.44,9.45,19.25z M9.45,9.54	c0-0.18,0.07-0.35,0.21-0.48c0.12-0.14,0.28-0.21,0.47-0.21c0.19,0,0.35,0.07,0.49,0.21c0.14,0.14,0.21,0.3,0.21,0.48	s-0.07,0.35-0.21,0.49c-0.14,0.14-0.3,0.21-0.49,0.21c-0.19,0-0.35-0.07-0.47-0.21C9.52,9.89,9.45,9.72,9.45,9.54z M14.3,21.25	c0-0.18,0.07-0.34,0.21-0.47c0.14-0.13,0.3-0.2,0.5-0.2c0.19,0,0.35,0.07,0.48,0.2c0.13,0.13,0.2,0.29,0.2,0.47	c0,0.19-0.07,0.36-0.2,0.49c-0.13,0.13-0.29,0.2-0.48,0.2c-0.19,0-0.36-0.07-0.5-0.2C14.37,21.61,14.3,21.45,14.3,21.25z M14.3,7.54	c0-0.19,0.07-0.36,0.21-0.49s0.3-0.2,0.5-0.2c0.19,0,0.35,0.07,0.48,0.2c0.13,0.13,0.2,0.3,0.2,0.49c0,0.18-0.07,0.34-0.2,0.47	c-0.13,0.13-0.29,0.2-0.48,0.2c-0.19,0-0.36-0.07-0.5-0.2C14.37,7.88,14.3,7.72,14.3,7.54z M19.17,19.25c0-0.18,0.07-0.35,0.21-0.48	c0.12-0.14,0.28-0.21,0.47-0.21c0.19,0,0.35,0.07,0.49,0.21c0.14,0.14,0.21,0.3,0.21,0.48c0,0.18-0.07,0.35-0.21,0.48	c-0.14,0.14-0.3,0.21-0.49,0.21c-0.19,0-0.35-0.07-0.47-0.21C19.24,19.6,19.17,19.44,19.17,19.25z M19.17,9.54	c0-0.18,0.07-0.35,0.21-0.48c0.12-0.14,0.28-0.21,0.47-0.21c0.19,0,0.35,0.07,0.49,0.21c0.14,0.14,0.21,0.3,0.21,0.48	s-0.07,0.35-0.21,0.49c-0.14,0.14-0.3,0.21-0.49,0.21c-0.19,0-0.35-0.07-0.47-0.21C19.24,9.89,19.17,9.72,19.17,9.54z M21.17,14.41	c0-0.19,0.07-0.36,0.2-0.5c0.13-0.14,0.3-0.21,0.49-0.21c0.18,0,0.34,0.07,0.47,0.21c0.13,0.14,0.2,0.3,0.2,0.5	c0,0.18-0.07,0.34-0.2,0.47c-0.13,0.13-0.29,0.2-0.47,0.2c-0.19,0-0.36-0.07-0.49-0.2C21.24,14.75,21.17,14.59,21.17,14.41z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
