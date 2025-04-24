// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiMoonAltWaningGibbous1 : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.74,14.43c0-2.04,0.51-3.92,1.52-5.65S7.64,5.7,9.37,4.69s3.61-1.5,5.65-1.5s3.92,0.5,5.65,1.5s3.09,2.36,4.09,4.09	s1.5,3.61,1.5,5.65s-0.5,3.93-1.5,5.65s-2.36,3.1-4.09,4.11s-3.61,1.52-5.65,1.52s-3.93-0.51-5.65-1.52s-3.1-2.38-4.11-4.11	S3.74,16.47,3.74,14.43z M4.94,14.43c0,1.36,0.27,2.66,0.81,3.9S7,20.65,7.9,21.55s1.97,1.62,3.22,2.15s2.55,0.81,3.9,0.81	c0.86,0,1.62-0.09,2.29-0.28c0.83-0.44,1.55-0.96,2.17-1.57s1.1-1.22,1.46-1.85s0.64-1.33,0.86-2.09s0.36-1.48,0.43-2.14	s0.1-1.37,0.1-2.15c0-0.93-0.1-1.84-0.3-2.74S21.52,9.9,21.1,9.02s-0.99-1.72-1.72-2.5s-1.57-1.45-2.54-1.99	c-0.4-0.09-1.01-0.13-1.82-0.13c-1.36,0-2.66,0.26-3.9,0.79S8.8,6.43,7.9,7.32s-1.62,1.97-2.15,3.2S4.94,13.06,4.94,14.43z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
