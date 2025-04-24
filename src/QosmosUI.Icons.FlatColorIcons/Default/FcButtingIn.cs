// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcButtingIn : ComponentBase
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
		builder.AddAttribute(14, "fill", "#CFD8DC");
		builder.AddAttribute(15, "d", "M24,3C12.4,3,3,12.4,3,24c0,11.6,9.4,21,21,21c0.3,0,0.7,0,1-0.1V3.1C24.7,3,24.3,3,24,3z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#37474F");
		builder.AddAttribute(18, "d", "M25,3.1v41.9c4.1-0.2,7.9-1.5,11-3.7V6.8C32.9,4.6,29.1,3.2,25,3.1z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#FFB74D");
		builder.AddAttribute(21, "d", "M20.5,13C14.1,13.3,8.9,18.7,9,25.1c0,2.8,1,5.4,2.7,7.5c1.4,1.7,2.3,3.9,2.3,6.1v3.8c3,1.6,6.4,2.5,10,2.5 c0.3,0,0.7,0,1-0.1c0.7,0,1.3-0.1,2-0.2v-9.4c3.6-2.1,6-5.9,6-10.4C33,18.2,27.4,12.7,20.5,13z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#FFB74D");
		builder.AddAttribute(24, "d", "M29,38.6L25,38v-9h8l-0.7,7C32.1,37.6,30.7,38.8,29,38.6z");
		builder.CloseElement();
		builder.OpenElement(25, "polygon");
		builder.AddAttribute(26, "fill", "#FFB74D");
		builder.AddAttribute(27, "points", "39,29 32,31 31,26 32,22");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "fill", "#784719");
		builder.AddAttribute(30, "cx", "29.5");
		builder.AddAttribute(31, "cy", "25.5");
		builder.AddAttribute(32, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "fill", "#FF5722");
		builder.AddAttribute(35, "d", "M21,12c-7.2,0-13,5.8-13,13c0,7.6,5.1,9,6,13l4-3v-8l5-2l1-4c3.2,0,6-3.9,6-6.1C27.9,13,24.4,12,21,12z");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "fill", "#FFB74D");
		builder.AddAttribute(38, "cx", "19");
		builder.AddAttribute(39, "cy", "27");
		builder.AddAttribute(40, "r", "3");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "fill", "#CFD8DC");
		builder.AddAttribute(43, "d", "M45,24c0-7.1-3.6-13.4-9-17.2v34.4C41.4,37.4,45,31.1,45,24z");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "fill", "#FF9800");
		builder.AddAttribute(46, "d", "M20,44.6c1.3,0.2,2.6,0.4,4,0.4c0.3,0,0.7,0,1-0.1c0.7,0,1.3-0.1,2-0.2v-6.5l-7-1V44.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
