// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpShower : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "8");
		builder.AddAttribute(20, "cy", "17");
		builder.AddAttribute(21, "r", "1");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "12");
		builder.AddAttribute(24, "cy", "17");
		builder.AddAttribute(25, "r", "1");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "16");
		builder.AddAttribute(28, "cy", "17");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M13,5.08V3h-2v2.08C7.61,5.57,5,8.47,5,12v2h14v-2C19,8.47,16.39,5.57,13,5.08z");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "8");
		builder.AddAttribute(34, "cy", "20");
		builder.AddAttribute(35, "r", "1");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "12");
		builder.AddAttribute(38, "cy", "20");
		builder.AddAttribute(39, "r", "1");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "16");
		builder.AddAttribute(42, "cy", "20");
		builder.AddAttribute(43, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
