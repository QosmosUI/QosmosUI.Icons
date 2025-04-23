// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiPencilAlt : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.499 1.843l-1.403-1.403c-0.566-0.566-1.555-0.566-2.122 0l-7.536 7.536-1.722 5.287 5.249-1.765 7.534-7.534c0.283-0.283 0.439-0.66 0.439-1.061s-0.156-0.777-0.439-1.060zM5.584 10.758l0.638-1.957 1.92 1.919-1.942 0.653-0.616-0.615zM6.832 7.996l3.986-3.986 2.11 2.11-3.986 3.986-2.11-2.11zM11.525 3.303l0.729-0.729 2.11 2.11-0.729 0.729-2.11-2.11zM15.792 3.257l-0.72 0.721-2.11-2.11 0.72-0.721c0.19-0.189 0.519-0.189 0.707 0l1.403 1.403c0.094 0.095 0.146 0.22 0.146 0.354s-0.052 0.258-0.146 0.353zM15 7.5h1v9.5h-16v-15h7.5v1h-6.5v13h14v-8.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
