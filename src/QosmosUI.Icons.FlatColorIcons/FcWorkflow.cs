// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcWorkflow : ComponentBase
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
		builder.AddAttribute(14, "x", "7");
		builder.AddAttribute(15, "y", "31");
		builder.AddAttribute(16, "fill", "#00BCD4");
		builder.AddAttribute(17, "width", "10");
		builder.AddAttribute(18, "height", "10");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#00BCD4");
		builder.AddAttribute(21, "d", "M35.3,19.3l-5.6-5.6c-0.4-0.4-0.4-1,0-1.4l5.6-5.6c0.4-0.4,1-0.4,1.4,0l5.6,5.6c0.4,0.4,0.4,1,0,1.4 l-5.6,5.6C36.3,19.7,35.7,19.7,35.3,19.3z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "fill", "#3F51B5");
		builder.AddAttribute(24, "cx", "12");
		builder.AddAttribute(25, "cy", "13");
		builder.AddAttribute(26, "r", "6");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "fill", "#448AFF");
		builder.AddAttribute(29, "cx", "36");
		builder.AddAttribute(30, "cy", "36");
		builder.AddAttribute(31, "r", "6");
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.AddAttribute(33, "fill", "#90A4AE");
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "11");
		builder.AddAttribute(36, "y", "24");
		builder.AddAttribute(37, "width", "2");
		builder.AddAttribute(38, "height", "5");
		builder.CloseElement();
		builder.OpenElement(39, "polygon");
		builder.AddAttribute(40, "points", "12,21 9,25 15,25");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(41, "g");
		builder.AddAttribute(42, "fill", "#90A4AE");
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "x", "20");
		builder.AddAttribute(45, "y", "12");
		builder.AddAttribute(46, "width", "5");
		builder.AddAttribute(47, "height", "2");
		builder.CloseElement();
		builder.OpenElement(48, "polygon");
		builder.AddAttribute(49, "points", "28,13 24,10 24,16");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(50, "g");
		builder.AddAttribute(51, "fill", "#90A4AE");
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "x", "35");
		builder.AddAttribute(54, "y", "21");
		builder.AddAttribute(55, "width", "2");
		builder.AddAttribute(56, "height", "5");
		builder.CloseElement();
		builder.OpenElement(57, "polygon");
		builder.AddAttribute(58, "points", "36,29 39,25 33,25");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
