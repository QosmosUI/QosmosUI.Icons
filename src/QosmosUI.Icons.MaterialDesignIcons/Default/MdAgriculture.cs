// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Default;

public class MdAgriculture : ComponentBase
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
		builder.AddAttribute(21, "d", "M19.5,12c0.93,0,1.78,0.28,2.5,0.76V8c0-1.1-0.9-2-2-2h-6.29l-1.06-1.06l1.41-1.41l-0.71-0.71L9.82,6.35l0.71,0.71 l1.41-1.41L13,6.71V9c0,1.1-0.9,2-2,2h-0.54c0.95,1.06,1.54,2.46,1.54,4c0,0.34-0.04,0.67-0.09,1h3.14 C15.3,13.75,17.19,12,19.5,12z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M19.5,13c-1.93,0-3.5,1.57-3.5,3.5s1.57,3.5,3.5,3.5s3.5-1.57,3.5-3.5S21.43,13,19.5,13z M19.5,18 c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S20.33,18,19.5,18z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M4,9h5c0-1.1-0.9-2-2-2H4C3.45,7,3,7.45,3,8C3,8.55,3.45,9,4,9z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M9.83,13.82l-0.18-0.47L10.58,13c-0.46-1.06-1.28-1.91-2.31-2.43l-0.4,0.89l-0.46-0.21l0.4-0.9C7.26,10.13,6.64,10,6,10 c-0.53,0-1.04,0.11-1.52,0.26l0.34,0.91l-0.47,0.18L4,10.42c-1.06,0.46-1.91,1.28-2.43,2.31l0.89,0.4l-0.21,0.46l-0.9-0.4 C1.13,13.74,1,14.36,1,15c0,0.53,0.11,1.04,0.26,1.52l0.91-0.34l0.18,0.47L1.42,17c0.46,1.06,1.28,1.91,2.31,2.43l0.4-0.89 l0.46,0.21l-0.4,0.9C4.74,19.87,5.36,20,6,20c0.53,0,1.04-0.11,1.52-0.26l-0.34-0.91l0.47-0.18L8,19.58 c1.06-0.46,1.91-1.28,2.43-2.31l-0.89-0.4l0.21-0.46l0.9,0.4C10.87,16.26,11,15.64,11,15c0-0.53-0.11-1.04-0.26-1.52L9.83,13.82z M7.15,17.77c-1.53,0.63-3.29-0.09-3.92-1.62c-0.63-1.53,0.09-3.29,1.62-3.92c1.53-0.63,3.29,0.09,3.92,1.62 C9.41,15.38,8.68,17.14,7.15,17.77z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
