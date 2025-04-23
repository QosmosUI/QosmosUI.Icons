// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcAudioFile : ComponentBase
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
		builder.AddAttribute(14, "x", "204");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "width", "48");
		builder.AddAttribute(17, "height", "48");
		builder.CloseElement();
		builder.OpenElement(18, "polygon");
		builder.AddAttribute(19, "fill", "#90CAF9");
		builder.AddAttribute(20, "points", "244,45 212,45 212,3 234,3 244,13");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "fill", "#E1F5FE");
		builder.AddAttribute(23, "points", "242.5,14 233,14 233,4.5");
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.AddAttribute(25, "fill", "#1976D2");
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "227");
		builder.AddAttribute(28, "cy", "30");
		builder.AddAttribute(29, "r", "4");
		builder.CloseElement();
		builder.OpenElement(30, "polygon");
		builder.AddAttribute(31, "points", "234,21 229,19 229,30 231,30 231,22.9 234,24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "polygon");
		builder.AddAttribute(33, "fill", "#90CAF9");
		builder.AddAttribute(34, "points", "40,45 8,45 8,3 30,3 40,13");
		builder.CloseElement();
		builder.OpenElement(35, "polygon");
		builder.AddAttribute(36, "fill", "#E1F5FE");
		builder.AddAttribute(37, "points", "38.5,14 29,14 29,4.5");
		builder.CloseElement();
		builder.OpenElement(38, "g");
		builder.AddAttribute(39, "fill", "#1976D2");
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "23");
		builder.AddAttribute(42, "cy", "30");
		builder.AddAttribute(43, "r", "4");
		builder.CloseElement();
		builder.OpenElement(44, "polygon");
		builder.AddAttribute(45, "points", "30,21 25,19 25,30 27,30 27,22.9 30,24");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
