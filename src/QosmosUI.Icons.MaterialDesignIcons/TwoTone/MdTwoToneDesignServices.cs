// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDesignServices : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "points", "15.91,9.28 14.61,7.98 5,17.59 5,19 6.41,19 16.02,9.39");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "opacity", ".3");
		builder.AddAttribute(26, "points", "10.83,8.93 9.63,7.73 8.44,8.92 7.02,7.5 8.21,6.32 6.94,5.04 6.94,5.04 5.04,6.94 8.93,10.83");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "opacity", ".3");
		builder.AddAttribute(29, "points", "16.27,14.38 15.07,13.17 13.17,15.07 17.06,18.96 18.96,17.06 17.69,15.79 16.5,16.98 15.08,15.57");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "2");
		builder.AddAttribute(32, "opacity", ".3");
		builder.AddAttribute(33, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 0.4645 14.2513)");
		builder.AddAttribute(34, "width", "2");
		builder.AddAttribute(35, "x", "16.44");
		builder.AddAttribute(36, "y", "5.56");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M20.97,5.86l-2.83-2.83c-0.39-0.39-1.02-0.39-1.41,0l-4.49,4.49L8.35,3.63c-0.78-0.78-2.05-0.78-2.83,0l-1.9,1.9 c-0.78,0.78-0.78,2.05,0,2.83l3.89,3.89L3,16.76V21h4.24l4.52-4.52l3.89,3.89c0.95,0.95,2.23,0.6,2.83,0l1.9-1.9 c0.78-0.78,0.78-2.05,0-2.83l-3.89-3.89l4.49-4.49C21.36,6.88,21.36,6.25,20.97,5.86z M5.04,6.94l1.89-1.9c0,0,0,0,0,0l1.27,1.27 L7.02,7.5l1.41,1.41l1.19-1.19l1.2,1.2l-1.9,1.9L5.04,6.94z M6.41,19H5v-1.41l9.61-9.61l1.3,1.3l0.11,0.11L6.41,19z M16.5,16.98 l1.19-1.19l1.27,1.27l-1.9,1.9l-3.89-3.89l1.9-1.9l1.2,1.2l-1.19,1.19L16.5,16.98z M17.44,7.98l-1.41-1.41l1.41-1.41l1.41,1.41 L17.44,7.98z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
