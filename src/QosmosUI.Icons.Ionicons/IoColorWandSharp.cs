// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoColorWandSharp : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "x", "158.6");
		builder.AddAttribute(15, "y", "150.86");
		builder.AddAttribute(16, "width", "95.03");
		builder.AddAttribute(17, "height", "110.51");
		builder.AddAttribute(18, "transform", "translate(-85.38 206.12) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(19, "polygon");
		builder.AddAttribute(20, "points", "301.41 234.21 234.22 301.41 412 480 480 412 301.41 234.21");
		builder.CloseElement();
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "32");
		builder.AddAttribute(23, "y", "176");
		builder.AddAttribute(24, "width", "80");
		builder.AddAttribute(25, "height", "32");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "x", "91.22");
		builder.AddAttribute(28, "y", "67.22");
		builder.AddAttribute(29, "width", "32");
		builder.AddAttribute(30, "height", "80");
		builder.AddAttribute(31, "transform", "translate(-44.41 107.22) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "176");
		builder.AddAttribute(34, "y", "32");
		builder.AddAttribute(35, "width", "32");
		builder.AddAttribute(36, "height", "80");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "236.92");
		builder.AddAttribute(39, "y", "91.22");
		builder.AddAttribute(40, "width", "80");
		builder.AddAttribute(41, "height", "32");
		builder.AddAttribute(42, "transform", "translate(5.29 227.22) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "x", "67.22");
		builder.AddAttribute(45, "y", "260.92");
		builder.AddAttribute(46, "width", "80");
		builder.AddAttribute(47, "height", "32");
		builder.AddAttribute(48, "transform", "translate(-164.41 156.92) rotate(-45)");
		builder.CloseElement();
		builder.CloseElement();
    }
}
