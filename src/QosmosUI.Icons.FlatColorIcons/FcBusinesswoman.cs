// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcBusinesswoman : ComponentBase
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
		builder.AddAttribute(14, "x", "16");
		builder.AddAttribute(15, "y", "15");
		builder.AddAttribute(16, "fill", "#BF360C");
		builder.AddAttribute(17, "width", "16");
		builder.AddAttribute(18, "height", "18");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#78909C");
		builder.AddAttribute(21, "d", "M40,44H8c0-11,11-13,11-13h10C29,31,40,33,40,44z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#FF9800");
		builder.AddAttribute(24, "d", "M24,37c-2.2,0-5-6-5-6v-6h10v6C29,31,26.2,37,24,37z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#FFB74D");
		builder.AddAttribute(27, "d", "M33,14c0-7.6-18-5-18,0c0,1.1,0,5.9,0,7c0,5,4,9,9,9s9-4,9-9C33,19.9,33,15.1,33,14z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#FF5722");
		builder.AddAttribute(30, "d", "M24,4C17.9,4,9,7.4,9,27.3l7,4.7V19l12-7l4,5v15l7-6c0-4-0.7-20-11-20l-1-2H24z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "fill", "#FFB74D");
		builder.AddAttribute(33, "d", "M24,38c-4.4,0-5-7-5-7s2.5,4,5,4s5-4,5-4S28.4,38,24,38z");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "fill", "#784719");
		builder.AddAttribute(36, "cx", "28");
		builder.AddAttribute(37, "cy", "21");
		builder.AddAttribute(38, "r", "1");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "fill", "#784719");
		builder.AddAttribute(41, "cx", "20");
		builder.AddAttribute(42, "cy", "21");
		builder.AddAttribute(43, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
