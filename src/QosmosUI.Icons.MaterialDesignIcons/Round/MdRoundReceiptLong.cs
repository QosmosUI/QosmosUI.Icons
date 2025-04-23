// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundReceiptLong : ComponentBase
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
		builder.AddAttribute(18, "d", "M14,9h-4C9.45,9,9,8.55,9,8v0c0-0.55,0.45-1,1-1h4c0.55,0,1,0.45,1,1v0C15,8.55,14.55,9,14,9z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14,12h-4c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h4c0.55,0,1,0.45,1,1v0C15,11.55,14.55,12,14,12z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M19.5,3.5L18,2l-1.5,1.5L15,2l-1.5,1.5L12,2l-1.5,1.5L9,2L7.5,3.5L6,2v14H4c-0.55,0-1,0.45-1,1v2c0,1.66,1.34,3,3,3h12 c1.66,0,3-1.34,3-3V2L19.5,3.5z M15,20H6c-0.55,0-1-0.45-1-1v-1h3h4h3V20z M19,19c0,0.55-0.45,1-1,1s-1-0.45-1-1v-2 c0-0.55-0.45-1-1-1h-2h-2H8V5h11V19z");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "17");
		builder.AddAttribute(25, "cy", "8");
		builder.AddAttribute(26, "r", "1");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "17");
		builder.AddAttribute(29, "cy", "11");
		builder.AddAttribute(30, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
