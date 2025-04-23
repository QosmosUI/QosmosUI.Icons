// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineStroller : ComponentBase
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
		builder.AddAttribute(19, "d", "M18,20c0,1.1-0.9,2-2,2s-2-0.9-2-2s0.9-2,2-2S18,18.9,18,20z M6,18c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S7.1,18,6,18z M15,8.66L9.6,15H15V8.66 M18.65,3C20.52,3,22,4.56,22,6.48V7h-2V6.48C20,5.66,19.42,5,18.65,5C17.97,5,17.58,5.59,17,6.27V15 c0,1.1-0.9,2-2,2H7.43c-0.85,0-1.31-1-0.76-1.65l8.8-10.32C16.11,4.27,16.99,3,18.65,3L18.65,3z M10,5C9.35,5,8.71,5.09,8.09,5.27 l1.4,1.4l1.37-1.61C10.58,5.02,10.29,5,10,5 M10,3c1.56,0,3.03,0.4,4.3,1.1l-4.7,5.51L4.72,4.72C6.21,3.64,8.03,3,10,3L10,3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
