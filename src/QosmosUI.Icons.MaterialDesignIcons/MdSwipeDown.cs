// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdSwipeDown : ComponentBase
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
		builder.AddAttribute(20, "d", "M3.8,12.18c-0.2-0.86-0.3-1.76-0.3-2.68c0-2.84,0.99-5.45,2.63-7.5L7.2,3.07C5.82,4.85,5,7.08,5,9.5 c0,0.88,0.11,1.74,0.32,2.56l1.62-1.62L8,11.5L4.5,15L1,11.5l1.06-1.06L3.8,12.18z M13.85,11.62l-2.68-5.37 c-0.37-0.74-1.27-1.04-2.01-0.67C8.41,5.96,8.11,6.86,8.48,7.6l4.81,9.6L10.05,18c-0.33,0.09-0.59,0.33-0.7,0.66L9,19.78l6.19,2.25 c0.5,0.17,1.28,0.02,1.75-0.22l5.51-2.75c0.89-0.45,1.32-1.48,1-2.42l-1.43-4.27c-0.27-0.82-1.04-1.37-1.9-1.37h-4.56 c-0.31,0-0.62,0.07-0.89,0.21L13.85,11.62");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
