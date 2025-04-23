// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdPalette : ComponentBase
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
		builder.AddAttribute(20, "d", "M12,2C6.49,2,2,6.49,2,12s4.49,10,10,10c1.38,0,2.5-1.12,2.5-2.5c0-0.61-0.23-1.2-0.64-1.67c-0.08-0.1-0.13-0.21-0.13-0.33 c0-0.28,0.22-0.5,0.5-0.5H16c3.31,0,6-2.69,6-6C22,6.04,17.51,2,12,2z M17.5,13c-0.83,0-1.5-0.67-1.5-1.5c0-0.83,0.67-1.5,1.5-1.5 s1.5,0.67,1.5,1.5C19,12.33,18.33,13,17.5,13z M14.5,9C13.67,9,13,8.33,13,7.5C13,6.67,13.67,6,14.5,6S16,6.67,16,7.5 C16,8.33,15.33,9,14.5,9z M5,11.5C5,10.67,5.67,10,6.5,10S8,10.67,8,11.5C8,12.33,7.33,13,6.5,13S5,12.33,5,11.5z M11,7.5 C11,8.33,10.33,9,9.5,9S8,8.33,8,7.5C8,6.67,8.67,6,9.5,6S11,6.67,11,7.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
