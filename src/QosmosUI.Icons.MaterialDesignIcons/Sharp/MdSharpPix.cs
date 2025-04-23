// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpPix : ComponentBase
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
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M15.45,16.52l-3.01-3.01c-0.11-0.11-0.24-0.13-0.31-0.13s-0.2,0.02-0.31,0.13L8.8,16.53c-0.34,0.34-0.87,0.89-2.64,0.89 l3.71,3.7c1.17,1.17,3.07,1.17,4.24,0l3.72-3.71C16.92,17.41,16.16,17.23,15.45,16.52z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M8.8,7.47l3.02,3.02c0.08,0.08,0.2,0.13,0.31,0.13s0.23-0.05,0.31-0.13l2.99-2.99c0.71-0.74,1.52-0.91,2.43-0.91 l-3.72-3.71c-1.17-1.17-3.07-1.17-4.24,0l-3.71,3.7C7.95,6.58,8.49,7.16,8.8,7.47z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M21.11,9.85l-2.25-2.26H17.6c-0.54,0-1.08,0.22-1.45,0.61l-3,3c-0.28,0.28-0.65,0.42-1.02,0.42 c-0.36,0-0.74-0.15-1.02-0.42L8.09,8.17c-0.38-0.38-0.9-0.6-1.45-0.6H5.17l-2.29,2.3c-1.17,1.17-1.17,3.07,0,4.24l2.29,2.3h1.48 c0.54,0,1.06-0.22,1.45-0.6l3.02-3.02c0.28-0.28,0.65-0.42,1.02-0.42c0.37,0,0.74,0.14,1.02,0.42l3.01,3.01 c0.38,0.38,0.9,0.6,1.45,0.6h1.26l2.25-2.26C22.3,12.96,22.3,11.04,21.11,9.85z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
