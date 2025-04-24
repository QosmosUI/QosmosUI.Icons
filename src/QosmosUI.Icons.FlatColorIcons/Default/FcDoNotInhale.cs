// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcDoNotInhale : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FFA726");
		builder.AddAttribute(15, "d", "M33.5,20C31.2,17.7,30,13.9,30,9c0-3.2,0-3,0-3H18c0,0,0-0.2,0,3c0,4.9-1.2,8.7-3.5,11 C12.1,20.2,9,22,9,25.4c0,4.5,5.1,4.6,6,4.6c1.2,0,6.1,4,8,4c0,0,0.7,0,1,0s1,0,1,0c1.9,0,6.8-4,8-4c0.9,0,6-0.1,6-4.6 C39,22,35.9,20.2,33.5,20z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#FFA726");
		builder.AddAttribute(18, "d", "M33.5,20C31.2,17.7,30,13.9,30,9c0-3.2,0-3,0-3H18c0,0,0-0.2,0,3c0,4.9-1.2,8.7-3.5,11 C12.1,20.2,9,22,9,25.4c0,4.5,5.1,4.6,6,4.6c1.2,0,6.1,4,8,4c0,0,0.7,0,1,0s1,0,1,0c1.9,0,6.8-4,8-4c0.9,0,6-0.1,6-4.6 C39,22,35.9,20.2,33.5,20z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#FFB74D");
		builder.AddAttribute(21, "d", "M26,9c0-3.2,0-3,0-3h-4c0,0,0-0.2,0,3c0,4.9-3,19-3,19s1.6,2,5,2s5-2,5-2S26,13.9,26,9z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#CC861E");
		builder.AddAttribute(24, "d", "M23,34c-3.3,0-6.4-3.1-8-4c0,0,0.7,0,1.8,0C19.9,30,21.3,34,23,34z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#CC861E");
		builder.AddAttribute(27, "d", "M25,34c3.3,0,6.4-3.1,8-4c0,0-0.7,0-1.8,0C28.1,30,26.7,34,25,34z");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "22");
		builder.AddAttribute(30, "y", "-2.9");
		builder.AddAttribute(31, "transform", "matrix(.707 -.707 .707 .707 -9.941 24)");
		builder.AddAttribute(32, "fill", "#37474F");
		builder.AddAttribute(33, "width", "4");
		builder.AddAttribute(34, "height", "53.7");
		builder.CloseElement();
		builder.OpenElement(35, "g");
		builder.AddAttribute(36, "fill", "#FF5722");
		builder.OpenElement(37, "polygon");
		builder.AddAttribute(38, "points", "18,35 22,39 14,39");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "17");
		builder.AddAttribute(41, "y", "38");
		builder.AddAttribute(42, "width", "2");
		builder.AddAttribute(43, "height", "4");
		builder.CloseElement();
		builder.OpenElement(44, "polygon");
		builder.AddAttribute(45, "points", "30,35 34,39 26,39");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "29");
		builder.AddAttribute(48, "y", "38");
		builder.AddAttribute(49, "width", "2");
		builder.AddAttribute(50, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
