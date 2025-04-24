// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiWasmcloud : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M21.805 5.477 12.797.215a1.591 1.591 0 0 0-1.6 0L2.19 5.477a1.41 1.41 0 0 0-.697 1.215v10.604a1.438 1.438 0 0 0 .715 1.243l9.023 5.251a1.553 1.553 0 0 0 1.558 0l8.998-5.25a1.438 1.438 0 0 0 .72-1.244V6.692a1.41 1.41 0 0 0-.702-1.215zm-2.001 10.428a.277.277 0 0 1-.139.238l-7.527 4.388a.277.277 0 0 1-.282 0l-7.524-4.385a.29.29 0 0 1-.14-.257v-7.8a.277.277 0 0 1 .138-.239l2.732-1.6a.284.284 0 0 1 .279 0 .277.277 0 0 1 .14.242v7.324l2.469-1.432v-7.65a.274.274 0 0 1 .138-.241l1.781-1.04a.277.277 0 0 1 .282 0l1.794 1.042a.28.28 0 0 1 .136.241v7.642l2.455 1.43V6.484a.277.277 0 0 1 .141-.24.28.28 0 0 1 .28 0l2.731 1.603a.277.277 0 0 1 .139.239z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
