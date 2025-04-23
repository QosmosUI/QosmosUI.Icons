// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEggAlt : ComponentBase
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
		builder.AddAttribute(21, "opacity", ".3");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M17.59,10.42c-0.69-0.68-1.21-1.51-1.76-2.39C14.48,5.86,13.31,4,9.97,4C8.35,4,7.01,4.52,5.99,5.55 C4.68,6.88,3.97,8.99,4,11.5C4.05,16.01,8.33,17,9.97,17c1.69,0,2.68,1.05,3.34,1.74C14.03,19.5,14.5,20,15.99,20 c1.89,0,4.01-2.13,4.01-4.98C20,12.82,19.49,12.31,17.59,10.42z M12,15.5c-1.93,0-3.5-1.57-3.5-3.5s1.57-3.5,3.5-3.5 s3.5,1.57,3.5,3.5S13.93,15.5,12,15.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M19,9C17,7,15.99,2,9.97,2C4.95,2,1.94,6,2,11.52C2.06,17.04,6.96,19,9.97,19c2.01,0,2.01,3,6.02,3C19,22,22,19,22,15.02 C22,12,21.01,11,19,9z M15.99,20c-1.49,0-1.96-0.5-2.68-1.26C12.66,18.05,11.66,17,9.97,17C8.33,17,4.05,16.01,4,11.5 C3.97,8.99,4.68,6.88,5.99,5.55C7.01,4.52,8.35,4,9.97,4c3.34,0,4.51,1.86,5.86,4.02c0.55,0.88,1.07,1.71,1.76,2.39 c1.9,1.89,2.41,2.4,2.41,4.61C20,17.87,17.88,20,15.99,20z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "12");
		builder.AddAttribute(30, "cy", "12");
		builder.AddAttribute(31, "r", "3.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
