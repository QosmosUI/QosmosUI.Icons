// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoLibraryOutline : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "32");
		builder.AddAttribute(15, "y", "96");
		builder.AddAttribute(16, "width", "64");
		builder.AddAttribute(17, "height", "368");
		builder.AddAttribute(18, "rx", "16");
		builder.AddAttribute(19, "ry", "16");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linejoin", "round");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "line");
		builder.AddAttribute(24, "x1", "112");
		builder.AddAttribute(25, "y1", "224");
		builder.AddAttribute(26, "x2", "240");
		builder.AddAttribute(27, "y2", "224");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-linecap", "round");
		builder.AddAttribute(30, "stroke-linejoin", "round");
		builder.AddAttribute(31, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(32, "line");
		builder.AddAttribute(33, "x1", "112");
		builder.AddAttribute(34, "y1", "400");
		builder.AddAttribute(35, "x2", "240");
		builder.AddAttribute(36, "y2", "400");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "112");
		builder.AddAttribute(43, "y", "160");
		builder.AddAttribute(44, "width", "128");
		builder.AddAttribute(45, "height", "304");
		builder.AddAttribute(46, "rx", "16");
		builder.AddAttribute(47, "ry", "16");
		builder.AddAttribute(48, "fill", "none");
		builder.AddAttribute(49, "stroke-linejoin", "round");
		builder.AddAttribute(50, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "x", "256");
		builder.AddAttribute(53, "y", "48");
		builder.AddAttribute(54, "width", "96");
		builder.AddAttribute(55, "height", "416");
		builder.AddAttribute(56, "rx", "16");
		builder.AddAttribute(57, "ry", "16");
		builder.AddAttribute(58, "fill", "none");
		builder.AddAttribute(59, "stroke-linejoin", "round");
		builder.AddAttribute(60, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(61, "path");
		builder.AddAttribute(62, "d", "M422.46,96.11l-40.4,4.25c-11.12,1.17-19.18,11.57-17.93,23.1l34.92,321.59c1.26,11.53,11.37,20,22.49,18.84l40.4-4.25c11.12-1.17,19.18-11.57,17.93-23.1L445,115C443.69,103.42,433.58,94.94,422.46,96.11Z");
		builder.AddAttribute(63, "fill", "none");
		builder.AddAttribute(64, "stroke-linejoin", "round");
		builder.AddAttribute(65, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
