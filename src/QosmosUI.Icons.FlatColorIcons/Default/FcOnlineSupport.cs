// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcOnlineSupport : ComponentBase
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
		builder.AddAttribute(14, "x", "13");
		builder.AddAttribute(15, "y", "30");
		builder.AddAttribute(16, "fill", "#BF360C");
		builder.AddAttribute(17, "width", "22");
		builder.AddAttribute(18, "height", "12");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#FFA726");
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "10");
		builder.AddAttribute(23, "cy", "26");
		builder.AddAttribute(24, "r", "4");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "38");
		builder.AddAttribute(27, "cy", "26");
		builder.AddAttribute(28, "r", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "fill", "#FFB74D");
		builder.AddAttribute(31, "d", "M39,19c0-12.7-30-8.3-30,0c0,1.8,0,8.2,0,10c0,8.3,6.7,15,15,15s15-6.7,15-15C39,27.2,39,20.8,39,19z");
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.AddAttribute(33, "fill", "#784719");
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "30");
		builder.AddAttribute(36, "cy", "26");
		builder.AddAttribute(37, "r", "2");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "18");
		builder.AddAttribute(40, "cy", "26");
		builder.AddAttribute(41, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "fill", "#FF5722");
		builder.AddAttribute(44, "d", "M24,2C15.5,2,3,7.8,3,35.6L13,42V24l16.8-9.8L35,21v21l10-8.2c0-5.6-0.9-29-15.4-29L28.2,2H24z");
		builder.CloseElement();
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "fill", "#757575");
		builder.AddAttribute(47, "d", "M45,24c-0.6,0-1,0.4-1,1v-7c0-8.8-7.2-16-16-16h-9c-0.6,0-1,0.4-1,1s0.4,1,1,1h9c7.7,0,14,6.3,14,14v10 c0,0.6,0.4,1,1,1s1-0.4,1-1v2c0,3.9-3.1,7-7,7H24c-0.6,0-1,0.4-1,1s0.4,1,1,1h13c5,0,9-4,9-9v-5C46,24.4,45.6,24,45,24z");
		builder.CloseElement();
		builder.OpenElement(48, "g");
		builder.AddAttribute(49, "fill", "#37474F");
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M45,22h-1c-1.1,0-2,0.9-2,2v4c0,1.1,0.9,2,2,2h1c1.1,0,2-0.9,2-2v-4C47,22.9,46.1,22,45,22z");
		builder.CloseElement();
		builder.OpenElement(52, "circle");
		builder.AddAttribute(53, "cx", "24");
		builder.AddAttribute(54, "cy", "38");
		builder.AddAttribute(55, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
