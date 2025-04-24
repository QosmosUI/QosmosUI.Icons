// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMuo : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M4.887 6.016 0 10.903v7.048h19.108l4.873-4.874v-7.06Zm5.46 3.57a.295.295 0 0 1 .314.314v3.652h3V9.9a.303.303 0 0 1 .331-.314.295.295 0 0 1 .315.314v3.72a.506.506 0 0 1-.56.552h-3.18a.502.502 0 0 1-.551-.552V9.9a.303.303 0 0 1 .33-.314zm-5.113.041a.597.597 0 0 1 .465.22l1.638 1.99L8.96 9.81a.47.47 0 0 1 .378-.183h.164a.18.18 0 0 1 .183.183.193.193 0 0 1-.046.128L7.668 12.4a.433.433 0 0 1-.33.19.443.443 0 0 1-.323-.185l-1.45-1.753v3.246a.303.303 0 0 1-.331.315.295.295 0 0 1-.315-.315V9.942a.295.295 0 0 1 .315-.315zm9.942 0h3.334a.502.502 0 0 1 .552.552v3.44a.502.502 0 0 1-.552.553h-3.334a.502.502 0 0 1-.552-.552v-3.44a.502.502 0 0 1 .552-.553zm.093.62v3.304h3.148v-3.303zm-5.775.584c.032 0 .191.012.191.25v2.817a.303.303 0 0 1-.33.315.295.295 0 0 1-.315-.315V11.49a.591.591 0 0 1 .133-.378l.131-.164.012-.013c.058-.058.104-.104.178-.104zM24 14.498l-3.486 3.486H24Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
