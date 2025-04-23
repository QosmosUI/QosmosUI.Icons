// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDryCleaning : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M19.56,11.36L13,8.44V7c0-0.55-0.45-1-1-1s-1-0.45-1-1s0.45-1,1-1c0.38,0,0.72,0.22,0.88,0.53C13.04,4.84,13.39,5,13.73,5 c0.74,0,1.26-0.79,0.91-1.44c-0.6-1.1-1.86-1.78-3.24-1.51c-1.17,0.23-2.12,1.2-2.34,2.37C8.77,5.98,9.67,7.35,11,7.82v0.63 l-6.56,2.92C3.56,11.75,3,12.62,3,13.57v0.01C3,14.92,4.08,16,5.42,16H7v4c0,1.1,0.9,2,2,2h6c1.1,0,2-0.9,2-2v-4h1.58 c1.34,0,2.42-1.08,2.42-2.42v-0.01C21,12.62,20.44,11.75,19.56,11.36z M18.58,14h-1.86c-0.35-0.6-0.98-1-1.72-1H9 c-0.74,0-1.38,0.4-1.72,1H5.42c-0.46,0-0.58-0.65-0.17-0.81l6.75-3l6.75,3C19.17,13.38,19.03,14,18.58,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
