// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFace2 : ComponentBase
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
		builder.AddAttribute(21, "d", "M6.02,5C6.01,5,6.01,5,6,5C3.79,5,2,6.79,2,9c0,0.55,0.12,1.07,0.32,1.54C2.89,8.29,4.22,6.35,6.02,5z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M15.1,3.5C14.36,2.59,13.25,2,12,2S9.64,2.59,8.9,3.5C9.88,3.18,10.92,3,12,3S14.12,3.18,15.1,3.5z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,5.31c0,2.24,1.82,4.06,4.06,4.06c0.93,0,1.82-0.32,2.53-0.89C17.16,6.39,14.75,5.01,12.03,5 C12.02,5.11,12,5.21,12,5.31z");
		builder.AddAttribute(28, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M2.5,16.12C2.19,16.68,2,17.31,2,18c0,2.21,1.79,4,4,4c0.44,0,0.85-0.07,1.25-0.2 C5.02,20.59,3.31,18.56,2.5,16.12z");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M21.68,10.54C21.88,10.07,22,9.55,22,9c0-2.21-1.79-4-4-4c-0.01,0-0.01,0-0.02,0 C19.78,6.35,21.11,8.29,21.68,10.54z");
		builder.AddAttribute(34, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M16.75,21.8C17.15,21.93,17.56,22,18,22c2.21,0,4-1.79,4-4c0-0.69-0.19-1.32-0.5-1.88 C20.69,18.56,18.98,20.59,16.75,21.8z");
		builder.AddAttribute(37, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M21.97,13.52c0-0.01,0-0.02,0-0.04C23.21,12.38,24,10.78,24,9c0-3.31-2.69-6-6-6c-0.26,0-0.52,0.02-0.78,0.06 C16.19,1.23,14.24,0,12,0S7.81,1.23,6.78,3.06C6.52,3.02,6.26,3,6,3C2.69,3,0,5.69,0,9c0,1.78,0.79,3.38,2.02,4.48 c0,0.01,0,0.02,0,0.04C0.79,14.62,0,16.22,0,18c0,3.31,2.69,6,6,6c1.39,0,2.67-0.48,3.69-1.28C10.43,22.9,11.2,23,12,23 s1.57-0.1,2.31-0.28C15.33,23.52,16.61,24,18,24c3.31,0,6-2.69,6-6C24,16.22,23.21,14.62,21.97,13.52z M18,5c2.21,0,4,1.79,4,4 c0,0.55-0.12,1.07-0.32,1.54c-0.57-2.25-1.9-4.19-3.7-5.54C17.99,5,17.99,5,18,5z M18.6,8.48c-0.71,0.57-1.6,0.89-2.53,0.89 C13.82,9.38,12,7.55,12,5.31c0-0.1,0.02-0.21,0.03-0.31C14.75,5.01,17.16,6.39,18.6,8.48z M12,2c1.25,0,2.36,0.59,3.1,1.5 C14.12,3.18,13.08,3,12,3S9.88,3.18,8.9,3.5C9.64,2.59,10.75,2,12,2z M2,9c0-2.21,1.79-4,4-4c0.01,0,0.01,0,0.02,0 c-1.8,1.35-3.13,3.29-3.7,5.54C2.12,10.07,2,9.55,2,9z M6,22c-2.21,0-4-1.79-4-4c0-0.69,0.19-1.32,0.5-1.88 c0.8,2.44,2.52,4.47,4.74,5.68C6.85,21.93,6.44,22,6,22z M12,21c-4.41,0-8-3.59-8-8c0-3.72,2.56-6.85,6-7.74c0,0.02,0,0.03,0,0.05 c0,3.34,2.72,6.06,6.06,6.06c1.26,0,2.45-0.39,3.45-1.09C19.82,11.14,20,12.05,20,13C20,17.41,16.41,21,12,21z M18,22 c-0.44,0-0.85-0.07-1.25-0.2c2.23-1.21,3.94-3.24,4.74-5.68c0.31,0.56,0.5,1.2,0.5,1.88C22,20.21,20.21,22,18,22z");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "9");
		builder.AddAttribute(42, "cy", "14");
		builder.AddAttribute(43, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(44, "circle");
		builder.AddAttribute(45, "cx", "15");
		builder.AddAttribute(46, "cy", "14");
		builder.AddAttribute(47, "r", "1.25");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
