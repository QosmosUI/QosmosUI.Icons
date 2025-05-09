// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHolidayVillage : ComponentBase
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
		builder.AddAttribute(18, "d", "M17,20c0.55,0,1-0.45,1-1V8.76c0-0.27-0.11-0.52-0.29-0.71l-3.76-3.76C13.76,4.11,13.51,4,13.24,4 c-0.89,0-1.34,1.08-0.71,1.71l3.32,3.32C15.95,9.12,16,9.25,16,9.38V19C16,19.55,16.45,20,17,20z M21,20c0.55,0,1-0.45,1-1V7.11 c0-0.26-0.11-0.52-0.29-0.71l-2.1-2.11C19.42,4.11,19.16,4,18.9,4C18,4,17.56,5.08,18.19,5.71l1.67,1.67C19.95,7.47,20,7.6,20,7.73 V19C20,19.55,20.45,20,21,20z M8,15c0.55,0,1,0.45,1,1v4h4c0.55,0,1-0.45,1-1v-8.59c0-0.27-0.11-0.52-0.29-0.71l-5-5 c-0.39-0.39-1.02-0.39-1.41,0l-5,5C2.11,9.89,2,10.15,2,10.41V19c0,0.55,0.45,1,1,1h4v-4C7,15.45,7.45,15,8,15z M8,13 c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S8.55,13,8,13z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
