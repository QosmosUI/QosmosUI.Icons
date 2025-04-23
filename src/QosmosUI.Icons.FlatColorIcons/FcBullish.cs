// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcBullish : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#4CAF50");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "40");
		builder.AddAttribute(17, "y", "21");
		builder.AddAttribute(18, "width", "4");
		builder.AddAttribute(19, "height", "23");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "34");
		builder.AddAttribute(22, "y", "28");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "height", "16");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "28");
		builder.AddAttribute(27, "y", "23");
		builder.AddAttribute(28, "width", "4");
		builder.AddAttribute(29, "height", "21");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "22");
		builder.AddAttribute(32, "y", "29");
		builder.AddAttribute(33, "width", "4");
		builder.AddAttribute(34, "height", "15");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "16");
		builder.AddAttribute(37, "y", "32");
		builder.AddAttribute(38, "width", "4");
		builder.AddAttribute(39, "height", "12");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "10");
		builder.AddAttribute(42, "y", "30");
		builder.AddAttribute(43, "width", "4");
		builder.AddAttribute(44, "height", "14");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "4");
		builder.AddAttribute(47, "y", "34");
		builder.AddAttribute(48, "width", "4");
		builder.AddAttribute(49, "height", "10");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(50, "g");
		builder.AddAttribute(51, "fill", "#388E3C");
		builder.OpenElement(52, "polygon");
		builder.AddAttribute(53, "points", "40.1,9.1 34,15.2 30,11.2 20,21.2 15,16.2 4.6,26.6 7.4,29.4 15,21.8 20,26.8 30,16.8 34,20.8 42.9,11.9");
		builder.CloseElement();
		builder.OpenElement(54, "polygon");
		builder.AddAttribute(55, "points", "44,8 35,8 44,17");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
