// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcMoneyTransfer : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#78909C");
		builder.AddAttribute(15, "d", "M40,41H8c-2.2,0-4-1.8-4-4l0-20.9c0-1.3,0.6-2.5,1.7-3.3L24,0l18.3,12.8c1.1,0.7,1.7,2,1.7,3.3V37 C44,39.2,42.2,41,40,41z");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "14");
		builder.AddAttribute(18, "y", "1");
		builder.AddAttribute(19, "fill", "#AED581");
		builder.AddAttribute(20, "width", "20");
		builder.AddAttribute(21, "height", "31");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#558B2F");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M13,0v33h22V0H13z M33,31H15V2h18V31z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M34,3c0,1.7-0.3,3-2,3c-1.7,0-3-1.3-3-3s1.3-2,3-2C33.7,1,34,1.3,34,3z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M16,1c1.7,0,3,0.3,3,2s-1.3,3-3,3s-2-1.3-2-3S14.3,1,16,1z");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "24");
		builder.AddAttribute(32, "cy", "8");
		builder.AddAttribute(33, "r", "2");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "24");
		builder.AddAttribute(36, "cy", "20");
		builder.AddAttribute(37, "r", "6");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "fill", "#CFD8DC");
		builder.AddAttribute(40, "d", "M40,41H8c-2.2,0-4-1.8-4-4l0-20l20,13l20-13v20C44,39.2,42.2,41,40,41z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
