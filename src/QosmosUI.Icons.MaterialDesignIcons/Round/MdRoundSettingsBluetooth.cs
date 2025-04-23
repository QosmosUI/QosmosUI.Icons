// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSettingsBluetooth : ComponentBase
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
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "12");
		builder.AddAttribute(22, "cy", "23");
		builder.AddAttribute(23, "r", "1");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "8");
		builder.AddAttribute(26, "cy", "23");
		builder.AddAttribute(27, "r", "1");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "16");
		builder.AddAttribute(30, "cy", "23");
		builder.AddAttribute(31, "r", "1");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M13.41,10L17,6.42c0.39-0.39,0.39-1.02,0-1.42l-4.79-4.79C12.07,0.07,11.89,0,11.71,0C11.32,0,11,0.32,11,0.71v6.88 L7.11,3.71c-0.39-0.39-1.02-0.39-1.41,0c-0.39,0.39-0.39,1.02,0,1.41L10.59,10l-4.89,4.89c-0.39,0.39-0.39,1.02,0,1.41 c0.39,0.39,1.02,0.39,1.41,0L11,12.41v6.88c0,0.39,0.32,0.71,0.71,0.71c0.19,0,0.37-0.07,0.5-0.21L17,15 c0.39-0.39,0.39-1.02,0-1.42L13.41,10z M13,3.83l1.88,1.88L13,7.59V3.83z M13,16.17v-3.76l1.88,1.88L13,16.17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
