// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDataset : ComponentBase
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
		builder.AddAttribute(21, "opacity", ".3");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M5,19h14V5H5V19z M13,7h4v4h-4V7z M13,13h4v4h-4V13z M7,7h4v4H7V7z M7,13h4v4H7V13z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "4");
		builder.AddAttribute(27, "width", "4");
		builder.AddAttribute(28, "x", "7");
		builder.AddAttribute(29, "y", "13");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(30, "g");
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "height", "4");
		builder.AddAttribute(33, "width", "4");
		builder.AddAttribute(34, "x", "13");
		builder.AddAttribute(35, "y", "13");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.OpenElement(38, "g");
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "height", "4");
		builder.AddAttribute(41, "width", "4");
		builder.AddAttribute(42, "x", "7");
		builder.AddAttribute(43, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(44, "g");
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "height", "4");
		builder.AddAttribute(47, "width", "4");
		builder.AddAttribute(48, "x", "13");
		builder.AddAttribute(49, "y", "7");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
