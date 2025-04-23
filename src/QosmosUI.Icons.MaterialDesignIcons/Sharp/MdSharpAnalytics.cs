// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpAnalytics : ComponentBase
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
		builder.OpenElement(17, "rect");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "height", "5");
		builder.AddAttribute(20, "width", "2");
		builder.AddAttribute(21, "x", "7");
		builder.AddAttribute(22, "y", "12");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "fill", "none");
		builder.AddAttribute(25, "height", "3");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "x", "11");
		builder.AddAttribute(28, "y", "14");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "height", "10");
		builder.AddAttribute(32, "width", "2");
		builder.AddAttribute(33, "x", "15");
		builder.AddAttribute(34, "y", "7");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M3,3v18h18V3H3z M9,17H7v-5h2V17z M13,17h-2v-3h2V17z M13,12h-2v-2h2V12z M17,17h-2V7h2V17z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
