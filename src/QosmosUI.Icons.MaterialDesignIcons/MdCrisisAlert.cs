// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdCrisisAlert : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14.5,2.5c0,1.5-1.5,6-1.5,6h-2c0,0-1.5-4.5-1.5-6C9.5,1.12,10.62,0,12,0S14.5,1.12,14.5,2.5z M12,10c-1.1,0-2,0.9-2,2 s0.9,2,2,2s2-0.9,2-2S13.1,10,12,10z M16.08,5.11c0.18-0.75,0.33-1.47,0.39-2.06C19.75,4.69,22,8.08,22,12c0,5.52-4.48,10-10,10 S2,17.52,2,12c0-3.92,2.25-7.31,5.53-8.95C7.6,3.64,7.74,4.37,7.92,5.11C5.58,6.51,4,9.07,4,12c0,4.42,3.58,8,8,8s8-3.58,8-8 C20,9.07,18.42,6.51,16.08,5.11z M18,12c0,3.31-2.69,6-6,6s-6-2.69-6-6c0-2,0.98-3.77,2.48-4.86c0.23,0.81,0.65,2.07,0.65,2.07 C8.43,9.93,8,10.92,8,12c0,2.21,1.79,4,4,4s4-1.79,4-4c0-1.08-0.43-2.07-1.13-2.79c0,0,0.41-1.22,0.65-2.07C17.02,8.23,18,10,18,12 z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
