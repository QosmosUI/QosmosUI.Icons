// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneViewCompactAlt : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M4,18h16V6H4V18z M12.5,7.5h4v4h-4V7.5z M12.5,12.5h4v4h-4V12.5z M7.5,7.5h4v4h-4V7.5z M7.5,12.5h4v4h-4 V12.5z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M20,4H4C2.9,4,2,4.9,2,6v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6C22,4.9,21.1,4,20,4z M20,18H4V6h16V18z");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "4");
		builder.AddAttribute(27, "width", "4");
		builder.AddAttribute(28, "x", "7.5");
		builder.AddAttribute(29, "y", "7.5");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "4");
		builder.AddAttribute(32, "width", "4");
		builder.AddAttribute(33, "x", "12.5");
		builder.AddAttribute(34, "y", "7.5");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "height", "4");
		builder.AddAttribute(37, "width", "4");
		builder.AddAttribute(38, "x", "7.5");
		builder.AddAttribute(39, "y", "12.5");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "height", "4");
		builder.AddAttribute(42, "width", "4");
		builder.AddAttribute(43, "x", "12.5");
		builder.AddAttribute(44, "y", "12.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
