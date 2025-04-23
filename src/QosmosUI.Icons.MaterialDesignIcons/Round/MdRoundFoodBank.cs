// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFoodBank : ComponentBase
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
		builder.AddAttribute(18, "d", "M10.8,3.9l-6,4.5C4.3,8.78,4,9.37,4,10v9c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2v-9c0-0.63-0.3-1.22-0.8-1.6l-6-4.5 C12.49,3.37,11.51,3.37,10.8,3.9z M12.5,12.5c0,0.83-0.67,1.5-1.5,1.5v3.5c0,0.28-0.22,0.5-0.5,0.5h0c-0.28,0-0.5-0.22-0.5-0.5V14 c-0.83,0-1.5-0.67-1.5-1.5V10c0-0.28,0.22-0.5,0.5-0.5h0c0.28,0,0.5,0.22,0.5,0.5v2.5H10V10c0-0.28,0.22-0.5,0.5-0.5h0 c0.28,0,0.5,0.22,0.5,0.5v2.5h0.5V10c0-0.28,0.22-0.5,0.5-0.5h0c0.28,0,0.5,0.22,0.5,0.5V12.5z M14.5,18L14.5,18 c-0.28,0-0.5-0.22-0.5-0.5v-3h-0.5c-0.28,0-0.5-0.22-0.5-0.5v-2.5c0-0.88,0.57-1.63,1.36-1.89C14.67,9.5,15,9.75,15,10.09v7.41 C15,17.78,14.78,18,14.5,18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
