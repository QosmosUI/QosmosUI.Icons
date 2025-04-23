// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcTreeStructure : ComponentBase
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
		builder.AddAttribute(15, "points", "36.9,13.8 35.1,10.2 7.5,24 35.1,37.8 36.9,34.2 16.5,24");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "6");
		builder.AddAttribute(18, "y", "18");
		builder.AddAttribute(19, "fill", "#D81B60");
		builder.AddAttribute(20, "width", "12");
		builder.AddAttribute(21, "height", "12");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#2196F3");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "30");
		builder.AddAttribute(26, "y", "6");
		builder.AddAttribute(27, "width", "12");
		builder.AddAttribute(28, "height", "12");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "30");
		builder.AddAttribute(31, "y", "30");
		builder.AddAttribute(32, "width", "12");
		builder.AddAttribute(33, "height", "12");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
