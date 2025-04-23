// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcMindMap : ComponentBase
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
		builder.AddAttribute(15, "points", "39.4,23 38.6,19 26,21.6 26,8 22,8 22,20.3 8.1,11.3 5.9,14.7 21.1,24.5 9.4,39.8 12.6,42.2 23.9,27.4 32.3,40.1 35.7,37.9 27.3,25.4");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "fill", "#3F51B5");
		builder.AddAttribute(18, "cx", "24");
		builder.AddAttribute(19, "cy", "24");
		builder.AddAttribute(20, "r", "7");
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.AddAttribute(22, "fill", "#00BCD4");
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "24");
		builder.AddAttribute(25, "cy", "8");
		builder.AddAttribute(26, "r", "5");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "39");
		builder.AddAttribute(29, "cy", "21");
		builder.AddAttribute(30, "r", "5");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "7");
		builder.AddAttribute(33, "cy", "13");
		builder.AddAttribute(34, "r", "5");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "11");
		builder.AddAttribute(37, "cy", "41");
		builder.AddAttribute(38, "r", "5");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "cx", "34");
		builder.AddAttribute(41, "cy", "39");
		builder.AddAttribute(42, "r", "5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
