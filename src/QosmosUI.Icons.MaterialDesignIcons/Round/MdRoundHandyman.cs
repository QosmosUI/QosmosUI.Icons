// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHandyman : ComponentBase
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
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M21.67,18.17l-4.72-4.72c-0.48-0.48-0.99-0.59-1.58-0.59l-2.54,2.54c0,0.59,0.11,1.11,0.59,1.58l4.72,4.72 c0.39,0.39,1.02,0.39,1.41,0l2.12-2.12C22.06,19.2,22.06,18.56,21.67,18.17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M16.63,9.49c0.39,0.39,1.02,0.39,1.41,0l0.71-0.71l2.12,2.12c1.17-1.17,1.17-3.07,0-4.24l-2.83-2.83 c-0.39-0.39-1.02-0.39-1.41,0l-0.71,0.71V2c0-0.62-0.76-0.95-1.21-0.5l-2.54,2.54c-0.45,0.45-0.12,1.21,0.5,1.21h2.54l-0.71,0.71 c-0.39,0.39-0.39,1.02,0,1.41l0.35,0.35l-2.89,2.89L7.85,6.48v-1c0-0.27-0.11-0.52-0.29-0.71L5.54,2.74 c-0.39-0.39-1.02-0.39-1.41,0L2.71,4.16c-0.39,0.39-0.39,1.02,0,1.41L4.73,7.6c0.19,0.19,0.44,0.29,0.71,0.29h1l4.13,4.13 l-0.85,0.85H8.42c-0.53,0-1.04,0.21-1.41,0.59l-4.72,4.72c-0.39,0.39-0.39,1.02,0,1.41l2.12,2.12c0.39,0.39,1.02,0.39,1.41,0 l4.72-4.72c0.38-0.38,0.59-0.88,0.59-1.41v-1.29l5.15-5.15L16.63,9.49z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
