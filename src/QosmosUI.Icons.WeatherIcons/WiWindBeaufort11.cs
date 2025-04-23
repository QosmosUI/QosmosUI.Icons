// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons;

public class WiWindBeaufort11 : ComponentBase
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
		builder.AddAttribute(14, "d", "M4.68,13.5c0,0.18,0.06,0.31,0.17,0.4c0.12,0.11,0.26,0.17,0.42,0.17h10.4c0.17,0,0.33,0.06,0.46,0.19	c0.13,0.12,0.2,0.28,0.2,0.46s-0.07,0.34-0.2,0.47c-0.13,0.13-0.28,0.2-0.46,0.2c-0.18,0-0.34-0.07-0.47-0.21	c-0.13-0.11-0.26-0.16-0.4-0.16c-0.16,0-0.3,0.05-0.41,0.16c-0.11,0.11-0.16,0.24-0.16,0.39c0,0.16,0.06,0.3,0.17,0.41	c0.36,0.36,0.78,0.53,1.28,0.53s0.91-0.17,1.26-0.52c0.35-0.35,0.52-0.77,0.52-1.27c0-0.49-0.17-0.92-0.52-1.27	c-0.35-0.35-0.77-0.53-1.26-0.53H5.27c-0.16,0-0.3,0.06-0.42,0.17C4.74,13.21,4.68,13.34,4.68,13.5z M4.68,11.48	c0,0.17,0.06,0.3,0.17,0.39c0.12,0.11,0.26,0.16,0.42,0.16h13.81c0.49,0,0.92-0.18,1.27-0.52c0.35-0.35,0.52-0.77,0.52-1.27	c0-0.49-0.17-0.91-0.52-1.26s-0.77-0.52-1.27-0.52c-0.49,0-0.91,0.17-1.27,0.51c-0.11,0.12-0.16,0.27-0.16,0.42	c0,0.16,0.05,0.3,0.16,0.4c0.11,0.1,0.24,0.15,0.4,0.15c0.15,0,0.29-0.05,0.41-0.16c0.12-0.12,0.27-0.18,0.45-0.18	c0.17,0,0.33,0.06,0.46,0.18c0.13,0.12,0.2,0.27,0.2,0.45c0,0.18-0.07,0.34-0.2,0.47c-0.13,0.13-0.28,0.2-0.46,0.2H5.27	c-0.16,0-0.3,0.06-0.42,0.17C4.74,11.18,4.68,11.32,4.68,11.48z M17.57,21.9h2.47l1.65-7.99h-2.47L17.57,21.9z M21.3,21.9h2.46	l1.65-7.99h-2.45L21.3,21.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
