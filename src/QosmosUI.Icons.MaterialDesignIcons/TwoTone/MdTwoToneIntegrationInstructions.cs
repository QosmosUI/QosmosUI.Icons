// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneIntegrationInstructions : ComponentBase
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
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "12");
		builder.AddAttribute(20, "cy", "3.5");
		builder.AddAttribute(21, "fill", "none");
		builder.AddAttribute(22, "r", ".75");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "12");
		builder.AddAttribute(25, "cy", "3.5");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "r", ".75");
		builder.CloseElement();
		builder.OpenElement(28, "line");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "x1", "19");
		builder.AddAttribute(31, "x2", "5");
		builder.AddAttribute(32, "y1", "5");
		builder.AddAttribute(33, "y2", "5");
		builder.CloseElement();
		builder.OpenElement(34, "line");
		builder.AddAttribute(35, "fill", "none");
		builder.AddAttribute(36, "x1", "5");
		builder.AddAttribute(37, "x2", "19");
		builder.AddAttribute(38, "y1", "19");
		builder.AddAttribute(39, "y2", "19");
		builder.CloseElement();
		builder.OpenElement(40, "g");
		builder.OpenElement(41, "polygon");
		builder.AddAttribute(42, "points", "11,14.17 8.83,12 11,9.83 9.59,8.41 6,12 9.59,15.59");
		builder.CloseElement();
		builder.OpenElement(43, "polygon");
		builder.AddAttribute(44, "points", "14.41,15.59 18,12 14.41,8.41 13,9.83 15.17,12 13,14.17");
		builder.CloseElement();
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M19,3h-4.18C14.4,1.84,13.3,1,12,1S9.6,1.84,9.18,3H5C4.86,3,4.73,3.01,4.6,3.04C4.21,3.12,3.86,3.32,3.59,3.59 c-0.18,0.18-0.33,0.4-0.43,0.64C3.06,4.46,3,4.72,3,5v10v1v3c0,0.27,0.06,0.54,0.16,0.78c0.1,0.24,0.25,0.45,0.43,0.64 c0.27,0.27,0.62,0.47,1.01,0.55C4.73,20.99,4.86,21,5,21h14c1.1,0,2-0.9,2-2v-3v-1V5C21,3.9,20.1,3,19,3z M12,2.75 c0.41,0,0.75,0.34,0.75,0.75S12.41,4.25,12,4.25s-0.75-0.34-0.75-0.75S11.59,2.75,12,2.75z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(47, "line");
		builder.AddAttribute(48, "fill", "none");
		builder.AddAttribute(49, "opacity", ".3");
		builder.AddAttribute(50, "x1", "19");
		builder.AddAttribute(51, "x2", "5");
		builder.AddAttribute(52, "y1", "5");
		builder.AddAttribute(53, "y2", "5");
		builder.CloseElement();
		builder.OpenElement(54, "line");
		builder.AddAttribute(55, "fill", "none");
		builder.AddAttribute(56, "opacity", ".3");
		builder.AddAttribute(57, "x1", "5");
		builder.AddAttribute(58, "x2", "19");
		builder.AddAttribute(59, "y1", "19");
		builder.AddAttribute(60, "y2", "19");
		builder.CloseElement();
		builder.OpenElement(61, "rect");
		builder.AddAttribute(62, "height", "14");
		builder.AddAttribute(63, "opacity", ".3");
		builder.AddAttribute(64, "width", "14");
		builder.AddAttribute(65, "x", "5");
		builder.AddAttribute(66, "y", "5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
