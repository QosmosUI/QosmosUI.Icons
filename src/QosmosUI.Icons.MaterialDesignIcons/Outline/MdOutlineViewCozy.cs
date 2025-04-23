// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineViewCozy : ComponentBase
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
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "height", "4");
		builder.AddAttribute(22, "width", "4");
		builder.AddAttribute(23, "x", "7.25");
		builder.AddAttribute(24, "y", "7.25");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "4");
		builder.AddAttribute(27, "width", "4");
		builder.AddAttribute(28, "x", "12.75");
		builder.AddAttribute(29, "y", "7.25");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "4");
		builder.AddAttribute(32, "width", "4");
		builder.AddAttribute(33, "x", "7.25");
		builder.AddAttribute(34, "y", "12.75");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "height", "4");
		builder.AddAttribute(37, "width", "4");
		builder.AddAttribute(38, "x", "12.75");
		builder.AddAttribute(39, "y", "12.75");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M20,4H4C2.9,4,2,4.9,2,6v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6C22,4.9,21.1,4,20,4z M20,18H4V6h16V18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
