// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcTemplate : ComponentBase
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
		builder.AddAttribute(15, "y", "7");
		builder.AddAttribute(16, "fill", "#BBDEFB");
		builder.AddAttribute(17, "width", "40");
		builder.AddAttribute(18, "height", "34");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "9");
		builder.AddAttribute(21, "y", "12");
		builder.AddAttribute(22, "fill", "#3F51B5");
		builder.AddAttribute(23, "width", "30");
		builder.AddAttribute(24, "height", "5");
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.AddAttribute(26, "fill", "#2196F3");
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "9");
		builder.AddAttribute(29, "y", "21");
		builder.AddAttribute(30, "width", "13");
		builder.AddAttribute(31, "height", "16");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "26");
		builder.AddAttribute(34, "y", "21");
		builder.AddAttribute(35, "width", "13");
		builder.AddAttribute(36, "height", "16");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
