// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSatelliteAlt : ComponentBase
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
		builder.AddAttribute(20, "opacity", ".3");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M6.6,19.32l-1.06,1.06L2,16.85l1.06-1.06L6.6,19.32z M8.72,17.2l-1.06,1.06l-3.54-3.54l1.06-1.06L8.72,17.2z M13.67,12.25 l-1.41,1.41l-3.54-3.54l1.41-1.41L13.67,12.25z M18.26,7.66L17.2,8.72l-3.54-3.54l1.06-1.06L18.26,7.66z M20.38,5.54L19.32,6.6 l-3.54-3.54L16.85,2L20.38,5.54z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M15.44,0.59l-3.18,3.18c-0.78,0.78-0.78,2.05,0,2.83l1.24,1.24l-0.71,0.71L11.55,7.3c-0.78-0.78-2.05-0.78-2.83,0 L7.3,8.72c-0.78,0.78-0.78,2.05,0,2.83l1.24,1.24l-0.71,0.71L6.6,12.25c-0.78-0.78-2.05-0.78-2.83,0l-3.18,3.18 c-0.78,0.78-0.78,2.05,0,2.83l3.54,3.54c0.78,0.78,2.05,0.78,2.83,0l3.18-3.18c0.78-0.78,0.78-2.05,0-2.83l-1.24-1.24l0.71-0.71 l1.24,1.24c0.78,0.78,2.05,0.78,2.83,0l1.41-1.41c0.78-0.78,0.78-2.05,0-2.83L13.84,9.6l0.71-0.71l1.24,1.24 c0.78,0.78,2.05,0.78,2.83,0l3.18-3.18c0.78-0.78,0.78-2.05,0-2.83l-3.54-3.54C17.48-0.2,16.22-0.2,15.44,0.59z M6.6,19.32 l-1.06,1.06L2,16.85l1.06-1.06L6.6,19.32z M8.72,17.2l-1.06,1.06l-3.54-3.54l1.06-1.06L8.72,17.2z M13.67,12.25l-1.41,1.41 l-3.54-3.54l1.41-1.41L13.67,12.25z M18.26,7.66L17.2,8.72l-3.54-3.54l1.06-1.06L18.26,7.66z M20.38,5.54L19.32,6.6l-3.54-3.54 L16.85,2L20.38,5.54z M21,14l2,0c0,4.97-4.03,9-9,9l0-2C17.87,21,21,17.87,21,14z M17,14l2,0c0,2.76-2.24,5-5,5l0-2 C15.66,17,17,15.66,17,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
