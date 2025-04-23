// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdForward30 : ComponentBase
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
		builder.AddAttribute(21, "d", "M18,13c0,3.31-2.69,6-6,6s-6-2.69-6-6s2.69-6,6-6v4l5-5l-5-5v4c-4.42,0-8,3.58-8,8c0,4.42,3.58,8,8,8s8-3.58,8-8H18z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M10.06,15.38c-0.29,0-0.62-0.17-0.62-0.54H8.59c0,0.97,0.9,1.23,1.45,1.23c0.87,0,1.51-0.46,1.51-1.25 c0-0.66-0.45-0.9-0.71-1c0.11-0.05,0.65-0.32,0.65-0.92c0-0.21-0.05-1.22-1.44-1.22c-0.62,0-1.4,0.35-1.4,1.16h0.85 c0-0.34,0.31-0.48,0.57-0.48c0.59,0,0.58,0.5,0.58,0.54c0,0.52-0.41,0.59-0.63,0.59H9.56v0.66h0.45c0.65,0,0.7,0.42,0.7,0.64 C10.71,15.11,10.5,15.38,10.06,15.38z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M13.85,11.68c-0.14,0-1.44-0.08-1.44,1.82v0.74c0,1.9,1.31,1.82,1.44,1.82c0.14,0,1.44,0.09,1.44-1.82V13.5 C15.3,11.59,13.99,11.68,13.85,11.68z M14.45,14.35c0,0.77-0.21,1.03-0.59,1.03c-0.38,0-0.6-0.26-0.6-1.03v-0.97 c0-0.75,0.22-1.01,0.59-1.01c0.38,0,0.6,0.26,0.6,1.01V14.35z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
