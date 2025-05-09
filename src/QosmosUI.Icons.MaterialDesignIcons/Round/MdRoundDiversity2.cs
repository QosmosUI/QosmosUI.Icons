// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDiversity2 : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M10.77,15.23L10.77,15.23c0.4-0.4,0.39-1.07-0.04-1.45C8.17,11.47,6.65,9.9,7.07,8.33C7.29,7.52,8.01,7,8.85,7 c1.11,0,1.54,0.65,2.68,2h0.93c1.12-1.31,1.53-2,2.68-2c0.87,0,1.55,0.54,1.77,1.32c0.35-0.04,0.68-0.06,1-0.06 c0.36,0,0.7,0.03,1.03,0.08C18.7,6.43,17.13,5,15.15,5c-0.12,0-0.23,0.03-0.35,0.04c0.26-0.71,0.31-1.53-0.18-2.43 C14.19,1.8,13.4,1.18,12.5,1.04C10.62,0.74,9,2.18,9,4c0,0.37,0.08,0.71,0.2,1.04C9.08,5.03,8.97,5,8.85,5C6.69,5,5,6.69,5,8.85 c0,2.23,1.73,4.01,4.4,6.41C9.79,15.62,10.4,15.6,10.77,15.23z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M23.52,17.25c-0.54-0.87-1.27-1.23-2.01-1.36c0.07-0.1,0.15-0.18,0.21-0.28c1.08-1.87,0.46-4.18-1.41-5.26 c-1.93-1.11-4.34-0.5-7.75,0.6c-0.51,0.16-0.79,0.7-0.66,1.21v0c0.15,0.55,0.73,0.87,1.28,0.69c3.28-1.06,5.4-1.6,6.55-0.45 c0.59,0.59,0.68,1.48,0.26,2.21c-0.56,0.96-1.33,1-3.07,1.32l-0.47,0.81c0.58,1.62,0.97,2.33,0.39,3.32 c-0.53,0.91-1.61,1.2-2.53,0.68c-0.06-0.03-0.11-0.09-0.17-0.13c-0.3,0.67-0.64,1.24-1.03,1.73c0,0.01,0,0.01,0,0.01 c1.9,1.24,4.34,0.64,5.46-1.29c0.06-0.1,0.09-0.21,0.14-0.32c0.22,0.27,0.48,0.51,0.8,0.69c1.58,0.91,3.64,0.23,4.31-1.55 C24.14,19.02,24,18.03,23.52,17.25z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M12.1,15.04c-0.72,3.38-1.32,5.48-2.89,5.9c-0.81,0.22-1.62-0.15-2.04-0.88c-0.56-0.96-0.2-1.66,0.39-3.32L7.1,15.93 c-1.7-0.31-2.5-0.33-3.07-1.32c-0.53-0.91-0.24-2,0.68-2.53c0.09-0.05,0.19-0.08,0.29-0.11c-0.27-0.42-0.5-0.87-0.67-1.37 c-0.24-0.11-0.36-0.16-0.6-0.26c-1.88,1.07-2.51,3.4-1.43,5.27c0.06,0.1,0.14,0.18,0.21,0.28c-0.75,0.13-1.48,0.49-2.01,1.36 c-0.48,0.78-0.62,1.77-0.3,2.63c0.68,1.78,2.74,2.46,4.31,1.55c0.32-0.18,0.58-0.42,0.8-0.69c0.05,0.11,0.08,0.22,0.14,0.32 c1.08,1.87,3.39,2.49,5.26,1.41c1.93-1.11,2.61-3.51,3.36-7.01c0.11-0.52-0.21-1.04-0.72-1.17l0,0 C12.78,14.14,12.22,14.48,12.1,15.04z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
