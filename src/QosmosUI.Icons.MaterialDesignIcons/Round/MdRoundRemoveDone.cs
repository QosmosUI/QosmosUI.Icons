// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRemoveDone : ComponentBase
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
		builder.AddAttribute(20, "d", "M4.14,2.69L4.14,2.69c-0.39,0.39-0.39,1.02,0,1.41l9.67,9.67l-1.41,1.41l-3.54-3.53c-0.39-0.39-1.02-0.39-1.41,0l0,0 c-0.39,0.39-0.39,1.02,0,1.41l4.24,4.24c0.39,0.39,1.02,0.39,1.41,0l2.12-2.12l5.89,5.89c0.39,0.39,1.02,0.39,1.41,0l0,0 c0.39-0.39,0.39-1.02,0-1.41L5.55,2.69C5.16,2.3,4.53,2.3,4.14,2.69z M18.05,12.36l4.24-4.24c0.39-0.39,0.39-1.03-0.01-1.42l0,0 c-0.39-0.38-1.02-0.38-1.41,0.01l-4.24,4.24L18.05,12.36z M16.64,6.7L16.64,6.7c-0.39-0.39-1.02-0.39-1.41,0l-1.42,1.42l1.41,1.41 l1.42-1.42C17.03,7.72,17.03,7.09,16.64,6.7z M1.79,13.06l4.95,4.95l1.41-1.41L3.2,11.65c-0.39-0.39-1.02-0.39-1.41,0l0,0 C1.4,12.04,1.4,12.67,1.79,13.06z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
