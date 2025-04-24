// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoDocumentTextOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M416,221.25V416a48,48,0,0,1-48,48H144a48,48,0,0,1-48-48V96a48,48,0,0,1,48-48h98.75a32,32,0,0,1,22.62,9.37L406.63,198.63A32,32,0,0,1,416,221.25Z");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M256,56V176a32,32,0,0,0,32,32H408");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "round");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(24, "line");
		builder.AddAttribute(25, "x1", "176");
		builder.AddAttribute(26, "y1", "288");
		builder.AddAttribute(27, "x2", "336");
		builder.AddAttribute(28, "y2", "288");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "line");
		builder.AddAttribute(34, "x1", "176");
		builder.AddAttribute(35, "y1", "368");
		builder.AddAttribute(36, "x2", "336");
		builder.AddAttribute(37, "y2", "368");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke-linecap", "round");
		builder.AddAttribute(40, "stroke-linejoin", "round");
		builder.AddAttribute(41, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
