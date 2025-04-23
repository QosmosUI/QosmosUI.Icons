// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdPercent : ComponentBase
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
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M7.5,11C9.43,11,11,9.43,11,7.5S9.43,4,7.5,4S4,5.57,4,7.5S5.57,11,7.5,11z M7.5,6C8.33,6,9,6.67,9,7.5S8.33,9,7.5,9 S6,8.33,6,7.5S6.67,6,7.5,6z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "2");
		builder.AddAttribute(27, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -4.9706 12)");
		builder.AddAttribute(28, "width", "20.63");
		builder.AddAttribute(29, "x", "1.69");
		builder.AddAttribute(30, "y", "11");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(31, "g");
		builder.OpenElement(32, "g");
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M16.5,13c-1.93,0-3.5,1.57-3.5,3.5s1.57,3.5,3.5,3.5s3.5-1.57,3.5-3.5S18.43,13,16.5,13z M16.5,18 c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S17.33,18,16.5,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
