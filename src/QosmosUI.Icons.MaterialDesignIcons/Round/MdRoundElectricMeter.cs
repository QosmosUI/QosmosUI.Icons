// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundElectricMeter : ComponentBase
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
		builder.AddAttribute(24, "d", "M11.73,2C7.05,2.14,3.15,6.03,3,10.71c-0.13,4.04,2.42,7.5,6,8.77V21c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-1.06 c0.33,0.04,0.66,0.06,1,0.06s0.67-0.02,1-0.06V21c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-1.53c3.49-1.24,6-4.57,6-8.47 C21,5.95,16.82,1.85,11.73,2z M13.54,14.71L12,16.25c-0.41,0.41-1.09,0.41-1.5,0h0c-0.41-0.41-0.41-1.09,0-1.5l0.5-0.5l-0.54-0.54 c-0.39-0.39-0.39-1.02,0-1.41L12,10.75c0.41-0.41,1.09-0.41,1.5,0l0,0c0.41,0.41,0.41,1.09,0,1.5l-0.5,0.5l0.54,0.54 C13.93,13.68,13.93,14.32,13.54,14.71z M15,9H9C8.45,9,8,8.55,8,8v0c0-0.55,0.45-1,1-1h6c0.55,0,1,0.45,1,1v0C16,8.55,15.55,9,15,9 z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
