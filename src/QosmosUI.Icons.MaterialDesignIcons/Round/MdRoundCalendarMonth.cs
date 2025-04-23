// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCalendarMonth : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M17,2c-0.55,0-1,0.45-1,1v1H8V3c0-0.55-0.45-1-1-1S6,2.45,6,3v1H5C3.89,4,3.01,4.9,3.01,6L3,20c0,1.1,0.89,2,2,2h14 c1.1,0,2-0.9,2-2V6c0-1.1-0.9-2-2-2h-1V3C18,2.45,17.55,2,17,2z M19,20H5V10h14V20z M11,13c0-0.55,0.45-1,1-1s1,0.45,1,1 s-0.45,1-1,1S11,13.55,11,13z M7,13c0-0.55,0.45-1,1-1s1,0.45,1,1s-0.45,1-1,1S7,13.55,7,13z M15,13c0-0.55,0.45-1,1-1s1,0.45,1,1 s-0.45,1-1,1S15,13.55,15,13z M11,17c0-0.55,0.45-1,1-1s1,0.45,1,1s-0.45,1-1,1S11,17.55,11,17z M7,17c0-0.55,0.45-1,1-1 s1,0.45,1,1s-0.45,1-1,1S7,17.55,7,17z M15,17c0-0.55,0.45-1,1-1s1,0.45,1,1s-0.45,1-1,1S15,17.55,15,17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
