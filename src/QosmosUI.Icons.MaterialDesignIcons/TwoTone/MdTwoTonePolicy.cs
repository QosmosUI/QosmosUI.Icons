// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTonePolicy : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M5,6.3V11c0,4.52,2.98,8.69,7,9.93c1.74-0.53,3.28-1.62,4.47-3.04l-1.72-1.72 c-1.94,1.29-4.58,1.07-6.29-0.64c-1.95-1.95-1.95-5.12,0-7.07c1.95-1.95,5.12-1.95,7.07,0c1.71,1.71,1.92,4.35,0.64,6.29 l1.45,1.45C18.49,14.65,19,12.85,19,11V6.3l-7-3.11L5,6.3z");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,1L3,5v6c0,5.55,3.84,10.74,9,12c0.65-0.16,1.27-0.38,1.87-0.65c1.8-0.82,3.36-2.13,4.57-3.74 C20.04,16.46,21,13.77,21,11V5L12,1z M19,11c0,1.85-0.51,3.65-1.38,5.21l-1.45-1.45c1.29-1.94,1.07-4.58-0.64-6.29 c-1.95-1.95-5.12-1.95-7.07,0c-1.95,1.95-1.95,5.12,0,7.07c1.71,1.71,4.35,1.92,6.29,0.64l1.72,1.72 c-1.19,1.42-2.73,2.51-4.47,3.04C7.98,19.69,5,15.52,5,11V6.3l7-3.11l7,3.11V11z M15,12c0,1.66-1.34,3-3,3s-3-1.34-3-3s1.34-3,3-3 S15,10.34,15,12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
