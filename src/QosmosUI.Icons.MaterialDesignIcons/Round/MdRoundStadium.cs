// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundStadium : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M6.11,5.45L3.72,6.64C3.39,6.8,3,6.56,3,6.19V3.81C3,3.44,3.39,3.2,3.72,3.36l2.38,1.19C6.47,4.74,6.47,5.26,6.11,5.45z M18,3.81v2.38c0,0.37,0.39,0.61,0.72,0.45l2.38-1.19c0.37-0.18,0.37-0.71,0-0.89l-2.38-1.19C18.39,3.2,18,3.44,18,3.81z M11,2.81 v2.38c0,0.37,0.39,0.61,0.72,0.45l2.38-1.19c0.37-0.18,0.37-0.71,0-0.89l-2.38-1.19C11.39,2.2,11,2.44,11,2.81z M5,10.04 C6.38,10.53,8.77,11,12,11s5.62-0.47,7-0.96C19,9.86,16.22,9,12,9S5,9.86,5,10.04z M14,17h-4c-0.55,0-1,0.45-1,1l0,3.88 C4.94,21.49,2,20.34,2,19v-9c0-1.66,4.48-3,10-3s10,1.34,10,3v9c0,1.34-2.94,2.48-7,2.87L15,18C15,17.45,14.55,17,14,17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
