// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoCalendarClearOutline : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-linejoin", "round");
		builder.AddAttribute(16, "stroke-width", "32");
		builder.AddAttribute(17, "x", "48");
		builder.AddAttribute(18, "y", "80");
		builder.AddAttribute(19, "width", "416");
		builder.AddAttribute(20, "height", "384");
		builder.AddAttribute(21, "rx", "48");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-linejoin", "round");
		builder.AddAttribute(25, "stroke-width", "32");
		builder.AddAttribute(26, "stroke-linecap", "round");
		builder.AddAttribute(27, "x1", "128");
		builder.AddAttribute(28, "y1", "48");
		builder.AddAttribute(29, "x2", "128");
		builder.AddAttribute(30, "y2", "80");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "fill", "none");
		builder.AddAttribute(33, "stroke-linejoin", "round");
		builder.AddAttribute(34, "stroke-width", "32");
		builder.AddAttribute(35, "stroke-linecap", "round");
		builder.AddAttribute(36, "x1", "384");
		builder.AddAttribute(37, "y1", "48");
		builder.AddAttribute(38, "x2", "384");
		builder.AddAttribute(39, "y2", "80");
		builder.CloseElement();
		builder.OpenElement(40, "line");
		builder.AddAttribute(41, "fill", "none");
		builder.AddAttribute(42, "stroke-linejoin", "round");
		builder.AddAttribute(43, "stroke-width", "32");
		builder.AddAttribute(44, "stroke-linecap", "round");
		builder.AddAttribute(45, "x1", "464");
		builder.AddAttribute(46, "y1", "160");
		builder.AddAttribute(47, "x2", "48");
		builder.AddAttribute(48, "y2", "160");
		builder.CloseElement();
		builder.CloseElement();
    }
}
