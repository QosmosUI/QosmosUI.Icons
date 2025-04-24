// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiTree : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M20.781 17.375l-2.7-3.375h.919c.373 0 .715-.207.887-.538.172-.331.146-.729-.068-1.035l-7-10c-.317-.452-.94-.562-1.393-.246-.091.063-.158.146-.221.231-.025.015-7.025 10.015-7.025 10.015-.214.306-.24.704-.068 1.035.173.331.515.538.888.538h.919l-2.7 3.375c-.24.301-.287.712-.121 1.059.167.345.518.566.902.566h7v3c0 .553.448 1 1 1s1-.447 1-1v-3h7c.384 0 .735-.221.901-.566.167-.347.12-.758-.12-1.059zm-7.781-.375v-5c0-.553-.448-1-1-1s-1 .447-1 1v5h-4.919l2.7-3.375c.24-.301.287-.712.121-1.059-.167-.345-.518-.566-.902-.566h-1.08l5.08-7.256 5.08 7.256h-1.08c-.384 0-.735.221-.901.566-.167.347-.12.758.121 1.059l2.7 3.375h-4.92z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
