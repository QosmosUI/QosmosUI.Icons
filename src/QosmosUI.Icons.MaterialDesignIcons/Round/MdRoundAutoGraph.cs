// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAutoGraph : ComponentBase
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
		builder.AddAttribute(19, "d", "M14.06,9.94L13,9.45c-0.39-0.18-0.39-0.73,0-0.91l1.06-0.49L14.55,7c0.18-0.39,0.73-0.39,0.91,0l0.49,1.06L17,8.55 c0.39,0.18,0.39,0.73,0,0.91l-1.06,0.49L15.45,11c-0.18,0.39-0.73,0.39-0.91,0L14.06,9.94z M4.45,13l0.49-1.06L6,11.45 c0.39-0.18,0.39-0.73,0-0.91l-1.06-0.49L4.45,9C4.28,8.61,3.72,8.61,3.55,9l-0.49,1.06L2,10.55c-0.39,0.18-0.39,0.73,0,0.91 l1.06,0.49L3.55,13C3.72,13.39,4.28,13.39,4.45,13z M8.96,7.99l0.63-1.4l1.4-0.63c0.39-0.18,0.39-0.73,0-0.91l-1.4-0.63l-0.63-1.4 c-0.18-0.39-0.73-0.39-0.91,0l-0.63,1.4l-1.4,0.63c-0.39,0.18-0.39,0.73,0,0.91l1.4,0.63l0.63,1.4C8.22,8.38,8.78,8.38,8.96,7.99z M22.34,8.27c-0.4-0.4-1.07-0.39-1.45,0.04l-6.39,7.18l-3.29-3.29c-0.39-0.39-1.02-0.39-1.41,0l-6.04,6.05 c-0.41,0.41-0.41,1.09,0,1.5c0.41,0.41,1.09,0.41,1.5,0l5.25-5.26l3.25,3.25c0.41,0.41,1.07,0.39,1.45-0.04l7.17-8.07 C22.73,9.24,22.71,8.64,22.34,8.27z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
