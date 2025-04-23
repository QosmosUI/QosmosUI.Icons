// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcUpload : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#009688");
		builder.OpenElement(15, "polygon");
		builder.AddAttribute(16, "points", "24,10.9 35,24 13,24");
		builder.CloseElement();
		builder.OpenElement(17, "rect");
		builder.AddAttribute(18, "x", "20");
		builder.AddAttribute(19, "y", "40");
		builder.AddAttribute(20, "width", "8");
		builder.AddAttribute(21, "height", "4");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "x", "20");
		builder.AddAttribute(24, "y", "34");
		builder.AddAttribute(25, "width", "8");
		builder.AddAttribute(26, "height", "4");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "20");
		builder.AddAttribute(29, "y", "21");
		builder.AddAttribute(30, "width", "8");
		builder.AddAttribute(31, "height", "11");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "6");
		builder.AddAttribute(34, "y", "4");
		builder.AddAttribute(35, "width", "36");
		builder.AddAttribute(36, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
