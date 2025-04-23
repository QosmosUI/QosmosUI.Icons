// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEditRoad : ComponentBase
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
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "points", "15.55,17.42 15.55,18.45 16.58,18.45 20.03,15 19,13.97");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "18,4 16,4 16,11.9 18,9.9");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "16");
		builder.AddAttribute(27, "width", "2");
		builder.AddAttribute(28, "x", "4");
		builder.AddAttribute(29, "y", "4");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "4");
		builder.AddAttribute(32, "width", "2");
		builder.AddAttribute(33, "x", "10");
		builder.AddAttribute(34, "y", "4");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "height", "4");
		builder.AddAttribute(37, "width", "2");
		builder.AddAttribute(38, "x", "10");
		builder.AddAttribute(39, "y", "10");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "height", "4");
		builder.AddAttribute(42, "width", "2");
		builder.AddAttribute(43, "x", "10");
		builder.AddAttribute(44, "y", "16");
		builder.CloseElement();
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M22.56,12.59l-1.15-1.15c-0.59-0.59-1.54-0.59-2.12,0L14,16.73V20h3.27l5.29-5.29C23.15,14.12,23.15,13.17,22.56,12.59z M16.58,18.45h-1.03v-1.03L19,13.97L20.03,15L16.58,18.45z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
