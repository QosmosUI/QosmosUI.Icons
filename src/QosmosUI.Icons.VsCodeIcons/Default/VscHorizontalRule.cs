// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscHorizontalRule : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M6.432 10h.823V4h-.823v2.61h-2.61V4H3v6h.823V7.394h2.61V10zm5.668 0h.9l-1.28-2.63c.131-.058.26-.134.389-.23a1.666 1.666 0 0 0 .585-.797c.064-.171.096-.364.096-.58a1.77 1.77 0 0 0-.082-.557 1.644 1.644 0 0 0-.22-.446 1.504 1.504 0 0 0-.31-.341 1.864 1.864 0 0 0-.737-.373A1.446 1.446 0 0 0 11.1 4H8.64v6h.824V7.518h1.467L12.1 10zm-.681-3.32a.874.874 0 0 1-.293.055H9.463V4.787h1.663a.87.87 0 0 1 .576.24.956.956 0 0 1 .306.737c0 .168-.029.314-.087.437a.91.91 0 0 1-.503.479zM13 12H3v1h10v-1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
