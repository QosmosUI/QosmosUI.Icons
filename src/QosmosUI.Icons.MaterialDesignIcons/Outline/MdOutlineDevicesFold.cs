// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineDevicesFold : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M20,3h-3c0-1.44-1.47-2.4-2.79-1.84l-3,1.29C10.48,2.76,10,3.49,10,4.29V19c0,1.1,0.9,2,2,2h8c1.1,0,2-0.9,2-2V5 C22,3.9,21.1,3,20,3z M15,16.68l-3,1.29V4.29L15,3V16.68z M20,19h-5.33l1.12-0.48C16.52,18.2,17,17.48,17,16.68V5h3V19z");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "height", "2");
		builder.AddAttribute(25, "width", "2");
		builder.AddAttribute(26, "x", "2");
		builder.AddAttribute(27, "y", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(28, "g");
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "2");
		builder.AddAttribute(31, "width", "2");
		builder.AddAttribute(32, "x", "2");
		builder.AddAttribute(33, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(34, "g");
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "height", "2");
		builder.AddAttribute(37, "width", "2");
		builder.AddAttribute(38, "x", "2");
		builder.AddAttribute(39, "y", "15");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(40, "g");
		builder.OpenElement(41, "rect");
		builder.AddAttribute(42, "height", "2");
		builder.AddAttribute(43, "width", "2");
		builder.AddAttribute(44, "x", "2");
		builder.AddAttribute(45, "y", "11");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(46, "g");
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "height", "2");
		builder.AddAttribute(49, "width", "2");
		builder.AddAttribute(50, "x", "2");
		builder.AddAttribute(51, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(52, "g");
		builder.OpenElement(53, "rect");
		builder.AddAttribute(54, "height", "2");
		builder.AddAttribute(55, "width", "2");
		builder.AddAttribute(56, "x", "6");
		builder.AddAttribute(57, "y", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(58, "g");
		builder.OpenElement(59, "rect");
		builder.AddAttribute(60, "height", "2");
		builder.AddAttribute(61, "width", "2");
		builder.AddAttribute(62, "x", "6");
		builder.AddAttribute(63, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
