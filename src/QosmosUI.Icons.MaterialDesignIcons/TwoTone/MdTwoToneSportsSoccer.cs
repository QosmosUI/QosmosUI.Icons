// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSportsSoccer : ComponentBase
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
		builder.AddAttribute(23, "d", "M7.01,9.49L11,6.7V5.3L9.65,4.35C7.83,4.92,6.28,6.12,5.27,7.69l0.39,1.34L7.01,9.49z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.AddAttribute(25, "opacity", ".3");
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M5.01,10.92l-1,0.73C4.01,11.77,4,11.88,4,12c0,1.99,0.73,3.81,1.94,5.21l1.14-0.1l0.79-1.37L6.4,11.4L5.01,10.92z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(28, "g");
		builder.AddAttribute(29, "opacity", ".3");
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M18.34,9.03l0.39-1.34c-1.01-1.57-2.55-2.77-4.38-3.34L13,5.3v1.4l3.99,2.79L18.34,9.03z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.AddAttribute(33, "opacity", ".3");
		builder.OpenElement(34, "polygon");
		builder.AddAttribute(35, "points", "8.37,10.98 9.73,15 14.27,15 15.63,10.98 12,8.44");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "g");
		builder.AddAttribute(37, "opacity", ".3");
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M9.45,17l-0.64,1.11l0.69,1.49C10.29,19.85,11.13,20,12,20s1.71-0.15,2.5-0.41l0.69-1.49L14.55,17H9.45z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(40, "g");
		builder.AddAttribute(41, "opacity", ".3");
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M19.98,11.65l-1-0.73L17.6,11.4l-1.46,4.34l0.79,1.37l1.14,0.1C19.27,15.81,20,13.99,20,12 C20,11.88,19.99,11.77,19.98,11.65z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(44, "g");
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M12,2C6.48,2,2,6.48,2,12c0,5.52,4.48,10,10,10s10-4.48,10-10C22,6.48,17.52,2,12,2z M13,5.3l1.35-0.95 c1.82,0.56,3.37,1.76,4.38,3.34l-0.39,1.34l-1.35,0.46L13,6.7V5.3z M9.65,4.35L11,5.3v1.4L7.01,9.49L5.66,9.03L5.27,7.69 C6.28,6.12,7.83,4.92,9.65,4.35z M7.08,17.11l-1.14,0.1C4.73,15.81,4,13.99,4,12c0-0.12,0.01-0.23,0.02-0.35l1-0.73L6.4,11.4 l1.46,4.34L7.08,17.11z M14.5,19.59C13.71,19.85,12.87,20,12,20s-1.71-0.15-2.5-0.41l-0.69-1.49L9.45,17h5.11l0.64,1.11 L14.5,19.59z M14.27,15H9.73l-1.35-4.02L12,8.44l3.63,2.54L14.27,15z M18.06,17.21l-1.14-0.1l-0.79-1.37l1.46-4.34l1.39-0.47 l1,0.73C19.99,11.77,20,11.88,20,12C20,13.99,19.27,15.81,18.06,17.21z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
