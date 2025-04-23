// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTone6k : ComponentBase
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
		builder.AddAttribute(21, "enable-background", "new");
		builder.AddAttribute(22, "height", "1.5");
		builder.AddAttribute(23, "opacity", ".3");
		builder.AddAttribute(24, "width", "1.5");
		builder.AddAttribute(25, "x", "8");
		builder.AddAttribute(26, "y", "12.5");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M5,19h14V5H5V19z M13,9h1.5v2.25L16.25,9H18l-2.25,3L18,15h-1.75l-1.75-2.25 V15H13V9z M6.5,10c0-0.55,0.45-1,1-1H11v1.5H8v1h2c0.55,0,1,0.45,1,1V14c0,0.55-0.45,1-1,1H7.5c-0.55,0-1-0.45-1-1V10z");
		builder.AddAttribute(29, "enable-background", "new");
		builder.AddAttribute(30, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.OpenElement(33, "polygon");
		builder.AddAttribute(34, "points", "14.5,12.75 16.25,15 18,15 15.75,12 18,9 16.25,9 14.5,11.25 14.5,9 13,9 13,15 14.5,15");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M7.5,15H10c0.55,0,1-0.45,1-1v-1.5c0-0.55-0.45-1-1-1H8v-1h3V9H7.5c-0.55,0-1,0.45-1,1v4C6.5,14.55,6.95,15,7.5,15z M8,12.5h1.5V14H8V12.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
