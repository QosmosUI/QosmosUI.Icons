// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneStroller : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M10,5c0.29,0,0.58,0.02,0.86,0.05L9.49,6.66l-1.4-1.4C8.71,5.09,9.35,5,10,5 M15,8.66V15H9.6L15,8.66");
		builder.AddAttribute(20, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M10,5c0.29,0,0.58,0.02,0.86,0.05L9.49,6.66l-1.4-1.4C8.71,5.09,9.35,5,10,5 M15,8.66V15H9.6L15,8.66 M18.65,3 c-1.66,0-2.54,1.27-3.18,2.03l-8.8,10.32C6.12,16,6.58,17,7.43,17H15c1.1,0,2-0.9,2-2V6.27C17.58,5.59,17.97,5,18.65,5 C19.42,5,20,5.66,20,6.48V7h2V6.48C22,4.56,20.52,3,18.65,3L18.65,3z M10,3C8.03,3,6.21,3.64,4.72,4.72l4.89,4.89l4.7-5.51 C13.03,3.4,11.56,3,10,3L10,3z M16,18c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S17.1,18,16,18L16,18z M6,18c-1.1,0-2,0.9-2,2 s0.9,2,2,2s2-0.9,2-2S7.1,18,6,18L6,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
