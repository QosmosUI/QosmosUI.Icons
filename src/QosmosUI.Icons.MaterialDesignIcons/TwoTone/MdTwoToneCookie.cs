// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneCookie : ComponentBase
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
		builder.AddAttribute(21, "d", "M17.07,8.93c-2.55-0.39-4.57-2.41-4.99-4.94C6.73,3.82,4,8.69,4,12c0,4.41,3.59,8,8,8 c4.06,0,7.7-3.14,7.98-7.45C17.59,11.48,17.14,9.29,17.07,8.93z M8.5,15C7.67,15,7,14.33,7,13.5S7.67,12,8.5,12s1.5,0.67,1.5,1.5 S9.33,15,8.5,15z M10.5,10C9.67,10,9,9.33,9,8.5S9.67,7,10.5,7S12,7.67,12,8.5S11.33,10,10.5,10z M15,16c-0.55,0-1-0.45-1-1 c0-0.55,0.45-1,1-1s1,0.45,1,1C16,15.55,15.55,16,15,16z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "10.5");
		builder.AddAttribute(25, "cy", "8.5");
		builder.AddAttribute(26, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "8.5");
		builder.AddAttribute(29, "cy", "13.5");
		builder.AddAttribute(30, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "15");
		builder.AddAttribute(33, "cy", "15");
		builder.AddAttribute(34, "r", "1");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M21.95,10.99c-1.79-0.03-3.7-1.95-2.68-4.22c-2.97,1-5.78-1.59-5.19-4.56C7.1,0.74,2,6.41,2,12c0,5.52,4.48,10,10,10 C17.89,22,22.54,16.92,21.95,10.99z M12,20c-4.41,0-8-3.59-8-8c0-3.31,2.73-8.18,8.08-8.02c0.42,2.54,2.44,4.56,4.99,4.94 c0.07,0.36,0.52,2.55,2.92,3.63C19.7,16.86,16.06,20,12,20z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
