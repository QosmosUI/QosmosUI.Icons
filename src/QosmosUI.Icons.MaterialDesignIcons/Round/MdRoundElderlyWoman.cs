// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundElderlyWoman : ComponentBase
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
		builder.AddAttribute(21, "d", "M18.52,11c-1.57,0-2.94-0.9-3.6-2.21l-0.79-1.67l0,0C14.12,7.1,13.63,6,12.34,6l0,0C8.72,6,6,16.69,6,19h2.5L7,21 c-0.33,0.44-0.24,1.07,0.2,1.4c0.44,0.33,1.07,0.24,1.4-0.2L11,19h2v3c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-2.71 c0-0.22-0.04-0.43-0.1-0.64L13,13l0.49-2.71c0.81,1.23,2.05,2.14,3.51,2.52V13c0,0.28,0.22,0.5,0.5,0.5S18,13.28,18,13v-0.5 c0-0.28,0.22-0.5,0.5-0.5s0.5,0.22,0.5,0.5v10c0,0.28,0.22,0.5,0.5,0.5s0.5-0.22,0.5-0.5v-10C20,11.71,19.38,11,18.52,11z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M11.6,2.91c-0.06,0.19-0.1,0.38-0.1,0.59c0,1.1,0.9,2,2,2s2-0.9,2-2c0-1.1-0.9-2-2-2c-0.21,0-0.4,0.04-0.59,0.1 C12.76,1.25,12.41,1,12,1c-0.55,0-1,0.45-1,1C11,2.41,11.25,2.76,11.6,2.91z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
