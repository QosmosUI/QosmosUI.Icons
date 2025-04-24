// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcHeatMap : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#CFD8DC");
		builder.AddAttribute(15, "points", "9,39 9,6 7,6 7,41 42,41 42,39");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#00BCD4");
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "14");
		builder.AddAttribute(20, "cy", "11");
		builder.AddAttribute(21, "r", "2");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "32");
		builder.AddAttribute(24, "cy", "11");
		builder.AddAttribute(25, "r", "2");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "39");
		builder.AddAttribute(28, "cy", "11");
		builder.AddAttribute(29, "r", "2");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "23");
		builder.AddAttribute(32, "cy", "11");
		builder.AddAttribute(33, "r", "4");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "14");
		builder.AddAttribute(36, "cy", "33");
		builder.AddAttribute(37, "r", "2");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "30");
		builder.AddAttribute(40, "cy", "33");
		builder.AddAttribute(41, "r", "2");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "22");
		builder.AddAttribute(44, "cy", "33");
		builder.AddAttribute(45, "r", "3");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "38");
		builder.AddAttribute(48, "cy", "33");
		builder.AddAttribute(49, "r", "4");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "14");
		builder.AddAttribute(52, "cy", "22");
		builder.AddAttribute(53, "r", "2");
		builder.CloseElement();
		builder.OpenElement(54, "circle");
		builder.AddAttribute(55, "cx", "39");
		builder.AddAttribute(56, "cy", "22");
		builder.AddAttribute(57, "r", "2");
		builder.CloseElement();
		builder.OpenElement(58, "circle");
		builder.AddAttribute(59, "cx", "32");
		builder.AddAttribute(60, "cy", "22");
		builder.AddAttribute(61, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
