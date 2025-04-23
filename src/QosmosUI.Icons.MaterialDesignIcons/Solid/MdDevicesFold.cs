// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdDevicesFold : ComponentBase
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
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M20,3h-3c0-1.43-1.47-2.4-2.79-1.84l-3,1.29C10.48,2.76,10,3.49,10,4.29V19c0,1.1,0.9,2,2,2h8c1.1,0,2-0.9,2-2V5 C22,3.9,21.1,3,20,3z M20,19h-5.33l1.12-0.48C16.52,18.2,17,17.48,17,16.68V5h3V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "2");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "x", "2");
		builder.AddAttribute(28, "y", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(29, "g");
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "2");
		builder.AddAttribute(32, "width", "2");
		builder.AddAttribute(33, "x", "2");
		builder.AddAttribute(34, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(35, "g");
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "height", "2");
		builder.AddAttribute(38, "width", "2");
		builder.AddAttribute(39, "x", "2");
		builder.AddAttribute(40, "y", "15");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(41, "g");
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "height", "2");
		builder.AddAttribute(44, "width", "2");
		builder.AddAttribute(45, "x", "2");
		builder.AddAttribute(46, "y", "11");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(47, "g");
		builder.OpenElement(48, "rect");
		builder.AddAttribute(49, "height", "2");
		builder.AddAttribute(50, "width", "2");
		builder.AddAttribute(51, "x", "2");
		builder.AddAttribute(52, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(53, "g");
		builder.OpenElement(54, "rect");
		builder.AddAttribute(55, "height", "2");
		builder.AddAttribute(56, "width", "2");
		builder.AddAttribute(57, "x", "6");
		builder.AddAttribute(58, "y", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(59, "g");
		builder.OpenElement(60, "rect");
		builder.AddAttribute(61, "height", "2");
		builder.AddAttribute(62, "width", "2");
		builder.AddAttribute(63, "x", "6");
		builder.AddAttribute(64, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
