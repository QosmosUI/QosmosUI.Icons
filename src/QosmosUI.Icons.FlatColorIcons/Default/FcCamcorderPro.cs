// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcCamcorderPro : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "x", "27");
		builder.AddAttribute(15, "y", "8");
		builder.AddAttribute(16, "fill", "#37474F");
		builder.AddAttribute(17, "width", "10");
		builder.AddAttribute(18, "height", "4");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#607D8B");
		builder.AddAttribute(21, "d", "M27,8h-9.7c-1.5,0-2.8,0.8-3.5,2.1l-3.3,6L14,18l3.3-6H27v7.2h4V12C31,9.8,29.2,8,27,8z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#607D8B");
		builder.AddAttribute(24, "d", "M30,40H6c-2.2,0-4-1.8-4-4V20c0-2.2,1.8-4,4-4h24c2.2,0,4,1.8,4,4v16C34,38.2,32.2,40,30,40z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#607D8B");
		builder.AddAttribute(27, "d", "M38,35l5,5h3V18h-3l-5,5V35z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#546E7A");
		builder.AddAttribute(30, "d", "M22,35H8c-1.1,0-2-0.9-2-2V23c0-1.1,0.9-2,2-2h14c1.1,0,2,0.9,2,2v10C24,34.1,23.1,35,22,35z");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "34");
		builder.AddAttribute(33, "y", "23");
		builder.AddAttribute(34, "fill", "#455A64");
		builder.AddAttribute(35, "width", "4");
		builder.AddAttribute(36, "height", "12");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#263238");
		builder.AddAttribute(39, "d", "M41,13h-4c-0.6,0-1-0.4-1-1V8c0-0.6,0.4-1,1-1h4c1.7,0,3,1.3,3,3v0C44,11.7,42.7,13,41,13z");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "8");
		builder.AddAttribute(42, "y", "23");
		builder.AddAttribute(43, "fill", "#03A9F4");
		builder.AddAttribute(44, "width", "14");
		builder.AddAttribute(45, "height", "10");
		builder.CloseElement();
		builder.OpenElement(46, "polygon");
		builder.AddAttribute(47, "fill", "#4FC3F7");
		builder.AddAttribute(48, "points", "13.5,25.5 9,32 18,32");
		builder.CloseElement();
		builder.OpenElement(49, "g");
		builder.AddAttribute(50, "fill", "#B3E5FC");
		builder.OpenElement(51, "circle");
		builder.AddAttribute(52, "cx", "19.5");
		builder.AddAttribute(53, "cy", "25.5");
		builder.AddAttribute(54, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(55, "polygon");
		builder.AddAttribute(56, "points", "17.5,27.6 14,32 21,32");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
