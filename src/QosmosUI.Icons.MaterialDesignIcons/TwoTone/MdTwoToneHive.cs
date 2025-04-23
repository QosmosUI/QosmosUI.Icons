// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneHive : ComponentBase
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
		builder.AddAttribute(22, "points", "5.92,7 4.79,9 5.92,11 8.06,11 9.19,9 8.06,7");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "opacity", ".3");
		builder.AddAttribute(25, "points", "10.94,16 9.8,18.02 10.92,20 13.08,20 14.2,18.02 13.06,16");
		builder.CloseElement();
		builder.OpenElement(26, "polygon");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "points", "13.06,14 14.19,12 13.06,10 10.94,10 9.81,12 10.94,14");
		builder.CloseElement();
		builder.OpenElement(29, "polygon");
		builder.AddAttribute(30, "opacity", ".3");
		builder.AddAttribute(31, "points", "5.92,13 4.79,15 5.92,17 8.06,17 9.19,15 8.06,13");
		builder.CloseElement();
		builder.OpenElement(32, "polygon");
		builder.AddAttribute(33, "opacity", ".3");
		builder.AddAttribute(34, "points", "15.94,7 14.81,9 15.94,11 18.08,11 19.21,9 18.08,7");
		builder.CloseElement();
		builder.OpenElement(35, "polygon");
		builder.AddAttribute(36, "opacity", ".3");
		builder.AddAttribute(37, "points", "10.92,4 9.8,5.98 10.94,8 13.06,8 14.2,5.98 13.08,4");
		builder.CloseElement();
		builder.OpenElement(38, "polygon");
		builder.AddAttribute(39, "opacity", ".3");
		builder.AddAttribute(40, "points", "15.94,13 14.81,15 15.94,17 18.08,17 19.21,15 18.08,13");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M21.5,9l-2.25-4h-3.31l-1.69-3h-4.5L8.06,5H4.75L2.5,9l1.69,3L2.5,15l2.25,4h3.31l1.69,3h4.5l1.69-3h3.31l2.25-4l-1.69-3 L21.5,9z M8.06,17H5.92l-1.12-2l1.12-2h2.14l1.12,2L8.06,17z M8.06,11H5.92L4.79,9l1.12-2h2.14l1.12,2L8.06,11z M13.08,20h-2.16 L9.8,18.02L10.94,16h2.12l1.13,2.02L13.08,20z M9.81,12l1.12-2h2.12l1.12,2l-1.12,2h-2.12L9.81,12z M13.06,8h-2.12L9.8,5.98 L10.92,4h2.16l1.12,1.98L13.06,8z M18.08,17h-2.14l-1.12-2l1.12-2h2.14l1.12,2L18.08,17z M18.08,11h-2.14l-1.12-2l1.12-2h2.14 l1.12,2L18.08,11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
