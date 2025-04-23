// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineDataset : ComponentBase
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
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "height", "4");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "x", "7");
		builder.AddAttribute(25, "y", "13");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "4");
		builder.AddAttribute(29, "width", "4");
		builder.AddAttribute(30, "x", "13");
		builder.AddAttribute(31, "y", "13");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(35, "g");
		builder.OpenElement(36, "rect");
		builder.AddAttribute(37, "height", "4");
		builder.AddAttribute(38, "width", "4");
		builder.AddAttribute(39, "x", "7");
		builder.AddAttribute(40, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(41, "g");
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "height", "4");
		builder.AddAttribute(44, "width", "4");
		builder.AddAttribute(45, "x", "13");
		builder.AddAttribute(46, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
