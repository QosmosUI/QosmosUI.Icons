// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdSensors : ComponentBase
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
		builder.AddAttribute(18, "d", "M7.76,16.24C6.67,15.16,6,13.66,6,12s0.67-3.16,1.76-4.24l1.42,1.42C8.45,9.9,8,10.9,8,12c0,1.1,0.45,2.1,1.17,2.83 L7.76,16.24z M16.24,16.24C17.33,15.16,18,13.66,18,12s-0.67-3.16-1.76-4.24l-1.42,1.42C15.55,9.9,16,10.9,16,12 c0,1.1-0.45,2.1-1.17,2.83L16.24,16.24z M12,10c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S13.1,10,12,10z M20,12 c0,2.21-0.9,4.21-2.35,5.65l1.42,1.42C20.88,17.26,22,14.76,22,12s-1.12-5.26-2.93-7.07l-1.42,1.42C19.1,7.79,20,9.79,20,12z M6.35,6.35L4.93,4.93C3.12,6.74,2,9.24,2,12s1.12,5.26,2.93,7.07l1.42-1.42C4.9,16.21,4,14.21,4,12S4.9,7.79,6.35,6.35z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
