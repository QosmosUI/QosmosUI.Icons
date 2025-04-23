// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundConstruction : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M20.99,17.99l-4.94-4.94l-2.12,2.12l4.94,4.94c0.59,0.59,1.54,0.59,2.12,0C21.57,19.52,21.57,18.57,20.99,17.99z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M17.65,10c1.93,0,3.5-1.57,3.5-3.5c0-0.58-0.16-1.12-0.41-1.6l-2.7,2.7l-1.49-1.49l2.7-2.7C18.77,3.16,18.23,3,17.65,3 c-1.93,0-3.5,1.57-3.5,3.5c0,0.41,0.08,0.8,0.21,1.16l-1.85,1.85l-1.78-1.78l0,0c0.39-0.39,0.39-1.02,0-1.41l-0.71-0.71l2.12-2.12 c-1.17-1.17-3.07-1.17-4.24,0L5.08,6.32c-0.39,0.39-0.39,1.02,0,1.41l0.71,0.71H3.25c-0.19,0-0.37,0.07-0.5,0.21 c-0.28,0.28-0.28,0.72,0,1l2.54,2.54c0.28,0.28,0.72,0.28,1,0c0.13-0.13,0.21-0.31,0.21-0.5V9.15L7.2,9.85 c0.39,0.39,1.02,0.39,1.41,0l1.78,1.78l-6.35,6.35c-0.59,0.59-0.59,1.54,0,2.12v0c0.59,0.59,1.54,0.59,2.12,0L16.48,9.79 C16.85,9.92,17.24,10,17.65,10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
