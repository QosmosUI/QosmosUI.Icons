// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiNotepad : ComponentBase
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
		builder.AddAttribute(15, "d", "M1 0v17h15v-17h-15zM15 16h-13v-15h2v1.092c-0.581 0.207-1 0.757-1 1.408 0 0.827 0.673 1.5 1.5 1.5s1.5-0.673 1.5-1.5c0-0.651-0.419-1.201-1-1.408v-1.092h3v1.092c-0.581 0.207-1 0.757-1 1.408 0 0.827 0.673 1.5 1.5 1.5s1.5-0.673 1.5-1.5c0-0.651-0.419-1.201-1-1.408v-1.092h3v1.092c-0.581 0.207-1 0.757-1 1.408 0 0.827 0.673 1.5 1.5 1.5s1.5-0.673 1.5-1.5c0-0.651-0.419-1.201-1-1.408v-1.092h2v15zM5 3.5c0 0.275-0.225 0.5-0.5 0.5s-0.5-0.225-0.5-0.5 0.225-0.5 0.5-0.5 0.5 0.225 0.5 0.5zM9 3.5c0 0.275-0.225 0.5-0.5 0.5s-0.5-0.225-0.5-0.5 0.225-0.5 0.5-0.5 0.5 0.225 0.5 0.5zM13 3.5c0 0.275-0.225 0.5-0.5 0.5s-0.5-0.225-0.5-0.5 0.225-0.5 0.5-0.5 0.5 0.225 0.5 0.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
