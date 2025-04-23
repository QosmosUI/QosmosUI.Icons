// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.AntDesignIcons.TwoTone;

public class AiTwoToneTwitch : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 1042 1042";

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
		builder.OpenElement(13, "defs");
		builder.OpenElement(14, "filter");
		builder.AddAttribute(15, "id", "a");
		builder.AddAttribute(16, "width", "102.3%");
		builder.AddAttribute(17, "height", "102.3%");
		builder.AddAttribute(18, "x", "-1.2%");
		builder.AddAttribute(19, "y", "-1.2%");
		builder.AddAttribute(20, "filterUnits", "objectBoundingBox");
		builder.OpenElement(21, "feOffset");
		builder.AddAttribute(22, "dy", "2");
		builder.AddAttribute(23, "in", "SourceAlpha");
		builder.AddAttribute(24, "result", "shadowOffsetOuter1");
		builder.CloseElement();
		builder.OpenElement(25, "feGaussianBlur");
		builder.AddAttribute(26, "in", "shadowOffsetOuter1");
		builder.AddAttribute(27, "result", "shadowBlurOuter1");
		builder.AddAttribute(28, "stdDeviation", "2");
		builder.CloseElement();
		builder.OpenElement(29, "feColorMatrix");
		builder.AddAttribute(30, "in", "shadowBlurOuter1");
		builder.AddAttribute(31, "result", "shadowMatrixOuter1");
		builder.AddAttribute(32, "values", "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0.5 0");
		builder.CloseElement();
		builder.OpenElement(33, "feMerge");
		builder.OpenElement(34, "feMergeNode");
		builder.AddAttribute(35, "in", "shadowMatrixOuter1");
		builder.CloseElement();
		builder.OpenElement(36, "feMergeNode");
		builder.AddAttribute(37, "in", "SourceGraphic");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(38, "g");
		builder.AddAttribute(39, "filter", "url(#a)");
		builder.AddAttribute(40, "transform", "translate(9 9)");
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M57.143 0 0 142.857v542.857h171.429V800h114.285L400 685.714h142.857l200-200V0zm314.286 428.571h-85.715V198.214h85.715zm200 0h-85.715V198.214h85.715z");
		builder.AddAttribute(43, "transform", "translate(128 112)");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
