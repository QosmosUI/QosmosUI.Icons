// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDevicesFold : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M20,3h-3c0-1.43-1.47-2.4-2.79-1.84l-3,1.29C10.48,2.76,10,3.49,10,4.29V19c0,1.1,0.9,2,2,2h8c1.1,0,2-0.9,2-2V5 C22,3.9,21.1,3,20,3z M20,19h-5.33l1.12-0.48C16.52,18.2,17,17.48,17,16.68V5h3V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "height", "2");
		builder.AddAttribute(30, "width", "2");
		builder.AddAttribute(31, "x", "2");
		builder.AddAttribute(32, "y", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(33, "g");
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "height", "2");
		builder.AddAttribute(36, "width", "2");
		builder.AddAttribute(37, "x", "2");
		builder.AddAttribute(38, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(39, "g");
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "height", "2");
		builder.AddAttribute(42, "width", "2");
		builder.AddAttribute(43, "x", "2");
		builder.AddAttribute(44, "y", "15");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(45, "g");
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "height", "2");
		builder.AddAttribute(48, "width", "2");
		builder.AddAttribute(49, "x", "2");
		builder.AddAttribute(50, "y", "11");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(51, "g");
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "height", "2");
		builder.AddAttribute(54, "width", "2");
		builder.AddAttribute(55, "x", "2");
		builder.AddAttribute(56, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(57, "g");
		builder.OpenElement(58, "rect");
		builder.AddAttribute(59, "height", "2");
		builder.AddAttribute(60, "width", "2");
		builder.AddAttribute(61, "x", "6");
		builder.AddAttribute(62, "y", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(63, "g");
		builder.OpenElement(64, "rect");
		builder.AddAttribute(65, "height", "2");
		builder.AddAttribute(66, "width", "2");
		builder.AddAttribute(67, "x", "6");
		builder.AddAttribute(68, "y", "19");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
