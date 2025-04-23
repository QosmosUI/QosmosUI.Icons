// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDiploma1 : ComponentBase
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
		builder.AddAttribute(14, "x", "4");
		builder.AddAttribute(15, "y", "9");
		builder.AddAttribute(16, "fill", "#E8EAF6");
		builder.AddAttribute(17, "width", "40");
		builder.AddAttribute(18, "height", "30");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#5C6BC0");
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "30,34 32.8,34 27.8,29 25,31.8 30,36.8");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "18,34 15.2,34 20.2,29 23,31.8 18,36.8");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "11");
		builder.AddAttribute(27, "y", "15");
		builder.AddAttribute(28, "fill", "#9FA8DA");
		builder.AddAttribute(29, "width", "26");
		builder.AddAttribute(30, "height", "4");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "fill", "#9FA8DA");
		builder.AddAttribute(33, "d", "M24,23c-2.8,0-5,2.2-5,5s2.2,5,5,5s5-2.2,5-5S26.8,23,24,23z M24,31c-1.7,0-3-1.3-3-3s1.3-3,3-3s3,1.3,3,3 S25.7,31,24,31z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "fill", "#9FA8DA");
		builder.AddAttribute(36, "d", "M3,8v32h42V8H3z M43,35c-1.7,0-3,1.3-3,3H8c0-1.7-1.3-3-3-3V13c1.7,0,3-1.3,3-3h32c0,1.7,1.3,3,3,3V35z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
