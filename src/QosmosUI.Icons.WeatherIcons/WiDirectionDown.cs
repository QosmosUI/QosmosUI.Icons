// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons;

public class WiDirectionDown : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.77,16.47c0,0.22,0.08,0.4,0.25,0.55l2.4,2.45c0.16,0.16,0.35,0.23,0.58,0.23c0.24,0,0.43-0.08,0.59-0.23l2.4-2.45	c0.16-0.14,0.24-0.33,0.24-0.55c0-0.22-0.08-0.41-0.23-0.57s-0.34-0.23-0.56-0.23s-0.42,0.08-0.57,0.23l-1.06,1.05v-6.59	c0-0.22-0.08-0.41-0.24-0.56C15.42,9.66,15.23,9.58,15,9.58s-0.42,0.07-0.58,0.22c-0.16,0.15-0.24,0.34-0.24,0.56v6.59l-1.06-1.05	c-0.16-0.16-0.34-0.23-0.55-0.23c-0.22,0-0.42,0.08-0.57,0.23S11.77,16.25,11.77,16.47z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
