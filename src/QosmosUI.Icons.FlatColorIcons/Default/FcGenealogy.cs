// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcGenealogy : ComponentBase
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
		builder.AddAttribute(14, "fill", "#CFD8DC");
		builder.AddAttribute(15, "points", "40,9 40,7 31,7 31,12 24,12 15,12 15,23 8,23 8,25 15,25 15,36 24,36 31,36 31,41 40,41 40,39 33,39 33,31 40,31 40,29 31,29 31,34 24,34 17,34 17,14 24,14 31,14 31,19 40,19 40,17 33,17 33,9");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "4");
		builder.AddAttribute(18, "y", "20");
		builder.AddAttribute(19, "fill", "#00BCD4");
		builder.AddAttribute(20, "width", "8");
		builder.AddAttribute(21, "height", "8");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#3F51B5");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "36");
		builder.AddAttribute(26, "y", "14");
		builder.AddAttribute(27, "width", "8");
		builder.AddAttribute(28, "height", "8");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "36");
		builder.AddAttribute(31, "y", "4");
		builder.AddAttribute(32, "width", "8");
		builder.AddAttribute(33, "height", "8");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "20");
		builder.AddAttribute(36, "y", "9");
		builder.AddAttribute(37, "width", "8");
		builder.AddAttribute(38, "height", "8");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "20");
		builder.AddAttribute(41, "y", "31");
		builder.AddAttribute(42, "width", "8");
		builder.AddAttribute(43, "height", "8");
		builder.CloseElement();
		builder.OpenElement(44, "rect");
		builder.AddAttribute(45, "x", "36");
		builder.AddAttribute(46, "y", "36");
		builder.AddAttribute(47, "width", "8");
		builder.AddAttribute(48, "height", "8");
		builder.CloseElement();
		builder.OpenElement(49, "rect");
		builder.AddAttribute(50, "x", "36");
		builder.AddAttribute(51, "y", "26");
		builder.AddAttribute(52, "width", "8");
		builder.AddAttribute(53, "height", "8");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
