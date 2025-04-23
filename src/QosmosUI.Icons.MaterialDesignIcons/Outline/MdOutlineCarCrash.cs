// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineCarCrash : ComponentBase
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
		builder.AddAttribute(21, "d", "M18,1c-2.76,0-5,2.24-5,5s2.24,5,5,5s5-2.24,5-5S20.76,1,18,1z M18.5,7h-1V3h1V7z M18.5,8v1h-1V8H18.5z M6,13.5 C6,12.67,6.67,12,7.5,12S9,12.67,9,13.5S8.33,15,7.5,15S6,14.33,6,13.5z M19,12.93c0.65-0.09,1.34-0.28,2-0.6h0V19 c0,0.55-0.45,1-1,1h-1c-0.55,0-1-0.45-1-1v-1H6v1c0,0.55-0.45,1-1,1H4c-0.55,0-1-0.45-1-1v-8l2.08-5.99C5.29,4.42,5.84,4,6.5,4 l4.79,0C11.1,4.63,11,5.31,11,6H6.85L5.81,9h5.86v0c0.36,0.75,0.84,1.43,1.43,2L5,11v5h14L19,12.93z M17.91,13 c-0.89-0.01-1.74-0.19-2.53-0.51C15.15,12.76,15,13.11,15,13.5c0,0.83,0.67,1.5,1.5,1.5s1.5-0.67,1.5-1.5 C18,13.32,17.97,13.16,17.91,13z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
