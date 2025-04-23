// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcAssistant : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FFA726");
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "10");
		builder.AddAttribute(17, "cy", "26");
		builder.AddAttribute(18, "r", "4");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "38");
		builder.AddAttribute(21, "cy", "26");
		builder.AddAttribute(22, "r", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "fill", "#FFB74D");
		builder.AddAttribute(25, "d", "M39,19c0-12.7-30-8.3-30,0c0,1.8,0,8.2,0,10c0,8.3,6.7,15,15,15s15-6.7,15-15C39,27.2,39,20.8,39,19z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "fill", "#FF5722");
		builder.AddAttribute(28, "d", "M24,3C14.6,3,7,10.6,7,20c0,1.2,0,3.4,0,3.4L9,25v-3l21-9.8l9,9.8v3l2-1.6c0,0,0-2.1,0-3.4 C41,12,35.3,3,24,3z");
		builder.CloseElement();
		builder.OpenElement(29, "g");
		builder.AddAttribute(30, "fill", "#784719");
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "31");
		builder.AddAttribute(33, "cy", "26");
		builder.AddAttribute(34, "r", "2");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "17");
		builder.AddAttribute(37, "cy", "26");
		builder.AddAttribute(38, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "fill", "#757575");
		builder.AddAttribute(41, "d", "M43,24c-0.6,0-1,0.4-1,1v-7c0-8.8-7.2-16-16-16h-7c-0.6,0-1,0.4-1,1s0.4,1,1,1h7c7.7,0,14,6.3,14,14v10 c0,0.6,0.4,1,1,1s1-0.4,1-1v2c0,3.9-3.1,7-7,7H24c-0.6,0-1,0.4-1,1s0.4,1,1,1h11c5,0,9-4,9-9v-5C44,24.4,43.6,24,43,24z");
		builder.CloseElement();
		builder.OpenElement(42, "g");
		builder.AddAttribute(43, "fill", "#37474F");
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M43,22h-1c-1.1,0-2,0.9-2,2v4c0,1.1,0.9,2,2,2h1c1.1,0,2-0.9,2-2v-4C45,22.9,44.1,22,43,22z");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "24");
		builder.AddAttribute(48, "cy", "38");
		builder.AddAttribute(49, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
