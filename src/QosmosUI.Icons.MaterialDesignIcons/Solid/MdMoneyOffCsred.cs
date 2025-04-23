// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdMoneyOffCsred : ComponentBase
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
		builder.AddAttribute(20, "d", "M10.53,7.43c0.42-0.31,0.93-0.47,1.54-0.47s1.11,0.16,1.5,0.49c0.39,0.32,0.65,0.7,0.79,1.12l1.89-0.8 c-0.24-0.71-0.71-1.35-1.4-1.92c-0.5-0.4-1.12-0.65-1.85-0.77V3h-2v2.11c-0.41,0.08-0.79,0.21-1.14,0.39 c-0.35,0.18-0.64,0.39-0.9,0.63l1.43,1.43C10.43,7.52,10.48,7.47,10.53,7.43z M2.81,2.81L1.39,4.22l12.35,12.35 C13.31,16.85,12.79,17,12.19,17c-0.71,0-1.32-0.23-1.83-0.7c-0.5-0.47-0.86-1.07-1.06-1.81l-1.98,0.8 c0.34,1.17,0.95,2.08,1.83,2.73c0.57,0.42,1.19,0.68,1.85,0.83V21h2v-2.08c0.44-0.07,0.87-0.17,1.29-0.35 c0.34-0.14,0.64-0.32,0.92-0.53l4.57,4.57l1.41-1.41L2.81,2.81z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
