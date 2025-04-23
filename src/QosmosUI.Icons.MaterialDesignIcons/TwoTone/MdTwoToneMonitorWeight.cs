// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneMonitorWeight : ComponentBase
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
		builder.AddAttribute(20, "height", "1");
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "width", "1");
		builder.AddAttribute(23, "x", "13");
		builder.AddAttribute(24, "y", "8.5");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "1");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "width", "1");
		builder.AddAttribute(29, "x", "10");
		builder.AddAttribute(30, "y", "8.5");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "height", "1");
		builder.AddAttribute(33, "opacity", ".3");
		builder.AddAttribute(34, "width", "1");
		builder.AddAttribute(35, "x", "11.5");
		builder.AddAttribute(36, "y", "8.5");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M5,19h14V5H5V19z M12,6c1.66,0,3,1.34,3,3s-1.34,3-3,3s-3-1.34-3-3S10.34,6,12,6z");
		builder.AddAttribute(39, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M12,12c1.66,0,3-1.34,3-3s-1.34-3-3-3S9,7.34,9,9S10.34,12,12,12z M13,8.5h1v1h-1V8.5z M11.5,8.5h1v1h-1V8.5z M10,8.5h1v1 h-1V8.5z");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
