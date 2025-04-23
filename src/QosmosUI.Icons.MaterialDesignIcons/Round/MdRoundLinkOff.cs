// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundLinkOff : ComponentBase
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
		builder.AddAttribute(20, "d", "M14,9h2.87c1.46,0,2.8,0.98,3.08,2.42c0.31,1.64-0.74,3.11-2.22,3.48l1.53,1.53c1.77-0.91,2.95-2.82,2.7-5.01 C21.68,8.86,19.37,7,16.79,7H14c-0.55,0-1,0.45-1,1C13,8.55,13.45,9,14,9z M3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0 c-0.39,0.39-0.39,1.02,0,1.41l2.64,2.64c-1.77,0.91-2.95,2.82-2.7,5.01C2.32,15.14,4.63,17,7.21,17H10c0.55,0,1-0.45,1-1 c0-0.55-0.45-1-1-1H7.13c-1.46,0-2.8-0.98-3.08-2.42C3.74,10.94,4.8,9.47,6.27,9.1l2.12,2.12C8.16,11.41,8,11.68,8,12 c0,0.55,0.45,1,1,1h1.17l8.9,8.9c0.39,0.39,1.02,0.39,1.41,0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51z M14,11l1.71,1.71 C15.89,12.53,16,12.28,16,12c0-0.55-0.45-1-1-1H14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
