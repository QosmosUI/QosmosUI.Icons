// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAnimation : ComponentBase
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
		builder.AddAttribute(18, "x", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M5,12c-0.63,0.84-1,1.88-1,3c0,2.76,2.24,5,5,5c1.12,0,2.16-0.37,3-1C8.13,19,5,15.87,5,12z");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M15,4c-1.13,0-2.16,0.37-3,1c3.87,0.01,7,3.14,7,7c0.63-0.84,1-1.88,1-3C20,6.24,17.76,4,15,4z");
		builder.AddAttribute(26, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M12,7c-0.6,0-1.17,0.11-1.7,0.3C10.11,7.83,10,8.4,10,9c0,2.76,2.24,5,5,5c0.6,0,1.17-0.11,1.7-0.3 c0.19-0.53,0.3-1.1,0.3-1.7C17,9.24,14.76,7,12,7z");
		builder.AddAttribute(29, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M8,9c-0.63,0.84-1,1.88-1,3c0,2.76,2.24,5,5,5c1.12,0,2.16-0.37,3-1C11.13,15.99,8,12.86,8,9z");
		builder.AddAttribute(32, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M15,2c-2.71,0-5.05,1.54-6.22,3.78c-1.28,0.67-2.34,1.72-3,3C3.54,9.95,2,12.29,2,15c0,3.87,3.13,7,7,7 c2.71,0,5.05-1.54,6.22-3.78c1.28-0.67,2.34-1.72,3-3C20.46,14.05,22,11.71,22,9C22,5.13,18.87,2,15,2z M9,20c-2.76,0-5-2.24-5-5 c0-1.12,0.37-2.16,1-3c0,3.87,3.13,7,7,7C11.16,19.63,10.12,20,9,20z M12,17c-2.76,0-5-2.24-5-5c0-1.12,0.37-2.16,1-3 c0,3.86,3.13,6.99,7,7C14.16,16.63,13.12,17,12,17z M16.7,13.7C16.17,13.89,15.6,14,15,14c-2.76,0-5-2.24-5-5 c0-0.6,0.11-1.17,0.3-1.7C10.83,7.11,11.4,7,12,7c2.76,0,5,2.24,5,5C17,12.6,16.89,13.17,16.7,13.7z M19,12c0-3.86-3.13-6.99-7-7 c0.84-0.63,1.87-1,3-1c2.76,0,5,2.24,5,5C20,10.12,19.63,11.16,19,12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
