// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoSpeedometerOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M326.1,231.9l-47.5,75.5a31,31,0,0,1-7,7,30.11,30.11,0,0,1-35-49l75.5-47.5a10.23,10.23,0,0,1,11.7,0A10.06,10.06,0,0,1,326.1,231.9Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M256,64C132.3,64,32,164.2,32,287.9A223.18,223.18,0,0,0,88.3,436.4c1.1,1.2,2.1,2.4,3.2,3.5a25.19,25.19,0,0,0,37.1-.1,173.13,173.13,0,0,1,254.8,0,25.19,25.19,0,0,0,37.1.1l3.2-3.5A223.18,223.18,0,0,0,480,287.9C480,164.2,379.7,64,256,64Z");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "stroke-linecap", "round");
		builder.AddAttribute(19, "stroke-linejoin", "round");
		builder.AddAttribute(20, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(21, "line");
		builder.AddAttribute(22, "x1", "256");
		builder.AddAttribute(23, "y1", "128");
		builder.AddAttribute(24, "x2", "256");
		builder.AddAttribute(25, "y2", "160");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "stroke-linecap", "round");
		builder.AddAttribute(28, "stroke-miterlimit", "10");
		builder.AddAttribute(29, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(30, "line");
		builder.AddAttribute(31, "x1", "416");
		builder.AddAttribute(32, "y1", "288");
		builder.AddAttribute(33, "x2", "384");
		builder.AddAttribute(34, "y2", "288");
		builder.AddAttribute(35, "fill", "none");
		builder.AddAttribute(36, "stroke-linecap", "round");
		builder.AddAttribute(37, "stroke-miterlimit", "10");
		builder.AddAttribute(38, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(39, "line");
		builder.AddAttribute(40, "x1", "128");
		builder.AddAttribute(41, "y1", "288");
		builder.AddAttribute(42, "x2", "96");
		builder.AddAttribute(43, "y2", "288");
		builder.AddAttribute(44, "fill", "none");
		builder.AddAttribute(45, "stroke-linecap", "round");
		builder.AddAttribute(46, "stroke-miterlimit", "10");
		builder.AddAttribute(47, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(48, "line");
		builder.AddAttribute(49, "x1", "165.49");
		builder.AddAttribute(50, "y1", "197.49");
		builder.AddAttribute(51, "x2", "142.86");
		builder.AddAttribute(52, "y2", "174.86");
		builder.AddAttribute(53, "fill", "none");
		builder.AddAttribute(54, "stroke-linecap", "round");
		builder.AddAttribute(55, "stroke-miterlimit", "10");
		builder.AddAttribute(56, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(57, "line");
		builder.AddAttribute(58, "x1", "346.51");
		builder.AddAttribute(59, "y1", "197.49");
		builder.AddAttribute(60, "x2", "369.14");
		builder.AddAttribute(61, "y2", "174.86");
		builder.AddAttribute(62, "fill", "none");
		builder.AddAttribute(63, "stroke-linecap", "round");
		builder.AddAttribute(64, "stroke-miterlimit", "10");
		builder.AddAttribute(65, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
