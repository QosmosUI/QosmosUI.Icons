// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Feather.Default;

public class FiAlignRight : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "2";

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
		builder.OpenElement(13, "line");
		builder.AddAttribute(14, "x1", "21");
		builder.AddAttribute(15, "y1", "10");
		builder.AddAttribute(16, "x2", "7");
		builder.AddAttribute(17, "y2", "10");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "x1", "21");
		builder.AddAttribute(20, "y1", "6");
		builder.AddAttribute(21, "x2", "3");
		builder.AddAttribute(22, "y2", "6");
		builder.CloseElement();
		builder.OpenElement(23, "line");
		builder.AddAttribute(24, "x1", "21");
		builder.AddAttribute(25, "y1", "14");
		builder.AddAttribute(26, "x2", "3");
		builder.AddAttribute(27, "y2", "14");
		builder.CloseElement();
		builder.OpenElement(28, "line");
		builder.AddAttribute(29, "x1", "21");
		builder.AddAttribute(30, "y1", "18");
		builder.AddAttribute(31, "x2", "7");
		builder.AddAttribute(32, "y2", "18");
		builder.CloseElement();
		builder.CloseElement();
    }
}
