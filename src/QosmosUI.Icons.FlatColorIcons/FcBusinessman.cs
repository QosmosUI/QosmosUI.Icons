// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcBusinessman : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FF9800");
		builder.AddAttribute(15, "points", "24,37 19,31 19,25 29,25 29,31");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#FFA726");
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "33");
		builder.AddAttribute(20, "cy", "19");
		builder.AddAttribute(21, "r", "2");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "15");
		builder.AddAttribute(24, "cy", "19");
		builder.AddAttribute(25, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "fill", "#FFB74D");
		builder.AddAttribute(28, "d", "M33,13c0-7.6-18-5-18,0c0,1.1,0,5.9,0,7c0,5,4,9,9,9s9-4,9-9C33,18.9,33,14.1,33,13z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "fill", "#424242");
		builder.AddAttribute(31, "d", "M24,4c-6.1,0-10,4.9-10,11c0,0.8,0,2.3,0,2.3l2,1.7v-5l12-4l4,4v5l2-1.7c0,0,0-1.5,0-2.3c0-4-1-8-6-9l-1-2 H24z");
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.AddAttribute(33, "fill", "#784719");
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "28");
		builder.AddAttribute(36, "cy", "19");
		builder.AddAttribute(37, "r", "1");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "20");
		builder.AddAttribute(40, "cy", "19");
		builder.AddAttribute(41, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(42, "polygon");
		builder.AddAttribute(43, "fill", "#fff");
		builder.AddAttribute(44, "points", "24,43 19,31 24,32 29,31");
		builder.CloseElement();
		builder.OpenElement(45, "polygon");
		builder.AddAttribute(46, "fill", "#D32F2F");
		builder.AddAttribute(47, "points", "23,35 22.3,39.5 24,43.5 25.7,39.5 25,35 26,34 24,32 22,34");
		builder.CloseElement();
		builder.OpenElement(48, "path");
		builder.AddAttribute(49, "fill", "#546E7A");
		builder.AddAttribute(50, "d", "M29,31L29,31l-5,12l-5-12c0,0-11,2-11,13h32C40,33,29,31,29,31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
