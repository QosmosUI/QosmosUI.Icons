// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcSelfie : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FFB74D");
		builder.AddAttribute(15, "d", "M32.9,22c0-0.3,0.1-0.7,0.1-1c0-1.1,0-5.9,0-7c0-7.6-18-5-18,0c0,1.1,0,5.9,0,7c0,0.3,0,0.7,0.1,1H32.9z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#37474F");
		builder.AddAttribute(18, "d", "M40,44H8c-2.2,0-4-1.8-4-4V26c0-2.2,1.8-4,4-4h32c2.2,0,4,1.8,4,4v14C44,42.2,42.2,44,40,44z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#BBDEFB");
		builder.AddAttribute(21, "d", "M7,26v14c0,0.6,0.4,1,1,1h29c0.6,0,1-0.4,1-1V26c0-0.6-0.4-1-1-1H8C7.4,25,7,25.4,7,26z");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "x", "40");
		builder.AddAttribute(24, "y", "30");
		builder.AddAttribute(25, "fill", "#78909C");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "height", "6");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "19");
		builder.AddAttribute(30, "y", "32");
		builder.AddAttribute(31, "fill", "#BF360C");
		builder.AddAttribute(32, "width", "8");
		builder.AddAttribute(33, "height", "9");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "20.5");
		builder.AddAttribute(36, "y", "37.5");
		builder.AddAttribute(37, "fill", "#FF9800");
		builder.AddAttribute(38, "width", "5");
		builder.AddAttribute(39, "height", "3.5");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "fill", "#FFB74D");
		builder.AddAttribute(42, "d", "M27.5,32c0-3.8-9-2.5-9,0c0,0.5,0,3,0,3.5c0,2.5,2,4.5,4.5,4.5s4.5-2,4.5-4.5C27.5,35,27.5,32.5,27.5,32z");
		builder.CloseElement();
		builder.OpenElement(43, "g");
		builder.AddAttribute(44, "fill", "#784719");
		builder.OpenElement(45, "circle");
		builder.AddAttribute(46, "cx", "28");
		builder.AddAttribute(47, "cy", "21");
		builder.AddAttribute(48, "r", "1");
		builder.CloseElement();
		builder.OpenElement(49, "circle");
		builder.AddAttribute(50, "cx", "20");
		builder.AddAttribute(51, "cy", "21");
		builder.AddAttribute(52, "r", "1");
		builder.CloseElement();
		builder.OpenElement(53, "circle");
		builder.AddAttribute(54, "cx", "25");
		builder.AddAttribute(55, "cy", "35.5");
		builder.AddAttribute(56, "r", ".5");
		builder.CloseElement();
		builder.OpenElement(57, "circle");
		builder.AddAttribute(58, "cx", "21");
		builder.AddAttribute(59, "cy", "35.5");
		builder.AddAttribute(60, "r", ".5");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(61, "g");
		builder.AddAttribute(62, "fill", "#FF5722");
		builder.OpenElement(63, "path");
		builder.AddAttribute(64, "d", "M23,27c-3,0-8,1.3-8,11l4,3v-6.5l6-3.5l2,2.5V41l4-3c0-2-0.8-10-6-10l-0.5-1H23z");
		builder.CloseElement();
		builder.OpenElement(65, "path");
		builder.AddAttribute(66, "d", "M16,22v-3l12-7l4,5v5h6.8C38.3,15.8,36.1,6,28,6l-1-2h-3C18.5,4,10.7,6.8,9.2,22H16z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
