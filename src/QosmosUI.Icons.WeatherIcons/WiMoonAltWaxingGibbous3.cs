// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons;

public class WiMoonAltWaxingGibbous3 : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.74,14.44c0-2.03,0.5-3.91,1.51-5.64s2.37-3.1,4.1-4.1s3.61-1.51,5.64-1.51c1.52,0,2.98,0.3,4.37,0.89s2.59,1.4,3.6,2.4	s1.81,2.2,2.4,3.59s0.89,2.84,0.89,4.37s-0.3,2.98-0.89,4.37s-1.4,2.59-2.4,3.6s-2.2,1.81-3.6,2.4s-2.85,0.89-4.37,0.89	s-2.98-0.3-4.37-0.89s-2.59-1.4-3.59-2.4s-1.8-2.2-2.4-3.6S3.74,15.97,3.74,14.44z M10.54,14.44c0,4.44,1.17,7.78,3.5,10.02	c0.07,0,0.17,0,0.3,0.01s0.25,0.02,0.35,0.02s0.2,0.01,0.3,0.01c1.36,0,2.66-0.27,3.9-0.8s2.32-1.25,3.22-2.15s1.61-1.97,2.15-3.21	s0.8-2.54,0.8-3.91c0-1.36-0.27-2.66-0.8-3.9s-1.25-2.31-2.15-3.21s-1.97-1.61-3.22-2.15s-2.55-0.8-3.9-0.8	c-0.36,0-0.63,0.01-0.81,0.03c-1.08,1.22-1.96,2.69-2.64,4.42S10.54,12.43,10.54,14.44z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
