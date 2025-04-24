// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoTrashOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M112,112l20,320c.95,18.49,14.4,32,32,32H348c17.67,0,30.87-13.51,32-32l20-320");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "line");
		builder.AddAttribute(20, "x1", "80");
		builder.AddAttribute(21, "y1", "112");
		builder.AddAttribute(22, "x2", "432");
		builder.AddAttribute(23, "y2", "112");
		builder.AddAttribute(24, "stroke-linecap", "round");
		builder.AddAttribute(25, "stroke-miterlimit", "10");
		builder.AddAttribute(26, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M192,112V72h0a23.93,23.93,0,0,1,24-24h80a23.93,23.93,0,0,1,24,24h0v40");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "line");
		builder.AddAttribute(34, "x1", "256");
		builder.AddAttribute(35, "y1", "176");
		builder.AddAttribute(36, "x2", "256");
		builder.AddAttribute(37, "y2", "400");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke-linecap", "round");
		builder.AddAttribute(40, "stroke-linejoin", "round");
		builder.AddAttribute(41, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(42, "line");
		builder.AddAttribute(43, "x1", "184");
		builder.AddAttribute(44, "y1", "176");
		builder.AddAttribute(45, "x2", "192");
		builder.AddAttribute(46, "y2", "400");
		builder.AddAttribute(47, "fill", "none");
		builder.AddAttribute(48, "stroke-linecap", "round");
		builder.AddAttribute(49, "stroke-linejoin", "round");
		builder.AddAttribute(50, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(51, "line");
		builder.AddAttribute(52, "x1", "328");
		builder.AddAttribute(53, "y1", "176");
		builder.AddAttribute(54, "x2", "320");
		builder.AddAttribute(55, "y2", "400");
		builder.AddAttribute(56, "fill", "none");
		builder.AddAttribute(57, "stroke-linecap", "round");
		builder.AddAttribute(58, "stroke-linejoin", "round");
		builder.AddAttribute(59, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
