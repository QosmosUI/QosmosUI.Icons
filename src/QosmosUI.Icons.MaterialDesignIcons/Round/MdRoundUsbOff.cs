// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundUsbOff : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M9.6,5.2l2-2.67c0.2-0.27,0.6-0.27,0.8,0l2,2.67C14.65,5.53,14.41,6,14,6h-1v4.17l-2-2V6h-1C9.59,6,9.35,5.53,9.6,5.2z M15.5,12H16v1.17l1.77,1.77C17.91,14.66,18,14.34,18,14v-2h0.5c0.28,0,0.5-0.22,0.5-0.5v-3C19,8.22,18.78,8,18.5,8h-3 C15.22,8,15,8.22,15,8.5v3C15,11.78,15.22,12,15.5,12z M20.49,21.9L20.49,21.9c-0.39,0.39-1.02,0.39-1.41,0l-5.9-5.9H13v2.28 c0.6,0.34,1,0.98,1,1.72c0,1.2-1.07,2.16-2.31,1.98c-0.88-0.13-1.59-0.88-1.68-1.77c-0.08-0.83,0.33-1.55,0.99-1.93V16H8 c-1.1,0-2-0.9-2-2v-2.28C5.4,11.38,5,10.74,5,10c0-0.59,0.26-1.13,0.68-1.5L2.1,4.93c-0.39-0.39-0.39-1.02,0-1.41 c0.39-0.39,1.02-0.39,1.41,0l16.97,16.97C20.88,20.88,20.88,21.51,20.49,21.9z M11,13.83l-2.51-2.51c-0.14,0.16-0.31,0.29-0.49,0.4 V14h3V13.83z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
