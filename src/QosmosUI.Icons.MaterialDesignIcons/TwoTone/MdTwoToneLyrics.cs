// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneLyrics : ComponentBase
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
		builder.AddAttribute(21, "d", "M4,4v14l2-2h9v-4.03c-0.62-0.83-1-1.85-1-2.97c0-1.12,0.38-2.14,1-2.97V4H4z M10,14H6v-2h4V14z M13,11H6V9 h7V11z M13,8H6V6h7V8z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "height", "2");
		builder.AddAttribute(25, "width", "4");
		builder.AddAttribute(26, "x", "6");
		builder.AddAttribute(27, "y", "12");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "height", "2");
		builder.AddAttribute(30, "width", "7");
		builder.AddAttribute(31, "x", "6");
		builder.AddAttribute(32, "y", "6");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M15,11.97V16H6l-2,2V4h11v2.03c0.52-0.69,1.2-1.25,2-1.6V4c0-1.1-0.9-2-2-2H4C2.9,2,2.01,2.9,2.01,4L2,22l4-4h9 c1.1,0,2-0.9,2-2v-2.42C16.2,13.22,15.52,12.66,15,11.97z");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "height", "2");
		builder.AddAttribute(37, "width", "7");
		builder.AddAttribute(38, "x", "6");
		builder.AddAttribute(39, "y", "9");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M20,6.18C19.69,6.07,19.35,6,19,6c-1.66,0-3,1.34-3,3c0,1.66,1.34,3,3,3s3-1.34,3-3V3h2V1h-4V6.18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
