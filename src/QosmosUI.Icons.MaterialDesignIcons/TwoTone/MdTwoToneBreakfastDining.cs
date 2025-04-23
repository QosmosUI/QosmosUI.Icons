// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBreakfastDining : ComponentBase
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
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M18,5H6C4.9,5,4,5.9,4,7c0,0.71,0.38,1.35,1.01,1.73L6,9.31V19h12V9.3l1-0.58c0.63-0.36,1-1.01,1-1.72 C20,5.9,19.1,5,18,5z M15.71,13.7l-3,3C12.51,16.9,12.26,17,12,17s-0.51-0.1-0.71-0.29l-3-3c-0.39-0.39-0.39-1.02,0-1.41l3-3 C11.49,9.1,11.74,9,12,9s0.51,0.1,0.71,0.29l3,3C16.1,12.68,16.1,13.31,15.71,13.7z");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M18,3H6C3.79,3,2,4.79,2,7c0,1.48,0.81,2.75,2,3.45V19c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2v-8.55c1.19-0.69,2-1.97,2-3.45 C22,4.79,20.21,3,18,3z M19,8.72L18,9.3V19H6V9.31L5.01,8.73C4.38,8.35,4,7.71,4,7c0-1.1,0.9-2,2-2h12c1.1,0,2,0.9,2,2 C20,7.71,19.62,8.36,19,8.72z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12.71,9.29C12.51,9.1,12.26,9,12,9s-0.51,0.1-0.71,0.29l-3,3c-0.39,0.39-0.39,1.02,0,1.41l3,3C11.49,16.9,11.74,17,12,17 s0.51-0.1,0.71-0.29l3-3c0.39-0.39,0.39-1.02,0-1.41L12.71,9.29z M12,14.58L10.41,13L12,11.41L13.59,13L12,14.58z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
