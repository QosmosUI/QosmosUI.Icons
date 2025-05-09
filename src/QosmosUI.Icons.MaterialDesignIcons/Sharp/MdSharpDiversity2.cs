// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpDiversity2 : ComponentBase
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
		builder.AddAttribute(21, "d", "M10.1,15.9l1.42-1.42C8.79,12.05,7,10.41,7,8.85C7,7.8,7.8,7,8.85,7c1.11,0,1.54,0.65,2.68,2h0.93 c1.12-1.31,1.53-2,2.68-2c0.87,0,1.55,0.54,1.77,1.32c0.35-0.04,0.68-0.06,1-0.06c0.36,0,0.7,0.03,1.03,0.08 C18.7,6.43,17.13,5,15.15,5c-0.12,0-0.23,0.03-0.35,0.04C14.92,4.71,15,4.37,15,4c0-1.66-1.34-3-3-3S9,2.34,9,4 c0,0.37,0.08,0.71,0.2,1.04C9.08,5.03,8.97,5,8.85,5C6.69,5,5,6.69,5,8.85C5,11.27,7.04,13.16,10.1,15.9z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M22.5,16.24c-0.32-0.18-0.66-0.29-1-0.35c0.07-0.1,0.15-0.18,0.21-0.28c1.08-1.87,0.46-4.18-1.41-5.26 c-2.09-1.21-4.76-0.39-8.65,0.9l0.52,1.94c3.47-1.14,5.79-1.88,7.14-1.1c0.91,0.53,1.2,1.61,0.68,2.53 c-0.56,0.96-1.33,1-3.07,1.32l-0.47,0.81c0.58,1.62,0.97,2.33,0.39,3.32c-0.53,0.91-1.61,1.2-2.53,0.68 c-0.06-0.03-0.11-0.09-0.17-0.13c-0.3,0.67-0.64,1.24-1.03,1.73c0.07,0.04,0.13,0.09,0.2,0.14c1.87,1.08,4.18,0.46,5.26-1.41 c0.06-0.1,0.09-0.21,0.14-0.32c0.22,0.27,0.48,0.51,0.8,0.69c1.43,0.83,3.27,0.34,4.1-1.1S23.93,17.06,22.5,16.24z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12.32,14.01c-0.74,3.58-1.27,5.95-2.62,6.73c-0.91,0.53-2,0.24-2.53-0.68c-0.56-0.96-0.2-1.66,0.39-3.32L7.1,15.93 c-1.7-0.31-2.5-0.33-3.07-1.32c-0.53-0.91-0.24-2,0.68-2.53c0.09-0.05,0.19-0.08,0.29-0.11c-0.35-0.56-0.64-1.17-0.82-1.85 c-0.16,0.07-0.32,0.14-0.48,0.23c-1.87,1.08-2.49,3.39-1.41,5.26c0.06,0.1,0.14,0.18,0.21,0.28c-0.34,0.06-0.68,0.17-1,0.35 c-1.43,0.83-1.93,2.66-1.1,4.1s2.66,1.93,4.1,1.1c0.32-0.18,0.58-0.42,0.8-0.69c0.05,0.11,0.08,0.22,0.14,0.32 c1.08,1.87,3.39,2.49,5.26,1.41c2.09-1.21,2.71-3.93,3.55-7.94L12.32,14.01z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
