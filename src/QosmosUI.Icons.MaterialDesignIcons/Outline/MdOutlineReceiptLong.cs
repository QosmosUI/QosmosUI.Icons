// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineReceiptLong : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M19.5,3.5L18,2l-1.5,1.5L15,2l-1.5,1.5L12,2l-1.5,1.5L9,2L7.5,3.5L6,2v14H3v3c0,1.66,1.34,3,3,3h12c1.66,0,3-1.34,3-3V2 L19.5,3.5z M15,20H6c-0.55,0-1-0.45-1-1v-1h10V20z M19,19c0,0.55-0.45,1-1,1s-1-0.45-1-1v-3H8V5h11V19z");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "height", "2");
		builder.AddAttribute(21, "width", "6");
		builder.AddAttribute(22, "x", "9");
		builder.AddAttribute(23, "y", "7");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "2");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "x", "16");
		builder.AddAttribute(28, "y", "7");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "2");
		builder.AddAttribute(31, "width", "6");
		builder.AddAttribute(32, "x", "9");
		builder.AddAttribute(33, "y", "10");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "height", "2");
		builder.AddAttribute(36, "width", "2");
		builder.AddAttribute(37, "x", "16");
		builder.AddAttribute(38, "y", "10");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
