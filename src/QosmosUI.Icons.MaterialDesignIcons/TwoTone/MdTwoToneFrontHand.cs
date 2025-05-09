// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFrontHand : ComponentBase
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
		builder.AddAttribute(18, "d", "M19,15.5c0,3.59-2.91,6.5-6.5,6.5S6,19.09,6,15.5V7c0-0.28,0.22-0.5,0.5-0.5S7,6.72,7,7v5h2V4 c0-0.28,0.22-0.5,0.5-0.5S10,3.72,10,4v7h2V2.5C12,2.22,12.22,2,12.5,2S13,2.22,13,2.5V11h2V4.5C15,4.22,15.22,4,15.5,4 S16,4.22,16,4.5v8.92c-1.77,0.77-3,2.53-3,4.58h2c0-1.66,1.34-3,3-3v-4.5c0-0.28,0.22-0.5,0.5-0.5s0.5,0.22,0.5,0.5V15.5z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M18.5,8c-0.17,0-0.34,0.02-0.5,0.05V4.5C18,3.12,16.88,2,15.5,2c-0.19,0-0.37,0.02-0.54,0.06C14.75,0.89,13.73,0,12.5,0 c-1.06,0-1.96,0.66-2.33,1.59C9.96,1.53,9.73,1.5,9.5,1.5C8.12,1.5,7,2.62,7,4v0.55C6.84,4.52,6.67,4.5,6.5,4.5C5.12,4.5,4,5.62,4,7 v8.5c0,4.69,3.81,8.5,8.5,8.5s8.5-3.81,8.5-8.5v-5C21,9.12,19.88,8,18.5,8z M19,15.5c0,3.59-2.91,6.5-6.5,6.5S6,19.09,6,15.5V7 c0-0.28,0.22-0.5,0.5-0.5S7,6.72,7,7v5h2V4c0-0.28,0.22-0.5,0.5-0.5S10,3.72,10,4v7h2V2.5C12,2.22,12.22,2,12.5,2S13,2.22,13,2.5V11 h2V4.5C15,4.22,15.22,4,15.5,4S16,4.22,16,4.5v8.92c-1.77,0.77-3,2.53-3,4.58h2c0-1.66,1.34-3,3-3v-4.5c0-0.28,0.22-0.5,0.5-0.5 s0.5,0.22,0.5,0.5V15.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
