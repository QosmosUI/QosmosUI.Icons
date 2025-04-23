// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCallTransfer : ComponentBase
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
		builder.AddAttribute(14, "fill", "#009688");
		builder.AddAttribute(15, "d", "M39.2,8.4l-1.8,1.8c-6.3,6.5-5.4,22,0,27.6l1.8,1.8c0.5,0.5,1.3,0.5,1.8,0l3.6-3.7c0.5-0.5,0.5-1.3,0-1.8 l-3.4-3.4h-4.8c-1.3-1.3-1.3-12.1,0-13.4h4.8l3.3-3.4c0.5-0.5,0.5-1.3,0-1.8L41,8.4C40.5,7.9,39.7,7.9,39.2,8.4z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#009688");
		builder.AddAttribute(18, "d", "M11.2,8.4l-1.8,1.8c-6.3,6.5-5.4,22,0,27.6l1.8,1.8c0.5,0.5,1.3,0.5,1.8,0l3.6-3.7c0.5-0.5,0.5-1.3,0-1.8 l-3.4-3.4H8.5c-1.3-1.3-1.3-12.1,0-13.4h4.8l3.3-3.4c0.5-0.5,0.5-1.3,0-1.8L13,8.4C12.5,7.9,11.7,7.9,11.2,8.4z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#2196F3");
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "25.3,18.6 30.7,24 25.3,29.4");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "16");
		builder.AddAttribute(25, "y", "22");
		builder.AddAttribute(26, "width", "11");
		builder.AddAttribute(27, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
