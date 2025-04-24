// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiPalette : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M8.5 0.5c-4.411 0-8 3.589-8 8 0 4.281 3.352 7.787 7.631 7.982l1.288 0.059-2.723-2.723c-0.283-0.283-0.439-0.66-0.439-1.061s0.156-0.777 0.439-1.061c0.566-0.566 1.555-0.566 2.121 0l3.719 3.719 0.34-0.223c2.27-1.486 3.624-3.988 3.624-6.692 0-4.411-3.589-8-8-8zM12.66 14.125l-3.135-3.135c-0.943-0.944-2.592-0.944-3.535 0-0.472 0.472-0.732 1.1-0.732 1.768s0.26 1.296 0.732 1.768l0.741 0.741c-3.026-0.783-5.231-3.52-5.231-6.767 0-3.86 3.14-7 7-7s7 3.14 7 7c0 2.23-1.054 4.305-2.84 5.625zM11.5 6.5c-1.103 0-2 0.897-2 2s0.897 2 2 2 2-0.897 2-2-0.897-2-2-2zM11.5 9.5c-0.551 0-1-0.449-1-1s0.449-1 1-1 1 0.449 1 1-0.449 1-1 1zM8.5 6c-0.828 0-1.5-0.671-1.5-1.5s0.672-1.5 1.5-1.5c0.829 0 1.5 0.671 1.5 1.5s-0.671 1.5-1.5 1.5zM5.75 5.891c0 0.552-0.448 1-1 1s-1-0.448-1-1 0.448-1 1-1 1 0.447 1 1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
