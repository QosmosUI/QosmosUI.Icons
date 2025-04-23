// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSuperscript : ComponentBase
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
		builder.AddAttribute(18, "x", "0");
		builder.AddAttribute(19, "y", "0");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M10.51,12.73L7.3,7.72C6.82,6.97,7.35,6,8.23,6h0c0.39,0,0.74,0.2,0.95,0.53l2.76,4.46h0.12l2.74-4.45 C15,6.2,15.36,6,15.75,6h0c0.88,0,1.42,0.98,0.94,1.72l-3.23,5l3.55,5.55C17.5,19.02,16.96,20,16.08,20h0 c-0.38,0-0.74-0.2-0.95-0.52l-3.07-4.89h-0.12l-3.07,4.89C8.66,19.8,8.31,20,7.92,20h0c-0.88,0-1.42-0.97-0.94-1.72L10.51,12.73z M23,8.5L23,8.5C23,8.22,22.78,8,22.5,8c0,0,0,0,0,0H20V7h2c0.55,0,1-0.45,1-1V5c0-0.55-0.45-1-1-1h-2.5C19.22,4,19,4.22,19,4.5v0 C19,4.78,19.22,5,19.5,5H22v1h-2c-0.55,0-1,0.45-1,1v1c0,0.55,0.45,1,1,1h2.5C22.78,9,23,8.78,23,8.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
