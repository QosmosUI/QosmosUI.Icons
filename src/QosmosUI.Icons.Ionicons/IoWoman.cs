// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoWoman : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "255.75");
		builder.AddAttribute(15, "cy", "56");
		builder.AddAttribute(16, "r", "56");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M394.63,277.9,384.3,243.49s0-.07,0-.11l-22.46-74.86h-.05l-2.51-8.45a44.87,44.87,0,0,0-43-32.08h-120a44.84,44.84,0,0,0-43,32.08l-2.51,8.45h-.06l-22.46,74.86s0,.07,0,.11L117.88,277.9c-3.12,10.39,2.3,21.66,12.57,25.14a20,20,0,0,0,25.6-13.18l25.58-85.25h0l2.17-7.23A8,8,0,0,1,199.33,200a7.78,7.78,0,0,1-.17,1.61v0L155.43,347.4A16,16,0,0,0,170.75,368h29V482.69c0,16.46,10.53,29.31,24,29.31s24-12.85,24-29.31V368h16V482.69c0,16.46,10.53,29.31,24,29.31s24-12.85,24-29.31V368h30a16,16,0,0,0,15.33-20.6L313.34,201.59a7.52,7.52,0,0,1-.16-1.59,8,8,0,0,1,15.54-2.63l2.17,7.23h0l25.57,85.25A20,20,0,0,0,382.05,303C392.32,299.56,397.74,288.29,394.63,277.9Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
