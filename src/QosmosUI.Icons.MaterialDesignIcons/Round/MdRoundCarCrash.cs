// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCarCrash : ComponentBase
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
		builder.AddAttribute(25, "d", "M18,1c-2.76,0-5,2.24-5,5s2.24,5,5,5s5-2.24,5-5S20.76,1,18,1z M18,7c-0.28,0-0.5-0.22-0.5-0.5v-3C17.5,3.22,17.72,3,18,3 s0.5,0.22,0.5,0.5v3C18.5,6.78,18.28,7,18,7z M18.5,8.5C18.5,8.78,18.28,9,18,9s-0.5-0.22-0.5-0.5S17.72,8,18,8 S18.5,8.22,18.5,8.5z M19.5,20c0.82,0,1.5-0.67,1.5-1.5v-6.18c-1.05,0.51-2.16,0.69-3.09,0.68c0.06,0.16,0.09,0.33,0.09,0.5 c0,0.83-0.67,1.5-1.5,1.5S15,14.33,15,13.5c0-0.39,0.15-0.74,0.39-1.01c-1.63-0.66-2.96-1.91-3.71-3.49H5.81l1.04-3H11 c0-0.69,0.1-1.37,0.29-2H6.5C5.84,4,5.29,4.42,5.08,5.01l-1.97,5.67C3.04,10.89,3,11.11,3,11.34v7.16C3,19.33,3.67,20,4.5,20 S6,19.33,6,18.5V18h12v0.5C18,19.33,18.68,20,19.5,20z M7.5,15C6.67,15,6,14.33,6,13.5S6.67,12,7.5,12S9,12.67,9,13.5 S8.33,15,7.5,15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
