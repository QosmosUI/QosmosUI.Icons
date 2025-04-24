// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcNook : ComponentBase
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
		builder.AddAttribute(14, "fill", "#90A4AE");
		builder.AddAttribute(15, "d", "M8,39V9c0-3.3,2.7-6,6-6h20c3.3,0,6,2.7,6,6v30c0,3.3-2.7,6-6,6H14C10.7,45,8,42.3,8,39z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#ECEFF1");
		builder.AddAttribute(18, "d", "M34,7H14c-1.1,0-2,0.9-2,2v26c0,1.1,0.9,2,2,2h20c1.1,0,2-0.9,2-2V9C36,7.9,35.1,7,34,7z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#B0BEC5");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "16");
		builder.AddAttribute(23, "y", "12");
		builder.AddAttribute(24, "width", "16");
		builder.AddAttribute(25, "height", "3");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "x", "16");
		builder.AddAttribute(28, "y", "19");
		builder.AddAttribute(29, "width", "16");
		builder.AddAttribute(30, "height", "2");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "16");
		builder.AddAttribute(33, "y", "23");
		builder.AddAttribute(34, "width", "12");
		builder.AddAttribute(35, "height", "2");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "x", "16");
		builder.AddAttribute(38, "y", "27");
		builder.AddAttribute(39, "width", "16");
		builder.AddAttribute(40, "height", "2");
		builder.CloseElement();
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "x", "16");
		builder.AddAttribute(43, "y", "31");
		builder.AddAttribute(44, "width", "12");
		builder.AddAttribute(45, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "fill", "none");
		builder.AddAttribute(48, "stroke", "#eee");
		builder.AddAttribute(49, "stroke-width", "2");
		builder.AddAttribute(50, "stroke-miterlimit", "10");
		builder.AddAttribute(51, "d", "M22,43v-1c0-1.1,0.9-2,2-2h0c1.1,0,2,0.9,2,2v1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
