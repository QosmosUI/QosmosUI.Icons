// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoLocate : ComponentBase
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
		builder.OpenElement(13, "line");
		builder.AddAttribute(14, "x1", "256");
		builder.AddAttribute(15, "y1", "96");
		builder.AddAttribute(16, "x2", "256");
		builder.AddAttribute(17, "y2", "56");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "256");
		builder.AddAttribute(24, "y1", "456");
		builder.AddAttribute(25, "x2", "256");
		builder.AddAttribute(26, "y2", "416");
		builder.AddAttribute(27, "fill", "none");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-linejoin", "round");
		builder.AddAttribute(30, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M256,112A144,144,0,1,0,400,256,144,144,0,0,0,256,112Z");
		builder.AddAttribute(33, "fill", "none");
		builder.AddAttribute(34, "stroke-linecap", "round");
		builder.AddAttribute(35, "stroke-linejoin", "round");
		builder.AddAttribute(36, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(37, "line");
		builder.AddAttribute(38, "x1", "416");
		builder.AddAttribute(39, "y1", "256");
		builder.AddAttribute(40, "x2", "456");
		builder.AddAttribute(41, "y2", "256");
		builder.AddAttribute(42, "fill", "none");
		builder.AddAttribute(43, "stroke-linecap", "round");
		builder.AddAttribute(44, "stroke-linejoin", "round");
		builder.AddAttribute(45, "stroke-width", "48px");
		builder.CloseElement();
		builder.OpenElement(46, "line");
		builder.AddAttribute(47, "x1", "56");
		builder.AddAttribute(48, "y1", "256");
		builder.AddAttribute(49, "x2", "96");
		builder.AddAttribute(50, "y2", "256");
		builder.AddAttribute(51, "fill", "none");
		builder.AddAttribute(52, "stroke-linecap", "round");
		builder.AddAttribute(53, "stroke-linejoin", "round");
		builder.AddAttribute(54, "stroke-width", "48px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
