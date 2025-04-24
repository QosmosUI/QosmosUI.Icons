// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcCamcorder : ComponentBase
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
		builder.AddAttribute(14, "fill", "#607D8B");
		builder.AddAttribute(15, "d", "M20,42H10c-2.2,0-4-1.8-4-4V15c0-5,4-9,9-9h0c5,0,9,4,9,9v23C24,40.2,22.2,42,20,42z");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "fill", "#455A64");
		builder.AddAttribute(18, "cx", "15");
		builder.AddAttribute(19, "cy", "15");
		builder.AddAttribute(20, "r", "7");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "fill", "#42A5F5");
		builder.AddAttribute(23, "cx", "15");
		builder.AddAttribute(24, "cy", "15");
		builder.AddAttribute(25, "r", "5.2");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "fill", "#90CAF9");
		builder.AddAttribute(28, "d", "M18.3,13c-0.8-0.9-2-1.5-3.3-1.5S12.6,12,11.7,13c-0.3,0.4-0.3,0.9,0.1,1.2c0.4,0.3,0.9,0.3,1.2-0.1 c1-1.2,2.9-1.2,3.9,0c0.2,0.2,0.4,0.3,0.7,0.3c0.2,0,0.4-0.1,0.6-0.2C18.6,13.9,18.6,13.3,18.3,13z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "fill", "#607D8B");
		builder.AddAttribute(31, "d", "M40,31H28c-1.1,0-2-0.9-2-2V19c0-1.1,0.9-2,2-2h12c1.1,0,2,0.9,2,2v10C42,30.1,41.1,31,40,31z");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "24");
		builder.AddAttribute(34, "y", "19");
		builder.AddAttribute(35, "fill", "#455A64");
		builder.AddAttribute(36, "width", "2");
		builder.AddAttribute(37, "height", "10");
		builder.CloseElement();
		builder.OpenElement(38, "rect");
		builder.AddAttribute(39, "x", "28");
		builder.AddAttribute(40, "y", "19");
		builder.AddAttribute(41, "fill", "#03A9F4");
		builder.AddAttribute(42, "width", "12");
		builder.AddAttribute(43, "height", "10");
		builder.CloseElement();
		builder.OpenElement(44, "polygon");
		builder.AddAttribute(45, "fill", "#4FC3F7");
		builder.AddAttribute(46, "points", "33,22.2 29,28 37,28");
		builder.CloseElement();
		builder.OpenElement(47, "g");
		builder.AddAttribute(48, "fill", "#B3E5FC");
		builder.OpenElement(49, "circle");
		builder.AddAttribute(50, "cx", "37.5");
		builder.AddAttribute(51, "cy", "21.5");
		builder.AddAttribute(52, "r", "1");
		builder.CloseElement();
		builder.OpenElement(53, "polygon");
		builder.AddAttribute(54, "points", "36,24.2 33,28 39,28");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(55, "circle");
		builder.AddAttribute(56, "fill", "#455A64");
		builder.AddAttribute(57, "cx", "15");
		builder.AddAttribute(58, "cy", "35");
		builder.AddAttribute(59, "r", "3");
		builder.CloseElement();
		builder.OpenElement(60, "circle");
		builder.AddAttribute(61, "fill", "#F44336");
		builder.AddAttribute(62, "cx", "15");
		builder.AddAttribute(63, "cy", "35");
		builder.AddAttribute(64, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
