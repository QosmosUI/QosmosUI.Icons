// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneMacroOff : ComponentBase
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
		builder.AddAttribute(21, "d", "M10.11,5.69L9.3,5.13C9.12,5,8.89,4.93,8.66,4.93c-0.25,0-0.47,0.1-0.66,0.24 l1.39,1.39C9.57,6.23,9.82,5.93,10.11,5.69z");
		builder.AddAttribute(22, "enable-background", "new");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M15.83,8.9l-0.88-0.42c-0.12,0.73-0.51,1.36-1.05,1.82l0.8,0.57 c0.18,0.13,0.4,0.2,0.64,0.2c0.47,0,0.87-0.28,1.05-0.69c0.06-0.14,0.09-0.28,0.09-0.44C16.49,9.49,16.23,9.1,15.83,8.9z");
		builder.AddAttribute(26, "enable-background", "new");
		builder.AddAttribute(27, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M13.89,5.68c0.55,0.46,0.94,1.1,1.06,1.84l0.87-0.42 c0.41-0.2,0.66-0.59,0.66-1.03c0-0.63-0.51-1.14-1.14-1.14c-0.24,0-0.46,0.07-0.64,0.2L13.89,5.68z");
		builder.AddAttribute(30, "enable-background", "new");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M12,5c0.36,0,0.71,0.07,1.03,0.19l0.11-1.09C13.12,3.49,12.62,3,12,3 s-1.12,0.49-1.14,1.1l0.12,1.09C11.3,5.07,11.64,5,12,5z");
		builder.AddAttribute(34, "enable-background", "new");
		builder.AddAttribute(35, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M15.94,18.77l-0.71-0.71c-0.32,0.47-0.59,0.97-0.79,1.5 C14.98,19.36,15.48,19.09,15.94,18.77z");
		builder.AddAttribute(38, "enable-background", "new");
		builder.AddAttribute(39, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M5.44,15.44c0.71,1.9,2.22,3.41,4.12,4.12C8.85,17.66,7.34,16.15,5.44,15.44z");
		builder.AddAttribute(42, "enable-background", "new");
		builder.AddAttribute(43, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M8.66,4.93C8.9,4.93,9.12,5,9.3,5.13l0.81,0.56C9.82,5.93,9.57,6.23,9.39,6.56l1.66,1.66C11.03,8.14,11,8.08,11,8 c0-0.55,0.45-1,1-1s1,0.45,1,1s-0.45,1-1,1c-0.08,0-0.14-0.03-0.22-0.04l4.06,4.06c1.49-0.24,2.63-1.53,2.63-3.09 c0-0.71-0.25-1.39-0.67-1.93c0.43-0.54,0.67-1.22,0.67-1.93c0-1.73-1.41-3.14-3.14-3.14c-0.15,0-0.29,0.01-0.43,0.03 C14.44,1.81,13.31,1,12,1S9.56,1.81,9.09,2.96C8.95,2.94,8.8,2.93,8.66,2.93c-0.8,0-1.53,0.31-2.09,0.81l1.42,1.42 C8.19,5.03,8.41,4.93,8.66,4.93z M16.39,10.38c-0.18,0.41-0.58,0.69-1.05,0.69c-0.24,0-0.46-0.07-0.64-0.2l-0.8-0.57l-0.01,0 c0.55-0.45,0.94-1.09,1.06-1.83l0.88,0.42c0.4,0.19,0.66,0.59,0.66,1.03C16.49,10.09,16.45,10.24,16.39,10.38z M14.69,5.13 c0.2-0.13,0.42-0.2,0.65-0.2c0,0,0,0,0,0c0.63,0,1.14,0.51,1.14,1.14c0,0.44-0.25,0.83-0.66,1.03l-0.87,0.42l-0.01,0 c-0.12-0.74-0.51-1.38-1.07-1.83L14.69,5.13z M12,3c0.62,0,1.12,0.49,1.14,1.1l-0.11,1.09C12.71,5.07,12.36,5,12,5 s-0.7,0.07-1.02,0.19L10.86,4.1C10.88,3.49,11.38,3,12,3z");
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "d", "M19.98,17.15C20.63,15.91,21,14.5,21,13c-1.5,0-2.91,0.37-4.15,1.02l1.51,1.51");
		builder.CloseElement();
		builder.OpenElement(48, "path");
		builder.AddAttribute(49, "d", "M3,13c0,4.97,4.03,9,9,9C12,17.03,7.97,13,3,13z M5.44,15.44c1.9,0.71,3.42,2.22,4.12,4.12 C7.66,18.85,6.15,17.34,5.44,15.44z");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M2.81,2.81L1.39,4.22l4.42,4.42c-0.19,0.4-0.3,0.84-0.3,1.29c0,1.73,1.41,3.14,3.15,3.14c0.15,0,0.29-0.01,0.43-0.03 C9.56,14.19,10.69,15,12,15c0.05,0,0.11-0.01,0.16-0.01l1.64,1.64C12.67,18.12,12,19.98,12,22c2.02,0,3.88-0.67,5.38-1.8l2.4,2.4 l1.41-1.41L2.81,2.81z M14.44,19.56c0.2-0.54,0.47-1.04,0.79-1.5l0.71,0.71l0,0C15.48,19.09,14.98,19.36,14.44,19.56z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
