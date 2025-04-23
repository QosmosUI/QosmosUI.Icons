// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundStackedLineChart : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M2.79,14.78L2.7,14.69c-0.39-0.39-0.39-1.02,0-1.41l6.09-6.1c0.39-0.39,1.02-0.39,1.41,0l3.29,3.29l6.39-7.18 c0.38-0.43,1.05-0.44,1.45-0.04l0,0c0.37,0.38,0.39,0.98,0.04,1.37l-7.17,8.07c-0.38,0.43-1.04,0.45-1.45,0.04L9.5,9.48l-5.3,5.3 C3.82,15.17,3.18,15.17,2.79,14.78z M4.2,20.78l5.3-5.3l3.25,3.25c0.41,0.41,1.07,0.39,1.45-0.04l7.17-8.07 c0.35-0.39,0.33-0.99-0.04-1.37l0,0c-0.4-0.4-1.07-0.39-1.45,0.04l-6.39,7.18l-3.29-3.29c-0.39-0.39-1.02-0.39-1.41,0l-6.09,6.1 c-0.39,0.39-0.39,1.02,0,1.41l0.09,0.09C3.18,21.17,3.82,21.17,4.2,20.78z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
