// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEdgesensorLow : ComponentBase
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
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "height", "1");
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "width", "8");
		builder.AddAttribute(23, "x", "8");
		builder.AddAttribute(24, "y", "4");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "1");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "width", "8");
		builder.AddAttribute(29, "x", "8");
		builder.AddAttribute(30, "y", "19");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "height", "7");
		builder.AddAttribute(33, "width", "2");
		builder.AddAttribute(34, "x", "20");
		builder.AddAttribute(35, "y", "10");
		builder.CloseElement();
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "height", "7");
		builder.AddAttribute(38, "width", "2");
		builder.AddAttribute(39, "x", "2");
		builder.AddAttribute(40, "y", "7");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M16,2.01L8,2C6.9,2,6,2.9,6,4v16c0,1.1,0.9,2,2,2h8c1.1,0,2-0.9,2-2V4C18,2.9,17.1,2.01,16,2.01z M16,20H8v-1h8V20z M16,17H8V7h8V17z M16,5H8V4h8V5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
