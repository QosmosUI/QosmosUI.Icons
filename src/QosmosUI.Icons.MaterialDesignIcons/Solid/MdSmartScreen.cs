// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdSmartScreen : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M21,5H3C1.9,5,1,5.9,1,7v10c0,1.1,0.9,2,2,2h18c1.1,0,2-0.9,2-2V7C23,5.9,22.1,5,21,5z M18,17H6V7h12V17z");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "height", "1.5");
		builder.AddAttribute(25, "width", "1.5");
		builder.AddAttribute(26, "x", "15");
		builder.AddAttribute(27, "y", "11.25");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "height", "1.5");
		builder.AddAttribute(30, "width", "1.5");
		builder.AddAttribute(31, "x", "12.5");
		builder.AddAttribute(32, "y", "11.25");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "1.5");
		builder.AddAttribute(35, "width", "1.5");
		builder.AddAttribute(36, "x", "10");
		builder.AddAttribute(37, "y", "11.25");
		builder.CloseElement();
		builder.OpenElement(38, "rect");
		builder.AddAttribute(39, "height", "1.5");
		builder.AddAttribute(40, "width", "1.5");
		builder.AddAttribute(41, "x", "7.5");
		builder.AddAttribute(42, "y", "11.25");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
