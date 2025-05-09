// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWebhook : ComponentBase
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
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M2,16c0-1.84,1-3.45,2.48-4.32C5.15,11.29,6,11.76,6,12.54c0,0.36-0.19,0.68-0.5,0.86C4.6,13.92,4,14.89,4,16 c0,1.85,1.68,3.31,3.6,2.94c1.42-0.28,2.4-1.61,2.4-3.06v0c0-0.49,0.39-0.88,0.88-0.88l5,0c0.27-0.31,0.67-0.5,1.12-0.5 c0.83,0,1.5,0.67,1.5,1.5c0,0.83-0.67,1.5-1.5,1.5c-0.44,0-0.84-0.19-1.12-0.5l-3.98,0c-0.46,2.28-2.48,4-4.9,4 C4.24,21,2,18.76,2,16z M16.37,7c0.65,0,1.14-0.62,0.97-1.25C16.79,3.59,14.83,2,12.5,2c-2.76,0-5,2.24-5,5 c0,1.43,0.6,2.71,1.55,3.62l-2.35,3.9C6.02,14.66,5.5,15.27,5.5,16c0,0.83,0.67,1.5,1.5,1.5s1.5-0.67,1.5-1.5 c0-0.16-0.02-0.31-0.07-0.45l2.86-4.75c0.25-0.41,0.13-0.95-0.28-1.19C10.11,9.08,9.5,8.11,9.5,7c0-1.65,1.35-3,3-3 c1.38,0,2.54,0.93,2.89,2.2C15.52,6.66,15.9,7,16.37,7z M17,13c-0.38,0-0.75,0.07-1.09,0.2c-0.4,0.16-0.86-0.04-1.08-0.41 l-2.6-4.32C11.53,8.35,11,7.74,11,7c0-0.83,0.67-1.5,1.5-1.5S14,6.17,14,7c0,0.15-0.02,0.29-0.06,0.43l2.19,3.65 C16.41,11.03,16.7,11,17,11l0,0c2.76,0,5,2.24,5,5c0,2.76-2.24,5-5,5c-0.86,0-1.68-0.22-2.39-0.61c-0.92-0.5-0.58-1.89,0.47-1.89 c0.17,0,0.34,0.05,0.49,0.14C15.99,18.87,16.48,19,17,19c1.65,0,3-1.35,3-3S18.65,13,17,13z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
