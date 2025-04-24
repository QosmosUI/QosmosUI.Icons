// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiRefreshAlt : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.78,14.91c0,0.79,0.19,1.51,0.57,2.17c0.38,0.66,0.9,1.19,1.57,1.57c0.67,0.38,1.39,0.58,2.18,0.58	c0.19,0,0.35-0.07,0.48-0.22c0.13-0.14,0.2-0.31,0.2-0.51c0-0.19-0.07-0.35-0.2-0.48s-0.29-0.19-0.49-0.19	c-0.81,0-1.5-0.28-2.07-0.85c-0.57-0.57-0.85-1.26-0.85-2.07c0-0.78,0.27-1.45,0.8-2.02s1.16-0.86,1.88-0.86l-0.33,0.32	c-0.15,0.15-0.22,0.31-0.21,0.49c0,0.18,0.07,0.34,0.2,0.48c0.13,0.14,0.29,0.21,0.49,0.21c0.2,0,0.37-0.07,0.51-0.21l1.51-1.5	c0.13-0.11,0.2-0.27,0.2-0.51c0-0.22-0.07-0.38-0.2-0.47l-1.51-1.53c-0.13-0.14-0.29-0.21-0.49-0.21s-0.36,0.07-0.5,0.21	s-0.21,0.3-0.21,0.5c0,0.21,0.07,0.38,0.22,0.51l0.3,0.28c-1.15,0.08-2.11,0.53-2.89,1.35C12.17,12.77,11.78,13.76,11.78,14.91z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
