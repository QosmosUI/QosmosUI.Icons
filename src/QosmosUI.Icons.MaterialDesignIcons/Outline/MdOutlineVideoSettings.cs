// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineVideoSettings : ComponentBase
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
		builder.AddAttribute(21, "d", "M3,6h18v5h2V6c0-1.1-0.9-2-2-2H3C1.9,4,1,4.9,1,6v12c0,1.1,0.9,2,2,2h9v-2H3V6z");
		builder.CloseElement();
		builder.OpenElement(22, "polygon");
		builder.AddAttribute(23, "points", "15,12 9,8 9,16");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M22.71,18.43c0.03-0.29,0.04-0.58,0.01-0.86l1.07-0.85c0.1-0.08,0.12-0.21,0.06-0.32l-1.03-1.79 c-0.06-0.11-0.19-0.15-0.31-0.11L21.23,15c-0.23-0.17-0.48-0.31-0.75-0.42l-0.2-1.36C20.26,13.09,20.16,13,20.03,13h-2.07 c-0.12,0-0.23,0.09-0.25,0.21l-0.2,1.36c-0.26,0.11-0.51,0.26-0.74,0.42l-1.28-0.5c-0.12-0.05-0.25,0-0.31,0.11l-1.03,1.79 c-0.06,0.11-0.04,0.24,0.06,0.32l1.07,0.86c-0.03,0.29-0.04,0.58-0.01,0.86l-1.07,0.85c-0.1,0.08-0.12,0.21-0.06,0.32l1.03,1.79 c0.06,0.11,0.19,0.15,0.31,0.11l1.27-0.5c0.23,0.17,0.48,0.31,0.75,0.42l0.2,1.36c0.02,0.12,0.12,0.21,0.25,0.21h2.07 c0.12,0,0.23-0.09,0.25-0.21l0.2-1.36c0.26-0.11,0.51-0.26,0.74-0.42l1.28,0.5c0.12,0.05,0.25,0,0.31-0.11l1.03-1.79 c0.06-0.11,0.04-0.24-0.06-0.32L22.71,18.43z M19,19.5c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5 S19.83,19.5,19,19.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
