// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneLightMode : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "circle");
		builder.AddAttribute(18, "cx", "12");
		builder.AddAttribute(19, "cy", "12");
		builder.AddAttribute(20, "opacity", ".3");
		builder.AddAttribute(21, "r", "3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M12,9c1.65,0,3,1.35,3,3s-1.35,3-3,3s-3-1.35-3-3S10.35,9,12,9 M12,7c-2.76,0-5,2.24-5,5s2.24,5,5,5s5-2.24,5-5 S14.76,7,12,7L12,7z M2,13l2,0c0.55,0,1-0.45,1-1s-0.45-1-1-1l-2,0c-0.55,0-1,0.45-1,1S1.45,13,2,13z M20,13l2,0c0.55,0,1-0.45,1-1 s-0.45-1-1-1l-2,0c-0.55,0-1,0.45-1,1S19.45,13,20,13z M11,2v2c0,0.55,0.45,1,1,1s1-0.45,1-1V2c0-0.55-0.45-1-1-1S11,1.45,11,2z M11,20v2c0,0.55,0.45,1,1,1s1-0.45,1-1v-2c0-0.55-0.45-1-1-1C11.45,19,11,19.45,11,20z M5.99,4.58c-0.39-0.39-1.03-0.39-1.41,0 c-0.39,0.39-0.39,1.03,0,1.41l1.06,1.06c0.39,0.39,1.03,0.39,1.41,0s0.39-1.03,0-1.41L5.99,4.58z M18.36,16.95 c-0.39-0.39-1.03-0.39-1.41,0c-0.39,0.39-0.39,1.03,0,1.41l1.06,1.06c0.39,0.39,1.03,0.39,1.41,0c0.39-0.39,0.39-1.03,0-1.41 L18.36,16.95z M19.42,5.99c0.39-0.39,0.39-1.03,0-1.41c-0.39-0.39-1.03-0.39-1.41,0l-1.06,1.06c-0.39,0.39-0.39,1.03,0,1.41 s1.03,0.39,1.41,0L19.42,5.99z M7.05,18.36c0.39-0.39,0.39-1.03,0-1.41c-0.39-0.39-1.03-0.39-1.41,0l-1.06,1.06 c-0.39,0.39-0.39,1.03,0,1.41s1.03,0.39,1.41,0L7.05,18.36z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
