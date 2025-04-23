// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneLandslide : ComponentBase
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
		builder.AddAttribute(22, "points", "8.57,12.09 7,10 4,10 4,12.28 6,12.95");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "opacity", ".3");
		builder.AddAttribute(25, "points", "12.53,14.77 9.95,13.74 6,15.05 4,14.39 4,16.28 6,16.95");
		builder.CloseElement();
		builder.OpenElement(26, "polygon");
		builder.AddAttribute(27, "opacity", ".3");
		builder.AddAttribute(28, "points", "15,4.65 15,2.64 12.42,2.12 11,3.07 11,4.93 12.23,5.75");
		builder.CloseElement();
		builder.OpenElement(29, "polygon");
		builder.AddAttribute(30, "opacity", ".3");
		builder.AddAttribute(31, "points", "6,19.05 4,18.39 4,20 18,20 15.03,16.04");
		builder.CloseElement();
		builder.OpenElement(32, "polygon");
		builder.AddAttribute(33, "opacity", ".3");
		builder.AddAttribute(34, "points", "18,9.96 18,11.04 18.8,11.68 21,10.7 21,9.6 19,9.16");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M11,12L8,8H2v14h20l-6-8L11,12z M4,10h3l1.57,2.09L6,12.95l-2-0.67V10z M4,14.39l2,0.67l3.95-1.32l2.58,1.03L6,16.95 l-2-0.67V14.39z M4,20v-1.61l2,0.67l9.03-3.01L18,20H4z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M17,6V1l-5-1L9,2v4l3,2L17,6z M11,3.07l1.42-0.95L15,2.64v2.01l-2.77,1.11L11,4.93V3.07z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M18.5,7L16,9v3l2.5,2l4.5-2V8L18.5,7z M21,10.7l-2.2,0.98L18,11.04V9.96l1-0.8l2,0.44V10.7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
