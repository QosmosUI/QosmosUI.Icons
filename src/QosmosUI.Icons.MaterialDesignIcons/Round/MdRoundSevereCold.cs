// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSevereCold : ComponentBase
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
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M20,2c-0.55,0-1,0.45-1,1v3c0,0.55,0.45,1,1,1c0.55,0,1-0.45,1-1V3C21,2.45,20.55,2,20,2z");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "20");
		builder.AddAttribute(28, "cy", "9");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M12,10.41l3.29-3.29c0.39-0.39,0.39-1.02,0-1.41l0,0c-0.39-0.39-1.02-0.39-1.41,0L12,7.59V5c0-0.55-0.45-1-1-1h0 c-0.55,0-1,0.45-1,1v2.59L8.12,5.71c-0.39-0.39-1.02-0.39-1.41,0l0,0c-0.39,0.39-0.39,1.02,0,1.41L10,10.41V12H8.41L5.12,8.71 c-0.39-0.39-1.02-0.39-1.41,0l0,0c-0.39,0.39-0.39,1.02,0,1.41L5.59,12H3c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h2.59l-1.88,1.88 c-0.39,0.39-0.39,1.02,0,1.41l0,0c0.39,0.39,1.02,0.39,1.41,0L8.41,14H10v1.59l-3.29,3.29c-0.39,0.39-0.39,1.02,0,1.41l0,0 c0.39,0.39,1.02,0.39,1.41,0L10,18.41V21c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-2.59l1.88,1.88c0.39,0.39,1.02,0.39,1.41,0l0,0 c0.39-0.39,0.39-1.02,0-1.41L12,15.59V14h1.59l3.29,3.29c0.39,0.39,1.02,0.39,1.41,0l0,0c0.39-0.39,0.39-1.02,0-1.41L16.41,14H19 c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-7V10.41z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
