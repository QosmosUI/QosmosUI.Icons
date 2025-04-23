// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSportsBasketball : ComponentBase
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
		builder.AddAttribute(21, "d", "M8.93,11H11V4.07C9.27,4.29,7.71,5.06,6.5,6.2C7.81,7.44,8.69,9.12,8.93,11z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M19.93,11c-0.15-1.18-0.56-2.28-1.16-3.25C17.9,8.62,17.3,9.74,17.09,11H19.93z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M5.23,7.75C4.63,8.72,4.22,9.82,4.07,11h2.84C6.7,9.74,6.1,8.62,5.23,7.75z");
		builder.AddAttribute(28, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M4.07,13c0.15,1.18,0.56,2.28,1.16,3.25C6.1,15.38,6.7,14.26,6.91,13H4.07z");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M6.51,17.79c1.2,1.14,2.76,1.92,4.49,2.14V13H8.93C8.7,14.88,7.81,16.55,6.51,17.79z");
		builder.AddAttribute(34, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M17.5,6.2c-1.21-1.14-2.77-1.92-4.5-2.13V11h2.07C15.31,9.12,16.19,7.44,17.5,6.2z");
		builder.AddAttribute(37, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M18.77,16.25c0.61-0.96,1.02-2.07,1.16-3.25h-2.84C17.3,14.26,17.9,15.38,18.77,16.25z");
		builder.AddAttribute(40, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M13,13v6.93c1.73-0.22,3.29-1,4.49-2.14c-1.3-1.24-2.19-2.91-2.42-4.79H13z");
		builder.AddAttribute(43, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M12,2C6.48,2,2,6.48,2,12c0,5.52,4.48,10,10,10s10-4.48,10-10C22,6.48,17.52,2,12,2z M5.23,7.75 C6.1,8.62,6.7,9.74,6.91,11H4.07C4.22,9.82,4.63,8.72,5.23,7.75z M4.07,13h2.84c-0.21,1.26-0.81,2.38-1.68,3.25 C4.63,15.28,4.22,14.18,4.07,13z M11,19.93c-1.73-0.22-3.29-1-4.49-2.14c1.3-1.24,2.19-2.91,2.42-4.79H11V19.93z M11,11H8.93 C8.69,9.12,7.81,7.44,6.5,6.2C7.71,5.06,9.27,4.29,11,4.07V11z M19.93,11h-2.84c0.21-1.26,0.81-2.38,1.68-3.25 C19.37,8.72,19.78,9.82,19.93,11z M13,4.07c1.73,0.22,3.29,0.99,4.5,2.13c-1.31,1.24-2.19,2.92-2.43,4.8H13V4.07z M13,19.93V13 h2.07c0.24,1.88,1.12,3.55,2.42,4.79C16.29,18.93,14.73,19.71,13,19.93z M18.77,16.25c-0.87-0.86-1.46-1.99-1.68-3.25h2.84 C19.78,14.18,19.37,15.28,18.77,16.25z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
