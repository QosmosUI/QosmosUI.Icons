// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDashboardCustomize : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "enable-background", "new");
		builder.AddAttribute(21, "height", "4");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "x", "5");
		builder.AddAttribute(25, "y", "15");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "enable-background", "new");
		builder.AddAttribute(28, "height", "4");
		builder.AddAttribute(29, "opacity", ".3");
		builder.AddAttribute(30, "width", "4");
		builder.AddAttribute(31, "x", "5");
		builder.AddAttribute(32, "y", "5");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "enable-background", "new");
		builder.AddAttribute(35, "height", "4");
		builder.AddAttribute(36, "opacity", ".3");
		builder.AddAttribute(37, "width", "4");
		builder.AddAttribute(38, "x", "15");
		builder.AddAttribute(39, "y", "5");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M3,11h8V3H3V11z M5,5h4v4H5V5z");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M13,3v8h8V3H13z M19,9h-4V5h4V9z");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M3,21h8v-8H3V21z M5,15h4v4H5V15z");
		builder.CloseElement();
		builder.OpenElement(46, "polygon");
		builder.AddAttribute(47, "points", "18,13 16,13 16,16 13,16 13,18 16,18 16,21 18,21 18,18 21,18 21,16 18,16");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
