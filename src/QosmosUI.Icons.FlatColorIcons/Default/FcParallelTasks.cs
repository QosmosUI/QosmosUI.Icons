// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcParallelTasks : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#90CAF9");
		builder.AddAttribute(15, "points", "36,13 36,9 22,9 22,22 13,22 13,26 22,26 22,39 36,39 36,35 26,35 26,26 36,26 36,22 26,22 26,13");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "6");
		builder.AddAttribute(18, "y", "17");
		builder.AddAttribute(19, "fill", "#D81B60");
		builder.AddAttribute(20, "width", "10");
		builder.AddAttribute(21, "height", "14");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "x", "32");
		builder.AddAttribute(24, "y", "6");
		builder.AddAttribute(25, "fill", "#2196F3");
		builder.AddAttribute(26, "width", "10");
		builder.AddAttribute(27, "height", "10");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "32");
		builder.AddAttribute(30, "y", "32");
		builder.AddAttribute(31, "fill", "#2196F3");
		builder.AddAttribute(32, "width", "10");
		builder.AddAttribute(33, "height", "10");
		builder.CloseElement();
		builder.OpenElement(34, "rect");
		builder.AddAttribute(35, "x", "32");
		builder.AddAttribute(36, "y", "19");
		builder.AddAttribute(37, "fill", "#2196F3");
		builder.AddAttribute(38, "width", "10");
		builder.AddAttribute(39, "height", "10");
		builder.CloseElement();
		builder.CloseElement();
    }
}
