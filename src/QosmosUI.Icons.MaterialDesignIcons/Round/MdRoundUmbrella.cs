// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundUmbrella : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M17.12,6.28L14.5,6.92L13,5.77V3.88V3.4c0-0.26,0.22-0.48,0.5-0.48c0.23,0,0.43,0.16,0.49,0.36C14.1,3.7,14.49,4,14.94,4 c0.55,0,1-0.45,1-1c0-0.1-0.02-0.2-0.05-0.3C15.59,1.72,14.63,1,13.5,1C12.12,1,11,2.07,11,3.4v0.48v1.89L9.5,6.92L6.88,6.28 C6.5,6.19,6.16,6.55,6.28,6.92l4.77,14.39C11.2,21.77,11.6,22,12,22s0.8-0.23,0.95-0.69l4.77-14.39 C17.84,6.55,17.5,6.19,17.12,6.28z M11,14.8L9.03,8.86l0.92,0.23l0.76-0.58L11,8.29V14.8z M13,14.8V8.29l0.28,0.22l0.76,0.58 l0.92-0.23L13,14.8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
