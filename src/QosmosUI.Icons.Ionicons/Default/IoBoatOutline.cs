// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBoatOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M461.93,261.05c-2-4.76-6.71-7.83-11.67-9.49L263.08,177.08a23.78,23.78,0,0,0-14.17,0l-187,74.52c-5,1.56-9.83,4.77-11.81,9.53s-2.94,9.37-1,15.08L95.63,395.36A7.46,7.46,0,0,0,103.1,400c26.69-1.68,50.31-15.23,68.38-32.5a7.66,7.66,0,0,1,10.49,0C201.29,386,227,400,256,400s54.56-14,73.88-32.54a7.67,7.67,0,0,1,10.5,0c18.07,17.28,41.69,30.86,68.38,32.54a7.45,7.45,0,0,0,7.46-4.61l46.7-119.16C464.9,271.45,463.91,265.82,461.93,261.05Z");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-miterlimit", "10");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M416,473.14a6.84,6.84,0,0,0-3.56-6c-27.08-14.55-51.77-36.82-62.63-48a10.05,10.05,0,0,0-12.72-1.51c-50.33,32.42-111.61,32.44-161.95.05a10.09,10.09,0,0,0-12.82,1.56c-10.77,11.28-35.19,33.3-62.43,47.75A7.15,7.15,0,0,0,96,472.72a6.73,6.73,0,0,0,7.92,7.15c20.85-4.18,41-13.68,60.2-23.83a8.71,8.71,0,0,1,8-.06A185.14,185.14,0,0,0,340,456a8.82,8.82,0,0,1,8.09.06c19.1,10,39.22,19.59,60,23.8a6.72,6.72,0,0,0,7.95-6.71Z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M320,96V72a24.07,24.07,0,0,0-24-24H216a24.07,24.07,0,0,0-24,24V96");
		builder.AddAttribute(22, "fill", "none");
		builder.AddAttribute(23, "stroke-linecap", "round");
		builder.AddAttribute(24, "stroke-linejoin", "round");
		builder.AddAttribute(25, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M416,233V144a48.14,48.14,0,0,0-48-48H144a48.14,48.14,0,0,0-48,48v92");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-linecap", "round");
		builder.AddAttribute(30, "stroke-linejoin", "round");
		builder.AddAttribute(31, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(32, "line");
		builder.AddAttribute(33, "x1", "256");
		builder.AddAttribute(34, "y1", "183.6");
		builder.AddAttribute(35, "x2", "256");
		builder.AddAttribute(36, "y2", "396.45");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
