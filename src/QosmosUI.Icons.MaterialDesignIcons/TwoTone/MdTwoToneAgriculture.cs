// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAgriculture : ComponentBase
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
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M4,9h5c0-1.1-0.9-2-2-2H4C3.45,7,3,7.45,3,8C3,8.55,3.45,9,4,9z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M22,14.06V8c0-1.1-0.9-2-2-2h-6.29l-1.06-1.06l1.41-1.41l-0.71-0.71L9.82,6.35l0.71,0.71l1.41-1.41L13,6.71V9 c0,1.1-0.9,2-2,2H8.96c-0.22-0.16-0.45-0.3-0.69-0.43l-0.4,0.89l-0.46-0.21l0.4-0.9C7.26,10.13,6.64,10,6,10 c-0.53,0-1.04,0.11-1.52,0.26l0.34,0.91l-0.47,0.18L4,10.42c-1.06,0.46-1.91,1.28-2.43,2.31l0.89,0.4l-0.21,0.46l-0.9-0.4 C1.13,13.74,1,14.36,1,15c0,0.53,0.11,1.04,0.26,1.52l0.91-0.34l0.18,0.47L1.42,17c0.46,1.06,1.28,1.91,2.31,2.43l0.4-0.89 l0.46,0.21l-0.4,0.9C4.74,19.87,5.36,20,6,20c0.53,0,1.04-0.11,1.52-0.26l-0.34-0.91l0.47-0.18L8,19.58 c1.06-0.46,1.91-1.28,2.43-2.31l-0.89-0.4l0.21-0.46l0.9,0.4c0.1-0.26,0.18-0.54,0.24-0.82h5.16C16.03,16.16,16,16.33,16,16.5 c0,1.93,1.57,3.5,3.5,3.5s3.5-1.57,3.5-3.5C23,15.55,22.62,14.69,22,14.06z M6,18c-1.66,0-3-1.34-3-3s1.34-3,3-3s3,1.34,3,3 S7.66,18,6,18z M10.87,14c-0.04-0.18-0.08-0.35-0.13-0.52l-0.91,0.34l-0.18-0.47L10.58,13c0,0,0.42,0,0.42,0c2.21,0,4-1.79,4-4V8 h5v5.05C19.84,13.03,19.67,13,19.5,13c-0.95,0-1.81,0.38-2.44,1H10.87z M19.5,18c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5 s1.5,0.67,1.5,1.5S20.33,18,19.5,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M20,13.05V8h-5v1c0,2.21-1.79,4-4,4c0,0-0.42,0-0.42,0c0.14,0.32,0.25,0.65,0.32,1h6.16 c0.63-0.62,1.49-1,2.44-1C19.67,13,19.84,13.03,20,13.05z");
		builder.AddAttribute(27, "opacity", ".3");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
