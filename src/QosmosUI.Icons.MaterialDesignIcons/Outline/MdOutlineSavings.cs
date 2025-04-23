// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineSavings : ComponentBase
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
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M15,10c0-0.55,0.45-1,1-1s1,0.45,1,1c0,0.55-0.45,1-1,1S15,10.55,15,10z M8,9h5V7H8V9z M22,7.5v6.97l-2.82,0.94L17.5,21 L12,21v-2h-2v2l-5.5,0C4.5,21,2,12.54,2,9.5S4.46,4,7.5,4l5,0c0.91-1.21,2.36-2,4-2C17.33,2,18,2.67,18,3.5 c0,0.21-0.04,0.4-0.12,0.58c-0.14,0.34-0.26,0.73-0.32,1.15l2.27,2.27H22z M20,9.5h-1L15.5,6c0-0.65,0.09-1.29,0.26-1.91 C14.79,4.34,14,5.06,13.67,6L7.5,6C5.57,6,4,7.57,4,9.5c0,1.88,1.22,6.65,2.01,9.5L8,19v-2h6v2l2.01,0l1.55-5.15L20,13.03V9.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
