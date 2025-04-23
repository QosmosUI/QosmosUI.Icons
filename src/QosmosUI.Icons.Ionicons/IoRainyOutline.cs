// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoRainyOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M114.61,162.85A16.07,16.07,0,0,0,128,149.6C140.09,76.17,193.63,32,256,32c57.93,0,96.62,37.75,112.2,77.74a15.84,15.84,0,0,0,12.2,9.87c50,8.15,91.6,41.54,91.6,99.59C472,278.6,423.4,320,364,320H130c-49.5,0-90-24.7-90-79.2C40,192.33,78.67,168.58,114.61,162.85Z");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "x1", "144");
		builder.AddAttribute(20, "y1", "384");
		builder.AddAttribute(21, "x2", "112");
		builder.AddAttribute(22, "y2", "432");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-linecap", "round");
		builder.AddAttribute(25, "stroke-linejoin", "round");
		builder.AddAttribute(26, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(27, "line");
		builder.AddAttribute(28, "x1", "224");
		builder.AddAttribute(29, "y1", "384");
		builder.AddAttribute(30, "x2", "160");
		builder.AddAttribute(31, "y2", "480");
		builder.AddAttribute(32, "fill", "none");
		builder.AddAttribute(33, "stroke-linecap", "round");
		builder.AddAttribute(34, "stroke-linejoin", "round");
		builder.AddAttribute(35, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(36, "line");
		builder.AddAttribute(37, "x1", "304");
		builder.AddAttribute(38, "y1", "384");
		builder.AddAttribute(39, "x2", "272");
		builder.AddAttribute(40, "y2", "432");
		builder.AddAttribute(41, "fill", "none");
		builder.AddAttribute(42, "stroke-linecap", "round");
		builder.AddAttribute(43, "stroke-linejoin", "round");
		builder.AddAttribute(44, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(45, "line");
		builder.AddAttribute(46, "x1", "384");
		builder.AddAttribute(47, "y1", "384");
		builder.AddAttribute(48, "x2", "320");
		builder.AddAttribute(49, "y2", "480");
		builder.AddAttribute(50, "fill", "none");
		builder.AddAttribute(51, "stroke-linecap", "round");
		builder.AddAttribute(52, "stroke-linejoin", "round");
		builder.AddAttribute(53, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
