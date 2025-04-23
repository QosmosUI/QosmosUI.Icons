// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoLogoClosedCaptioning : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M0,80V432H512V80ZM464,255.78c0,25.74-1.6,45.32-3.77,77.22s-19.2,54.34-59.09,57.86S305.37,394.71,256,394.6c-49,.11-105.14-.11-145.14-3.74s-56.8-26-59.09-57.86S48,281.52,48,255.78s.11-42.46,3.77-77.22,23-54.12,59.09-57.64S209.14,117.4,256,117.4s109,0,145.14,3.52,55.43,23,59.09,57.64S464,230.15,464,255.78Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M367.57,282.84v.77c0,17.93-11.11,28.49-25.95,28.49s-24.84-11.88-26.27-28.49c0,0-1.31-8.69-1.31-26.29a229.5,229.5,0,0,1,1.53-28.6c2.64-18.7,11.77-28.49,26.6-28.49s26.49,12.76,26.49,32.12v.55h49.58c0-24.09-6.05-45.76-18.25-59.4S369.76,153,345.8,153a108.06,108.06,0,0,0-33,4.73,58.82,58.82,0,0,0-25.94,16.61C279.63,182.3,274,192.86,270,206.17s-6,30-6,50.27c0,19.8,1.65,36.3,4.84,49.61s8,23.87,14.4,31.79a49.76,49.76,0,0,0,24,16.5q14.5,4.62,34,4.62c27.47,0,47.26-7,59.13-20.57S418,305.06,418,279.1H367.35C367.57,279.1,367.57,281.85,367.57,282.84Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M197.3,282.84v.77c0,17.93-11.1,28.49-25.94,28.49s-24.84-11.88-26.27-28.49c0,0-1.31-8.69-1.31-26.29a229.5,229.5,0,0,1,1.53-28.6c2.64-18.7,11.77-28.49,26.6-28.49S198.4,213,198.4,232.35v.55H248c0-24.09-6-45.76-18.25-59.4S199.5,153,175.54,153a108.06,108.06,0,0,0-33,4.73,58.82,58.82,0,0,0-25.94,16.61c-7.26,7.92-12.86,18.48-16.93,31.79s-6,30-6,50.27c0,19.8,1.65,36.3,4.84,49.61s8,23.87,14.4,31.79a49.76,49.76,0,0,0,24,16.5q14.51,4.62,34,4.62c27.48,0,47.27-7,59.14-20.57s17.81-33.33,17.81-59.29H197.08C197.3,279.1,197.3,281.85,197.3,282.84Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
