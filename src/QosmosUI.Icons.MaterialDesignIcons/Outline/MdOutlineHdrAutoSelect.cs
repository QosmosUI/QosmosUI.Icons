// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineHdrAutoSelect : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M10,16H6.5v6H10c0.8,0,1.5-0.7,1.5-1.5v-3C11.5,16.7,10.8,16,10,16z M10,20.5H8v-3h2V20.5z");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "3.5,18 1.5,18 1.5,16 0,16 0,22 1.5,22 1.5,19.5 3.5,19.5 3.5,22 5,22 5,16 3.5,16");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "22,18.5 22,16.5 20.5,16.5 20.5,18.5 18.5,18.5 18.5,20 20.5,20 20.5,22 22,22 22,20 24,20 24,18.5");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M16.5,16H13v6h1.5v-2h1.1l0.9,2H18l-0.9-2.1c0.5-0.3,0.9-0.8,0.9-1.4v-1C18,16.7,17.3,16,16.5,16z M16.5,18.5h-2v-1h2 V18.5z");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "points", "11.97,5.3 10.95,8.19 13.05,8.19 12.03,5.3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M12,2C8.69,2,6,4.69,6,8s2.69,6,6,6s6-2.69,6-6S15.31,2,12,2z M14.04,11l-0.63-1.79h-2.83L9.96,11H8.74l2.63-7h1.25 l2.63,7H14.04z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
