// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineCalculate : ComponentBase
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
		builder.AddAttribute(21, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "1.5");
		builder.AddAttribute(24, "width", "5");
		builder.AddAttribute(25, "x", "6.25");
		builder.AddAttribute(26, "y", "7.72");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "1.5");
		builder.AddAttribute(29, "width", "5");
		builder.AddAttribute(30, "x", "13");
		builder.AddAttribute(31, "y", "15.75");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "1.5");
		builder.AddAttribute(34, "width", "5");
		builder.AddAttribute(35, "x", "13");
		builder.AddAttribute(36, "y", "13.25");
		builder.CloseElement();
		builder.OpenElement(37, "polygon");
		builder.AddAttribute(38, "points", "8,18 9.5,18 9.5,16 11.5,16 11.5,14.5 9.5,14.5 9.5,12.5 8,12.5 8,14.5 6,14.5 6,16 8,16");
		builder.CloseElement();
		builder.OpenElement(39, "polygon");
		builder.AddAttribute(40, "points", "14.09,10.95 15.5,9.54 16.91,10.95 17.97,9.89 16.56,8.47 17.97,7.06 16.91,6 15.5,7.41 14.09,6 13.03,7.06 14.44,8.47 13.03,9.89");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
