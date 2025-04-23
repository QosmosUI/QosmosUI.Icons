// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAppShortcut : ComponentBase
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
		builder.AddAttribute(21, "height", "1");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "width", "10");
		builder.AddAttribute(24, "x", "7");
		builder.AddAttribute(25, "y", "20");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "1");
		builder.AddAttribute(28, "opacity", ".3");
		builder.AddAttribute(29, "width", "10");
		builder.AddAttribute(30, "x", "7");
		builder.AddAttribute(31, "y", "3");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M17,18H7V6h10v1h2V3c0-1.1-0.9-2-2-2H7C5.9,1,5,1.9,5,3v18c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2v-4h-2V18z M7,3h10v1H7V3z M17,21H7v-1h10V21z");
		builder.CloseElement();
		builder.OpenElement(34, "polygon");
		builder.AddAttribute(35, "points", "20.38,9.62 21,11 21.62,9.62 23,9 21.62,8.38 21,7 20.38,8.38 19,9");
		builder.CloseElement();
		builder.OpenElement(36, "polygon");
		builder.AddAttribute(37, "points", "16,8 14.75,10.75 12,12 14.75,13.25 16,16 17.25,13.25 20,12 17.25,10.75");
		builder.CloseElement();
		builder.OpenElement(38, "polygon");
		builder.AddAttribute(39, "points", "21,13 20.38,14.38 19,15 20.38,15.62 21,17 21.62,15.62 23,15 21.62,14.38");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
