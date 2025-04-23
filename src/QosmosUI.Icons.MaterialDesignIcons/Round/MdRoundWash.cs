// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWash : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M1.94,11.79C1.34,12.35,1,13.14,1,13.97V20c0,1.66,1.34,3,3,3l13.68,0c0.65,0,1.25-0.47,1.32-1.12 c0.08-0.75-0.51-1.38-1.24-1.38H12.5c-0.28,0-0.5-0.22-0.5-0.5v0c0-0.28,0.22-0.5,0.5-0.5l7.18,0c0.65,0,1.25-0.47,1.32-1.12 c0.08-0.75-0.51-1.38-1.24-1.38H12.5c-0.28,0-0.5-0.22-0.5-0.5l0,0c0-0.28,0.22-0.5,0.5-0.5l8.18,0c0.65,0,1.25-0.47,1.32-1.12 c0.08-0.75-0.51-1.38-1.24-1.38H12.5c-0.28,0-0.5-0.22-0.5-0.5v0c0-0.28,0.22-0.5,0.5-0.5l6.18,0c0.65,0,1.25-0.47,1.32-1.12 c0.08-0.75-0.51-1.38-1.24-1.38H8.86l1.49-2.61c0.09-0.16,0.14-0.33,0.14-0.53c0-0.26-0.09-0.5-0.26-0.7L9.81,5.71 C9.43,5.32,8.8,5.3,8.4,5.68L1.94,11.79z M18.5,8C19.88,8,21,6.88,21,5.5c0-1.25-1.41-3.16-2.11-4.04c-0.2-0.25-0.57-0.25-0.77,0 C17.41,2.34,16,4.25,16,5.5C16,6.88,17.12,8,18.5,8z M13.5,9C14.33,9,15,8.33,15,7.5c0-0.56-0.67-1.49-1.11-2.04 c-0.2-0.25-0.58-0.25-0.77,0C12.67,6.01,12,6.94,12,7.5C12,8.33,12.67,9,13.5,9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
