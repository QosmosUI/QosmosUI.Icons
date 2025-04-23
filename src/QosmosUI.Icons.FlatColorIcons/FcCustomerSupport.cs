// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCustomerSupport : ComponentBase
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
		builder.AddAttribute(15, "d", "M29,43v-4.6l2.6,0.5c2.9,0.6,5.6-1.5,5.8-4.4L38,28l2.9-1.2c1-0.4,1.4-1.6,0.8-2.6L38,18 c-0.6-7.6-4.9-15-16-15C10.6,3,5,11.4,5,20c0,3.7,1.3,6.9,3.3,9.6c1.8,2.5,2.7,5.5,2.7,8.5l0,4.8H29z");
		builder.CloseElement();
		builder.OpenElement(16, "polygon");
		builder.AddAttribute(17, "fill", "#FF9800");
		builder.AddAttribute(18, "points", "29,43 29,38.4 22,37 22,43");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#784719");
		builder.AddAttribute(21, "cx", "33.5");
		builder.AddAttribute(22, "cy", "21.5");
		builder.AddAttribute(23, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "fill", "#FF5722");
		builder.AddAttribute(26, "d", "M21.4,3C12.3,3,5,10.3,5,19.4c0,11.1,6,11.4,6,18.6l2.6-0.9c2.1-0.7,3.9-2.3,4.7-4.4l2.8-6.8L27,23v-6 c0,0,7-3.8,7-10.3C31,4.2,25.7,3,21.4,3z");
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.AddAttribute(28, "fill", "#546E7A");
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M21,2.1c-0.6,0-1,0.4-1,1v13.9c0,0.6,0.4,1,1,1s1-0.4,1-1V3.1C22,2.5,21.6,2.1,21,2.1z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M36.9,31.9c-7.9,0-10.3-4.9-10.4-5.1c-0.2-0.5-0.8-0.7-1.3-0.5c-0.5,0.2-0.7,0.8-0.5,1.3 c0.1,0.3,3,6.3,12.2,6.3c0.6,0,1-0.4,1-1S37.4,31.9,36.9,31.9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "fill", "#37474F");
		builder.AddAttribute(35, "cx", "37");
		builder.AddAttribute(36, "cy", "33");
		builder.AddAttribute(37, "r", "2");
		builder.CloseElement();
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "fill", "#37474F");
		builder.AddAttribute(40, "cx", "21");
		builder.AddAttribute(41, "cy", "23");
		builder.AddAttribute(42, "r", "7");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "fill", "#546E7A");
		builder.AddAttribute(45, "cx", "21");
		builder.AddAttribute(46, "cy", "23");
		builder.AddAttribute(47, "r", "4");
		builder.CloseElement();
		builder.CloseElement();
    }
}
