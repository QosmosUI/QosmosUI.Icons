// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoSunnySharp : ComponentBase
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
		builder.AddAttribute(14, "x", "234");
		builder.AddAttribute(15, "y", "26");
		builder.AddAttribute(16, "width", "44");
		builder.AddAttribute(17, "height", "92");
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "x", "234");
		builder.AddAttribute(20, "y", "394");
		builder.AddAttribute(21, "width", "44");
		builder.AddAttribute(22, "height", "92");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "340.11");
		builder.AddAttribute(25, "y", "103.89");
		builder.AddAttribute(26, "width", "92");
		builder.AddAttribute(27, "height", "44");
		builder.AddAttribute(28, "transform", "translate(24.07 309.89) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "79.89");
		builder.AddAttribute(31, "y", "364.11");
		builder.AddAttribute(32, "width", "92");
		builder.AddAttribute(33, "height", "44");
		builder.AddAttribute(34, "transform", "translate(-236.14 202.1) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "394");
		builder.AddAttribute(37, "y", "234");
		builder.AddAttribute(38, "width", "92");
		builder.AddAttribute(39, "height", "44");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "26");
		builder.AddAttribute(42, "y", "234");
		builder.AddAttribute(43, "width", "92");
		builder.AddAttribute(44, "height", "44");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "364.11");
		builder.AddAttribute(47, "y", "340.11");
		builder.AddAttribute(48, "width", "44");
		builder.AddAttribute(49, "height", "92");
		builder.AddAttribute(50, "transform", "translate(-159.93 386.11) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(51, "rect");
		builder.AddAttribute(52, "x", "103.89");
		builder.AddAttribute(53, "y", "79.89");
		builder.AddAttribute(54, "width", "44");
		builder.AddAttribute(55, "height", "92");
		builder.AddAttribute(56, "transform", "translate(-52.15 125.89) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(57, "path");
		builder.AddAttribute(58, "d", "M256,358A102,102,0,1,1,358,256,102.12,102.12,0,0,1,256,358Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
