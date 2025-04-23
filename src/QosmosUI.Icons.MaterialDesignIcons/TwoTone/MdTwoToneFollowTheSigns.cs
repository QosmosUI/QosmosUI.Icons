// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFollowTheSigns : ComponentBase
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
		builder.AddAttribute(18, "d", "M17.64,7.75V6h-3.51V4.5h3.51V2.75l2.49,2.5L17.64,7.75z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M9.12,5.25c1.1,0,2-0.9,2-2s-0.9-2-2-2s-2,0.9-2,2S8.02,5.25,9.12,5.25z M5.38,8.65l-2.75,14.1h2.1l1.75-8l2.15,2v6h2V15.2 l-2.05-2.05l0.6-3c1.3,1.6,3.25,2.6,5.45,2.6v-2c-1.85,0-3.45-1-4.35-2.45L9.32,6.7c-0.35-0.6-1-0.95-1.7-0.95 c-0.25,0-0.5,0.05-0.75,0.15L1.62,8.05v4.7h2V9.4L5.38,8.65 M12.62,1.75v7h3.75v14h1.5v-14h3.75v-7H12.62z M17.64,7.75V6h-3.51V4.5 h3.51V2.75l2.49,2.5L17.64,7.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
