// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWheelchairPickup : ComponentBase
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
		builder.AddAttribute(18, "x", "0");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M4.5,4c0-1.11,0.89-2,2-2s2,0.89,2,2s-0.89,2-2,2S4.5,5.11,4.5,4z M10,10.95V9c0-1.1-0.9-2-2-2H5C3.9,7,3,7.9,3,9v5 c0,0.55,0.45,1,1,1h1v6c0,0.55,0.45,1,1,1h2.5v-0.11c-1.24-1.26-2-2.99-2-4.89C6.5,14.42,7.91,12.16,10,10.95z M16.5,17 c0,1.65-1.35,3-3,3s-3-1.35-3-3c0-1.11,0.61-2.06,1.5-2.58v-2.16C9.98,12.9,8.5,14.77,8.5,17c0,2.76,2.24,5,5,5s5-2.24,5-5H16.5z M19,14h-4V9c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v6c0,0.55,0.45,1,1,1h4.46l1.92,2.88c0.31,0.46,0.93,0.58,1.39,0.28h0 c0.46-0.31,0.58-0.93,0.28-1.39l-2.21-3.32C19.65,14.17,19.33,14,19,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
