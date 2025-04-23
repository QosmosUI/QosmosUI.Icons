// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpWindPower : ComponentBase
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
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "height", "2");
		builder.AddAttribute(23, "width", "6");
		builder.AddAttribute(24, "x", "4");
		builder.AddAttribute(25, "y", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "2");
		builder.AddAttribute(29, "width", "5");
		builder.AddAttribute(30, "x", "1");
		builder.AddAttribute(31, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "2");
		builder.AddAttribute(35, "width", "5");
		builder.AddAttribute(36, "x", "3");
		builder.AddAttribute(37, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(38, "g");
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M15.32,12.09l5.42-9.04L17.32,1L12,5.97v4.74c0.31-0.13,0.64-0.21,1-0.21C14.06,10.5,14.96,11.16,15.32,12.09z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(41, "g");
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M10.5,13c0-0.82,0.4-1.54,1.01-2H1v4l7,2l3.44-2.06C10.87,14.48,10.5,13.79,10.5,13z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(44, "g");
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M20.17,23L23,20.17l-3.54-6.36l-3.98-1c0,0.06,0.02,0.12,0.02,0.19c0,1.38-1.12,2.5-2.5,2.5c-0.36,0-0.69-0.08-1-0.21V21 c-1.1,0-2,0.9-2,2h6c0-1.1-0.9-2-2-2v-4.17L20.17,23z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(47, "g");
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "13");
		builder.AddAttribute(50, "cy", "13");
		builder.AddAttribute(51, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
