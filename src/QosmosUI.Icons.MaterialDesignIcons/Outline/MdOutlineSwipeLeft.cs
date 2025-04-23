// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineSwipeLeft : ComponentBase
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
		builder.AddAttribute(20, "d", "M18.89,13.77l-3.8-1.67C14.96,12.04,14.81,12,14.65,12H14V7.5C14,6.12,12.88,5,11.5,5S9,6.12,9,7.5v8.15l-1.87-0.4 c-0.19-0.03-1.02-0.15-1.73,0.56L4,17.22l5.12,5.19C9.49,22.79,10,23,10.53,23h6.55c0.98,0,1.81-0.7,1.97-1.67l0.92-5.44 C20.12,15.03,19.68,14.17,18.89,13.77z M17.08,21h-6.55l-3.7-3.78L11,18.11V7.5C11,7.22,11.22,7,11.5,7S12,7.22,12,7.5v6.18h1.76 L18,15.56L17.08,21z M4.09,5.5H7V7H2V2h1.5v2.02C5.82,2.13,8.78,1,12,1c5.49,0,9.27,3.12,10,6h-1.57C19.67,5.02,16.74,2.5,12,2.5 C8.97,2.5,6.21,3.64,4.09,5.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
