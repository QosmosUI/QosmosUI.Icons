// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneGroups2 : ComponentBase
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
		builder.AddAttribute(21, "d", "M15.43,15.48c-1.1-0.49-2.26-0.73-3.43-0.73c-1.18,0-2.33,0.25-3.43,0.73c-0.23,0.1-0.4,0.29-0.49,0.52 h7.85C15.83,15.77,15.66,15.58,15.43,15.48z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M12.94,8.79C12.86,8.33,12.47,8,12,8s-0.86,0.33-0.94,0.79L10.86,10h2.28L12.94,8.79z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M10.27,12h3.46c0.93,0,1.63-0.83,1.48-1.75l-0.3-1.79C14.67,7.04,13.44,6,12,6S9.33,7.04,9.09,8.47l-0.3,1.79 C8.64,11.17,9.34,12,10.27,12z M11.06,8.79C11.14,8.33,11.53,8,12,8s0.86,0.33,0.94,0.79l0.2,1.21h-2.28L11.06,8.79z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M1.66,11.11c-0.13,0.26-0.18,0.57-0.1,0.88c0.16,0.69,0.76,1.03,1.53,1c0,0,1.49,0,1.95,0c0.83,0,1.51-0.58,1.51-1.29 c0-0.14-0.03-0.27-0.07-0.4c-0.01-0.03-0.01-0.05,0.01-0.08c0.09-0.16,0.14-0.34,0.14-0.53c0-0.31-0.14-0.6-0.36-0.82 c-0.03-0.03-0.03-0.06-0.02-0.1c0.07-0.2,0.07-0.43,0.01-0.65C6.1,8.69,5.71,8.4,5.27,8.38c-0.03,0-0.05-0.01-0.07-0.03 C5.03,8.14,4.72,8,4.37,8C4.07,8,3.8,8.1,3.62,8.26C3.59,8.29,3.56,8.29,3.53,8.28c-0.14-0.06-0.3-0.09-0.46-0.09 c-0.65,0-1.18,0.49-1.24,1.12c0,0.02-0.01,0.04-0.03,0.06c-0.29,0.26-0.46,0.65-0.41,1.05c0.03,0.22,0.12,0.43,0.25,0.6 C1.67,11.04,1.67,11.08,1.66,11.11z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M16.24,13.65c-1.17-0.52-2.61-0.9-4.24-0.9c-1.63,0-3.07,0.39-4.24,0.9C6.68,14.13,6,15.21,6,16.39V18h12v-1.61 C18,15.21,17.32,14.13,16.24,13.65z M8.07,16c0.09-0.23,0.27-0.42,0.49-0.52c1.1-0.49,2.26-0.73,3.43-0.73 c1.18,0,2.33,0.25,3.43,0.73c0.23,0.1,0.4,0.29,0.49,0.52H8.07z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M1.22,14.58C0.48,14.9,0,15.62,0,16.43V18l4.5,0v-1.61c0-0.83,0.23-1.61,0.63-2.29C4.76,14.04,4.39,14,4,14 C3.01,14,2.07,14.21,1.22,14.58z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M22.78,14.58C21.93,14.21,20.99,14,20,14c-0.39,0-0.76,0.04-1.13,0.1c0.4,0.68,0.63,1.46,0.63,2.29V18l4.5,0v-1.57 C24,15.62,23.52,14.9,22.78,14.58z");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M22,11v-0.5c0-1.1-0.9-2-2-2h-2c-0.42,0-0.65,0.48-0.39,0.81l0.7,0.63C18.12,10.25,18,10.61,18,11c0,1.1,0.9,2,2,2 S22,12.1,22,11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
