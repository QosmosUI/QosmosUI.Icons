// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPublishedWithChanges : ComponentBase
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
		builder.AddAttribute(18, "d", "M16.95,10.23l-5.66,5.66c-0.39,0.39-1.02,0.39-1.41,0l-2.83-2.83c-0.39-0.39-0.39-1.02,0-1.41l0,0 c0.39-0.39,1.02-0.39,1.41,0l2.12,2.12l4.95-4.95c0.39-0.39,1.02-0.39,1.41,0l0,0C17.34,9.21,17.34,9.84,16.95,10.23z M4,12 c0-2.33,1.02-4.42,2.62-5.88l1.53,1.53C8.46,7.96,9,7.74,9,7.29V3c0-0.28-0.22-0.5-0.5-0.5H4.21c-0.45,0-0.67,0.54-0.35,0.85 L5.2,4.7C3.24,6.52,2,9.11,2,12c0,4.75,3.32,8.73,7.76,9.75c0.63,0.14,1.24-0.33,1.24-0.98v0c0-0.47-0.33-0.87-0.79-0.98 C6.66,18.98,4,15.8,4,12z M22,12c0-4.75-3.32-8.73-7.76-9.75C13.61,2.11,13,2.58,13,3.23v0c0,0.47,0.33,0.87,0.79,0.98 C17.34,5.02,20,8.2,20,12c0,2.33-1.02,4.42-2.62,5.88l-1.53-1.53C15.54,16.04,15,16.26,15,16.71V21c0,0.28,0.22,0.5,0.5,0.5h4.29 c0.45,0,0.67-0.54,0.35-0.85L18.8,19.3C20.76,17.48,22,14.89,22,12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
