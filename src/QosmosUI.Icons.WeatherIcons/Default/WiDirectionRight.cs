// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiDirectionRight : ComponentBase
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
		builder.AddAttribute(14, "d", "M9.94,14.36c0,0.22,0.08,0.42,0.23,0.57s0.34,0.22,0.56,0.2h6.58l-1.03,1.08c-0.16,0.16-0.24,0.35-0.24,0.55	c0,0.22,0.08,0.42,0.24,0.57c0.16,0.16,0.35,0.23,0.58,0.23c0.21-0.01,0.39-0.1,0.53-0.27l2.45-2.41c0.16-0.16,0.23-0.35,0.23-0.58	c-0.01-0.24-0.09-0.43-0.24-0.58l-2.47-2.39c-0.15-0.16-0.33-0.24-0.54-0.23c-0.23,0-0.42,0.07-0.57,0.22	c-0.16,0.15-0.23,0.34-0.23,0.56c0,0.23,0.08,0.42,0.23,0.57l1.06,1.08h-6.59c-0.23,0.01-0.41,0.09-0.56,0.25	C10.01,13.95,9.94,14.14,9.94,14.36z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
