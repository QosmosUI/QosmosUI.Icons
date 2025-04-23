// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcPlanner : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#CFD8DC");
		builder.AddAttribute(15, "d", "M5,38V14h38v24c0,2.2-1.8,4-4,4H9C6.8,42,5,40.2,5,38z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#F44336");
		builder.AddAttribute(18, "d", "M43,10v6H5v-6c0-2.2,1.8-4,4-4h30C41.2,6,43,7.8,43,10z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#B71C1C");
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "33");
		builder.AddAttribute(23, "cy", "10");
		builder.AddAttribute(24, "r", "3");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "15");
		builder.AddAttribute(27, "cy", "10");
		builder.AddAttribute(28, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(29, "g");
		builder.AddAttribute(30, "fill", "#B0BEC5");
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M33,3c-1.1,0-2,0.9-2,2v5c0,1.1,0.9,2,2,2s2-0.9,2-2V5C35,3.9,34.1,3,33,3z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M15,3c-1.1,0-2,0.9-2,2v5c0,1.1,0.9,2,2,2s2-0.9,2-2V5C17,3.9,16.1,3,15,3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(35, "g");
		builder.AddAttribute(36, "fill", "#B0BEC5");
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "13");
		builder.AddAttribute(39, "y", "21");
		builder.AddAttribute(40, "width", "6");
		builder.AddAttribute(41, "height", "6");
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "x", "21");
		builder.AddAttribute(44, "y", "21");
		builder.AddAttribute(45, "width", "6");
		builder.AddAttribute(46, "height", "6");
		builder.CloseElement();
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "x", "29");
		builder.AddAttribute(49, "y", "21");
		builder.AddAttribute(50, "width", "6");
		builder.AddAttribute(51, "height", "6");
		builder.CloseElement();
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "x", "13");
		builder.AddAttribute(54, "y", "29");
		builder.AddAttribute(55, "width", "6");
		builder.AddAttribute(56, "height", "6");
		builder.CloseElement();
		builder.OpenElement(57, "rect");
		builder.AddAttribute(58, "x", "21");
		builder.AddAttribute(59, "y", "29");
		builder.AddAttribute(60, "width", "6");
		builder.AddAttribute(61, "height", "6");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(62, "rect");
		builder.AddAttribute(63, "x", "29");
		builder.AddAttribute(64, "y", "29");
		builder.AddAttribute(65, "fill", "#F44336");
		builder.AddAttribute(66, "width", "6");
		builder.AddAttribute(67, "height", "6");
		builder.CloseElement();
		builder.CloseElement();
    }
}
