// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRocketLaunch : ComponentBase
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
		builder.AddAttribute(25, "d", "M9.19,6.35c-2.04,2.29-3.44,5.58-3.57,5.89l-2.26-0.97c-0.65-0.28-0.81-1.13-0.31-1.63l3.01-3.01 c0.47-0.47,1.15-0.68,1.81-0.55L9.19,6.35L9.19,6.35z M10.68,16.51c0.3,0.3,0.74,0.38,1.12,0.2c1.16-0.54,3.65-1.81,5.26-3.42 c4.59-4.59,4.63-8.33,4.36-9.93c-0.07-0.4-0.39-0.72-0.79-0.79c-1.6-0.27-5.34-0.23-9.93,4.36c-1.61,1.61-2.87,4.1-3.42,5.26 c-0.18,0.38-0.09,0.83,0.2,1.12L10.68,16.51z M17.65,14.81c-2.29,2.04-5.58,3.44-5.89,3.57l0.97,2.26 c0.28,0.65,1.13,0.81,1.63,0.31l3.01-3.01c0.47-0.47,0.68-1.15,0.55-1.81L17.65,14.81L17.65,14.81z M8.94,17.41 c0.2,1.06-0.15,2.04-0.82,2.71c-0.77,0.77-3.16,1.34-4.71,1.64c-0.69,0.13-1.3-0.48-1.17-1.17c0.3-1.55,0.86-3.94,1.64-4.71 c0.67-0.67,1.65-1.02,2.71-0.82C7.76,15.28,8.72,16.24,8.94,17.41z M13,9c0-1.1,0.9-2,2-2s2,0.9,2,2s-0.9,2-2,2S13,10.1,13,9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
