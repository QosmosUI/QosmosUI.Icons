// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Lucide.Default;

public class LuLayoutDashboard : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "width", "7");
		builder.AddAttribute(15, "height", "9");
		builder.AddAttribute(16, "x", "3");
		builder.AddAttribute(17, "y", "3");
		builder.AddAttribute(18, "rx", "1");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "width", "7");
		builder.AddAttribute(21, "height", "5");
		builder.AddAttribute(22, "x", "14");
		builder.AddAttribute(23, "y", "3");
		builder.AddAttribute(24, "rx", "1");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "width", "7");
		builder.AddAttribute(27, "height", "9");
		builder.AddAttribute(28, "x", "14");
		builder.AddAttribute(29, "y", "12");
		builder.AddAttribute(30, "rx", "1");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "width", "7");
		builder.AddAttribute(33, "height", "5");
		builder.AddAttribute(34, "x", "3");
		builder.AddAttribute(35, "y", "16");
		builder.AddAttribute(36, "rx", "1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
