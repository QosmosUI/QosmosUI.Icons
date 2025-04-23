// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoMaleFemaleOutline : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "216");
		builder.AddAttribute(15, "cy", "200");
		builder.AddAttribute(16, "r", "136");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "stroke-linecap", "round");
		builder.AddAttribute(19, "stroke-linejoin", "round");
		builder.AddAttribute(20, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(21, "line");
		builder.AddAttribute(22, "x1", "216");
		builder.AddAttribute(23, "y1", "352");
		builder.AddAttribute(24, "x2", "216");
		builder.AddAttribute(25, "y2", "480");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "stroke-linecap", "round");
		builder.AddAttribute(28, "stroke-linejoin", "round");
		builder.AddAttribute(29, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(30, "line");
		builder.AddAttribute(31, "x1", "272");
		builder.AddAttribute(32, "y1", "416");
		builder.AddAttribute(33, "x2", "160");
		builder.AddAttribute(34, "y2", "416");
		builder.AddAttribute(35, "fill", "none");
		builder.AddAttribute(36, "stroke-linecap", "round");
		builder.AddAttribute(37, "stroke-linejoin", "round");
		builder.AddAttribute(38, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(39, "polyline");
		builder.AddAttribute(40, "points", "432 112 432 32 352 32");
		builder.AddAttribute(41, "fill", "none");
		builder.AddAttribute(42, "stroke-linecap", "round");
		builder.AddAttribute(43, "stroke-linejoin", "round");
		builder.AddAttribute(44, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(45, "line");
		builder.AddAttribute(46, "x1", "335.28");
		builder.AddAttribute(47, "y1", "128.72");
		builder.AddAttribute(48, "x2", "432");
		builder.AddAttribute(49, "y2", "32");
		builder.AddAttribute(50, "fill", "none");
		builder.AddAttribute(51, "stroke-linecap", "round");
		builder.AddAttribute(52, "stroke-linejoin", "round");
		builder.AddAttribute(53, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
