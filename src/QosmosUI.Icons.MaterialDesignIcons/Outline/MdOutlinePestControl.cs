// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlinePestControl : ComponentBase
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
		builder.AddAttribute(21, "d", "M21,15v-2h-3.07c-0.05-0.39-0.12-0.77-0.22-1.14l2.58-1.49l-1-1.73L16.92,10c-0.28-0.48-0.62-0.91-0.99-1.29 c0.1-0.56,0.2-1.69-0.58-2.89L17,4.17l-1.41-1.41l-1.72,1.72c-1.68-0.89-3.1-0.33-3.73,0L8.41,2.76L7,4.17l1.65,1.65 c-0.78,1.2-0.68,2.34-0.58,2.89C7.7,9.1,7.36,9.53,7.08,10L4.71,8.63l-1,1.73l2.58,1.49c-0.1,0.37-0.17,0.75-0.22,1.14H3v2h3.07 c0.05,0.39,0.12,0.77,0.22,1.14l-2.58,1.49l1,1.73L7.08,18c1.08,1.81,2.88,3,4.92,3s3.84-1.19,4.92-3l2.37,1.37l1-1.73l-2.58-1.49 c0.1-0.37,0.17-0.75,0.22-1.14H21z M12,6c0.88,0,1.62,0.57,1.88,1.36C13.29,7.13,12.66,7,12,7s-1.29,0.13-1.88,0.36 C10.38,6.57,11.12,6,12,6z M12,19c-2.21,0-4-2.24-4-5s1.79-5,4-5s4,2.24,4,5S14.21,19,12,19z");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "6");
		builder.AddAttribute(24, "width", "2");
		builder.AddAttribute(25, "x", "11");
		builder.AddAttribute(26, "y", "11");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
