// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcPrint : ComponentBase
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
		builder.AddAttribute(14, "x", "9");
		builder.AddAttribute(15, "y", "11");
		builder.AddAttribute(16, "fill", "#424242");
		builder.AddAttribute(17, "width", "30");
		builder.AddAttribute(18, "height", "3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#616161");
		builder.AddAttribute(21, "d", "M4,25h40v-7c0-2.2-1.8-4-4-4H8c-2.2,0-4,1.8-4,4V25z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#424242");
		builder.AddAttribute(24, "d", "M8,36h32c2.2,0,4-1.8,4-4v-8H4v8C4,34.2,5.8,36,8,36z");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "fill", "#00E676");
		builder.AddAttribute(27, "cx", "40");
		builder.AddAttribute(28, "cy", "18");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "11");
		builder.AddAttribute(32, "y", "4");
		builder.AddAttribute(33, "fill", "#90CAF9");
		builder.AddAttribute(34, "width", "26");
		builder.AddAttribute(35, "height", "10");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "fill", "#242424");
		builder.AddAttribute(38, "d", "M37.5,31h-27C9.7,31,9,30.3,9,29.5v0c0-0.8,0.7-1.5,1.5-1.5h27c0.8,0,1.5,0.7,1.5,1.5v0 C39,30.3,38.3,31,37.5,31z");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "11");
		builder.AddAttribute(41, "y", "31");
		builder.AddAttribute(42, "fill", "#90CAF9");
		builder.AddAttribute(43, "width", "26");
		builder.AddAttribute(44, "height", "11");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "11");
		builder.AddAttribute(47, "y", "29");
		builder.AddAttribute(48, "fill", "#42A5F5");
		builder.AddAttribute(49, "width", "26");
		builder.AddAttribute(50, "height", "2");
		builder.CloseElement();
		builder.OpenElement(51, "g");
		builder.AddAttribute(52, "fill", "#1976D2");
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "x", "16");
		builder.AddAttribute(55, "y", "33");
		builder.AddAttribute(56, "width", "17");
		builder.AddAttribute(57, "height", "2");
		builder.CloseElement();
		builder.OpenElement(58, "rect");
		builder.AddAttribute(59, "x", "16");
		builder.AddAttribute(60, "y", "37");
		builder.AddAttribute(61, "width", "13");
		builder.AddAttribute(62, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
