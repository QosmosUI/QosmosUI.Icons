// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineBlurOff : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "cx", "14");
		builder.AddAttribute(18, "cy", "6");
		builder.AddAttribute(19, "r", "1");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M13.8 11.48l.2.02c.83 0 1.5-.67 1.5-1.5s-.67-1.5-1.5-1.5-1.5.67-1.5 1.5l.02.2c.09.67.61 1.19 1.28 1.28zM14 3.5c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5zm-4 0c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "18");
		builder.AddAttribute(24, "cy", "10");
		builder.AddAttribute(25, "r", "1");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "18");
		builder.AddAttribute(28, "cy", "6");
		builder.AddAttribute(29, "r", "1");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M21 10.5c.28 0 .5-.22.5-.5s-.22-.5-.5-.5-.5.22-.5.5.22.5.5.5z");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "10");
		builder.AddAttribute(34, "cy", "6");
		builder.AddAttribute(35, "r", "1");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "18");
		builder.AddAttribute(38, "cy", "14");
		builder.AddAttribute(39, "r", "1");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "6");
		builder.AddAttribute(42, "cy", "18");
		builder.AddAttribute(43, "r", "1");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M14 20.5c-.28 0-.5.22-.5.5s.22.5.5.5.5-.22.5-.5-.22-.5-.5-.5zm7-7c-.28 0-.5.22-.5.5s.22.5.5.5.5-.22.5-.5-.22-.5-.5-.5zm-18 0c-.28 0-.5.22-.5.5s.22.5.5.5.5-.22.5-.5-.22-.5-.5-.5z");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "10");
		builder.AddAttribute(48, "cy", "18");
		builder.AddAttribute(49, "r", "1");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M3 9.5c-.28 0-.5.22-.5.5s.22.5.5.5.5-.22.5-.5-.22-.5-.5-.5zm7 11c-.28 0-.5.22-.5.5s.22.5.5.5.5-.22.5-.5-.22-.5-.5-.5z");
		builder.CloseElement();
		builder.OpenElement(52, "circle");
		builder.AddAttribute(53, "cx", "6");
		builder.AddAttribute(54, "cy", "14");
		builder.AddAttribute(55, "r", "1");
		builder.CloseElement();
		builder.OpenElement(56, "path");
		builder.AddAttribute(57, "d", "M2.5 5.27L6 8.77l.28.28L6 9c-.55 0-1 .45-1 1s.45 1 1 1 1-.45 1-1c0-.1-.03-.19-.06-.28l2.81 2.81c-.71.11-1.25.73-1.25 1.47 0 .83.67 1.5 1.5 1.5.74 0 1.36-.54 1.47-1.25l2.81 2.81c-.09-.03-.18-.06-.28-.06-.55 0-1 .45-1 1s.45 1 1 1 1-.45 1-1c0-.1-.03-.19-.06-.28l3.78 3.78h.01l1.41-1.41L3.91 3.86 2.5 5.27z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
