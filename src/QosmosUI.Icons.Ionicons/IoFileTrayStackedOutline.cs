// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoFileTrayStackedOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M48,336v96a48.14,48.14,0,0,0,48,48H416a48.14,48.14,0,0,0,48-48V336");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "x1", "48");
		builder.AddAttribute(20, "y1", "336");
		builder.AddAttribute(21, "x2", "192");
		builder.AddAttribute(22, "y2", "336");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-linecap", "round");
		builder.AddAttribute(25, "stroke-linejoin", "round");
		builder.AddAttribute(26, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(27, "line");
		builder.AddAttribute(28, "x1", "320");
		builder.AddAttribute(29, "y1", "336");
		builder.AddAttribute(30, "x2", "464");
		builder.AddAttribute(31, "y2", "336");
		builder.AddAttribute(32, "fill", "none");
		builder.AddAttribute(33, "stroke-linecap", "round");
		builder.AddAttribute(34, "stroke-linejoin", "round");
		builder.AddAttribute(35, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M192,336a64,64,0,0,0,128,0");
		builder.AddAttribute(38, "fill", "none");
		builder.AddAttribute(39, "stroke-linecap", "round");
		builder.AddAttribute(40, "stroke-linejoin", "round");
		builder.AddAttribute(41, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M384,32H128c-26,0-43,14-48,40L48,192v96a48.14,48.14,0,0,0,48,48H416a48.14,48.14,0,0,0,48-48V192L432,72C427,45,409,32,384,32Z");
		builder.AddAttribute(44, "fill", "none");
		builder.AddAttribute(45, "stroke-linejoin", "round");
		builder.AddAttribute(46, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(47, "line");
		builder.AddAttribute(48, "x1", "48");
		builder.AddAttribute(49, "y1", "192");
		builder.AddAttribute(50, "x2", "192");
		builder.AddAttribute(51, "y2", "192");
		builder.AddAttribute(52, "fill", "none");
		builder.AddAttribute(53, "stroke-linecap", "round");
		builder.AddAttribute(54, "stroke-linejoin", "round");
		builder.AddAttribute(55, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(56, "line");
		builder.AddAttribute(57, "x1", "320");
		builder.AddAttribute(58, "y1", "192");
		builder.AddAttribute(59, "x2", "464");
		builder.AddAttribute(60, "y2", "192");
		builder.AddAttribute(61, "fill", "none");
		builder.AddAttribute(62, "stroke-linecap", "round");
		builder.AddAttribute(63, "stroke-linejoin", "round");
		builder.AddAttribute(64, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(65, "path");
		builder.AddAttribute(66, "d", "M192,192a64,64,0,0,0,128,0");
		builder.AddAttribute(67, "fill", "none");
		builder.AddAttribute(68, "stroke-linecap", "round");
		builder.AddAttribute(69, "stroke-linejoin", "round");
		builder.AddAttribute(70, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
