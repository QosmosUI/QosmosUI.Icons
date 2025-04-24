// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiStars : ComponentBase
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
		builder.AddAttribute(14, "d", "M5.37,16.18c0.65-0.03,1.2-0.28,1.65-0.75c0.45-0.47,0.68-1.03,0.68-1.68c0,0.65,0.22,1.21,0.67,1.68	c0.45,0.47,1,0.72,1.65,0.75c-0.65,0.03-1.2,0.28-1.65,0.75c-0.45,0.47-0.67,1.03-0.67,1.68c0-0.65-0.22-1.21-0.68-1.68	C6.57,16.46,6.02,16.21,5.37,16.18z M7.7,8.98c1.26-0.06,2.33-0.55,3.21-1.47c0.88-0.92,1.32-2.01,1.32-3.28	c0,1.27,0.44,2.36,1.32,3.28s1.95,1.4,3.22,1.47c-0.83,0.04-1.59,0.27-2.29,0.71c-0.69,0.43-1.24,1.01-1.65,1.73	c-0.4,0.72-0.6,1.49-0.6,2.33c0-1.27-0.44-2.37-1.32-3.29C10.03,9.53,8.96,9.04,7.7,8.98z M11.02,19.75	c0.95-0.04,1.76-0.41,2.42-1.1c0.66-0.69,0.99-1.51,0.99-2.47c0,0.96,0.33,1.78,0.99,2.47c0.66,0.69,1.46,1.06,2.41,1.1	c-0.95,0.04-1.75,0.41-2.41,1.1c-0.66,0.69-0.99,1.51-0.99,2.47c0-0.96-0.33-1.78-0.99-2.47C12.77,20.16,11.97,19.8,11.02,19.75z	 M17.83,15.01c0.95-0.04,1.75-0.41,2.41-1.1c0.66-0.69,0.98-1.51,0.98-2.48c0,0.96,0.33,1.78,0.99,2.47s1.47,1.06,2.42,1.1	c-0.95,0.04-1.76,0.41-2.42,1.1c-0.66,0.69-0.99,1.51-0.99,2.47c0-0.96-0.33-1.78-0.98-2.47C19.58,15.42,18.78,15.05,17.83,15.01z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
