// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineNoiseControlOff : ComponentBase
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
		builder.AddAttribute(21, "d", "M12,4c1.44,0,2.79,0.38,3.95,1.05l1.45-1.45C15.85,2.59,13.99,2,12,2S8.15,2.59,6.59,3.59l1.45,1.45 C9.21,4.38,10.56,4,12,4z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M20,12c0,1.44-0.38,2.79-1.05,3.95l1.45,1.45C21.41,15.85,22,13.99,22,12s-0.59-3.85-1.59-5.41l-1.45,1.45 C19.62,9.21,20,10.56,20,12z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,20c-1.44,0-2.79-0.38-3.95-1.05l-1.45,1.45C8.15,21.41,10.01,22,12,22s3.85-0.59,5.41-1.59l-1.45-1.45 C14.79,19.62,13.44,20,12,20z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M4,12c0-1.44,0.38-2.79,1.05-3.95L3.59,6.59C2.59,8.15,2,10.01,2,12s0.59,3.85,1.59,5.41l1.45-1.45 C4.38,14.79,4,13.44,4,12z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M11.5,6C9.02,6,7,8.02,7,10.5c0,1.22,0.49,2.41,1.35,3.27l1.36,1.36c0.17,0.17,0.31,0.44,0.44,0.82 C10.56,17.17,11.71,18,13,18c1.65,0,3-1.35,3-3h-2c0,0.55-0.45,1-1,1c-0.43,0-0.81-0.27-0.95-0.68c-0.15-0.44-0.4-1.08-0.93-1.61 l-1.36-1.36C9.28,11.87,9,11.19,9,10.5C9,9.12,10.12,8,11.5,8c1.21,0,2.22,0.86,2.45,2h2.02C15.72,7.75,13.81,6,11.5,6z");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "13.5");
		builder.AddAttribute(32, "cy", "12.5");
		builder.AddAttribute(33, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
