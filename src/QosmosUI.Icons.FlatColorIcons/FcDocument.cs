// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDocument : ComponentBase
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
		builder.AddAttribute(14, "fill", "#90CAF9");
		builder.AddAttribute(15, "points", "40,45 8,45 8,3 30,3 40,13");
		builder.CloseElement();
		builder.OpenElement(16, "polygon");
		builder.AddAttribute(17, "fill", "#E1F5FE");
		builder.AddAttribute(18, "points", "38.5,14 29,14 29,4.5");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#1976D2");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "16");
		builder.AddAttribute(23, "y", "21");
		builder.AddAttribute(24, "width", "17");
		builder.AddAttribute(25, "height", "2");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "x", "16");
		builder.AddAttribute(28, "y", "25");
		builder.AddAttribute(29, "width", "13");
		builder.AddAttribute(30, "height", "2");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "16");
		builder.AddAttribute(33, "y", "29");
		builder.AddAttribute(34, "width", "17");
		builder.AddAttribute(35, "height", "2");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "x", "16");
		builder.AddAttribute(38, "y", "33");
		builder.AddAttribute(39, "width", "13");
		builder.AddAttribute(40, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
