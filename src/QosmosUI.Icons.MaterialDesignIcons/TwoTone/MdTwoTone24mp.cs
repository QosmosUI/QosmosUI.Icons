// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTone24mp : ComponentBase
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
		builder.AddAttribute(21, "d", "M5,19h14V5H5V19z M18,16c0,0.55-0.45,1-1,1h-2v1.5h-1.5v-6H17c0.55,0,1,0.45,1,1V16z M13,5.5h1.5v3H16v-3 h1.5v3h1V10h-1v1.5H16V10h-3V5.5z M6.5,9c0-0.55,0.45-1,1-1h2V7h-3V5.5H10c0.55,0,1,0.45,1,1V8c0,0.55-0.45,1-1,1H8v1h3v1.5H6.5V9 z M6,13.5c0-0.55,0.45-1,1-1h4.5c0.55,0,1,0.45,1,1v5H11V14h-1v3H8.5v-3h-1v4.5H6V13.5z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "height", "1.5");
		builder.AddAttribute(25, "opacity", ".3");
		builder.AddAttribute(26, "width", "1.5");
		builder.AddAttribute(27, "x", "15");
		builder.AddAttribute(28, "y", "14");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M7.5,14h1v3H10v-3h1v4.5h1.5v-5c0-0.55-0.45-1-1-1H7c-0.55,0-1,0.45-1,1v5h1.5V14z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M17,12.5h-3.5v6H15V17h2c0.55,0,1-0.45,1-1v-2.5C18,12.95,17.55,12.5,17,12.5z M16.5,15.5H15V14h1.5V15.5z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M11,10H8V9h2c0.55,0,1-0.45,1-1V6.5c0-0.55-0.45-1-1-1H6.5V7h3v1h-2c-0.55,0-1,0.45-1,1v2.5H11V10z");
		builder.CloseElement();
		builder.OpenElement(37, "polygon");
		builder.AddAttribute(38, "points", "16,11.5 17.5,11.5 17.5,10 18.5,10 18.5,8.5 17.5,8.5 17.5,5.5 16,5.5 16,8.5 14.5,8.5 14.5,5.5 13,5.5 13,10 16,10");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
