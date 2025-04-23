// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSportsKabaddi : ComponentBase
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
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "16.5");
		builder.AddAttribute(26, "cy", "2.38");
		builder.AddAttribute(27, "r", "2");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M24,10.88v-3.7l-4.99-2.11c-0.98-0.41-2.12-0.07-2.71,0.81l0,0l-1,1.6c-0.67,1.18-1.91,2.06-3.41,2.32l0.06,0.06 c0.69,0.69,1.52,1.07,2.46,1.17c0.8-0.42,1.52-0.98,2.09-1.64l0.6,3l-1.16,1.1L15,14.38v0.76v5.74c0,0.55,0.45,1,1,1h0 c0.55,0,1-0.45,1-1v-5l2.1-2l1.62,7.19c0.11,0.47,0.53,0.81,1.02,0.81h0c0.66,0,1.15-0.6,1.02-1.24l-1.94-9.76l-0.62-3.1l1.8,0.7 v2.4c0,0.55,0.45,1,1,1h0C23.55,11.88,24,11.43,24,10.88z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M10.29,8.09c0.22,0.15,0.47,0.24,0.72,0.29c0.13,0.02,0.25,0.04,0.38,0.04s0.26-0.01,0.38-0.04 c0.13-0.02,0.25-0.06,0.37-0.11c0.24-0.1,0.47-0.24,0.66-0.44c0.49-0.49,0.67-1.17,0.55-1.8C13.28,5.66,13.1,5.29,12.8,5 c-0.19-0.19-0.42-0.34-0.66-0.44c-0.12-0.05-0.24-0.09-0.37-0.11s-0.25-0.04-0.38-0.04c-0.12,0-0.23,0.01-0.35,0.03 c-0.14,0.02-0.28,0.06-0.41,0.11C10.4,4.66,10.17,4.81,9.98,5C9.68,5.29,9.5,5.66,9.43,6.03c-0.12,0.63,0.06,1.31,0.55,1.8 C10.07,7.93,10.18,8.01,10.29,8.09z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M11.24,10.56l-2-2c-0.1-0.1-0.2-0.18-0.31-0.26C8.71,8.16,8.46,8.06,8.21,8.02C8.08,7.99,7.96,7.98,7.83,7.98 c-0.51,0-1.02,0.2-1.41,0.59l-3.34,3.34c-0.41,0.41-0.62,0.98-0.58,1.54C2.5,13.63,2.54,13.82,2.61,14l1.07,2.95l-2.92,2.92 c-0.39,0.39-0.39,1.02,0,1.41l0,0c0.39,0.39,1.02,0.39,1.41,0l3.54-3.54v-2.22L7,16.75v4.13c0,0.55,0.45,1,1,1h0 c0.55,0,1-0.45,1-1v-5l-2.12-2.12l2.36-2.36l0.71,0.71l0,0c1.02,1,2.28,1.69,3.79,1.94c0.64,0.11,1.21-0.45,1.16-1.1v0 c-0.03-0.48-0.4-0.87-0.87-0.94C12.9,11.83,11.97,11.29,11.24,10.56z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
