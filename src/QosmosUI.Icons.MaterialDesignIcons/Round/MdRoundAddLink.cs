// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAddLink : ComponentBase
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
		builder.AddAttribute(20, "d", "M9,11h6c0.55,0,1,0.45,1,1v0c0,0.55-0.45,1-1,1H9c-0.55,0-1-0.45-1-1v0C8,11.45,8.45,11,9,11z M20.93,12L20.93,12 c0.62,0,1.07-0.59,0.93-1.19C21.32,8.62,19.35,7,17,7h-3.05C13.43,7,13,7.43,13,7.95v0c0,0.52,0.43,0.95,0.95,0.95H17 c1.45,0,2.67,1,3.01,2.34C20.12,11.68,20.48,12,20.93,12z M3.96,11.38C4.24,9.91,5.62,8.9,7.12,8.9l2.93,0 C10.57,8.9,11,8.47,11,7.95v0C11,7.43,10.57,7,10.05,7L7.22,7c-2.61,0-4.94,1.91-5.19,4.51C1.74,14.49,4.08,17,7,17h3.05 c0.52,0,0.95-0.43,0.95-0.95v0c0-0.52-0.43-0.95-0.95-0.95H7C5.09,15.1,3.58,13.36,3.96,11.38z M18,12L18,12c-0.55,0-1,0.45-1,1v2 h-2c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h2v2c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-2h2c0.55,0,1-0.45,1-1v0 c0-0.55-0.45-1-1-1h-2v-2C19,12.45,18.55,12,18,12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
