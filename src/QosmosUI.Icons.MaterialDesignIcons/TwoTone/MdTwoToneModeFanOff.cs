// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneModeFanOff : ComponentBase
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
		builder.AddAttribute(21, "d", "M4.5,10C4.42,10,4,10.03,4,10.6c0,2,0.82,3.4,2,3.4c0.51,0,0.89-0.12,2.69-0.86 c-0.07-0.2-0.12-0.41-0.15-0.62c-1.48-0.33-2.49-0.89-3.39-2.16C4.93,10.05,4.77,10,4.5,10z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M10,19.5c0,0.08,0.03,0.5,0.6,0.5c2,0,3.4-0.82,3.4-2c0-0.38-0.07-0.69-0.42-1.59l-0.97-0.97 c-0.03,0.01-0.06,0.02-0.09,0.02c-0.33,1.48-0.89,2.49-2.16,3.39C10.05,19.07,10,19.23,10,19.5z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M13.65,5.15C13.95,4.93,14,4.77,14,4.5C14,4.42,13.97,4,13.4,4c-2,0-3.4,0.82-3.4,2 c0,0.38,0.07,0.69,0.42,1.59l1.05,1.05l0.02-0.1C11.82,7.06,12.37,6.04,13.65,5.15z");
		builder.AddAttribute(28, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M18.85,13.65c0.21,0.3,0.38,0.35,0.65,0.35c0.08,0,0.5-0.03,0.5-0.6c0-2-0.82-3.4-2-3.4 c-0.51,0-0.89,0.12-2.69,0.86c0.07,0.2,0.12,0.41,0.15,0.62C16.94,11.82,17.96,12.37,18.85,13.65z");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "g");
		builder.OpenElement(33, "g");
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M10,6c0-1.18,1.4-2,3.4-2C13.97,4,14,4.42,14,4.5c0,0.27-0.05,0.43-0.35,0.65c-1.27,0.9-1.83,1.91-2.16,3.39l-0.02,0.1 l7.25,7.25C18.96,15.95,19.22,16,19.5,16c1.22,0,2.5-0.95,2.5-2.6C22,9.91,20.11,8,18,8c-1.06,0-1.64,0.29-3.91,1.19 c-0.19-0.14-0.4-0.27-0.62-0.37c0.25-1.03,0.61-1.53,1.33-2.04C15.61,6.21,16,5.44,16,4.5C16,3.28,15.05,2,13.4,2 c-3.08,0-4.92,1.47-5.32,3.26l2.33,2.33C10.07,6.69,10,6.38,10,6z M18,10c1.18,0,2,1.4,2,3.4c0,0.57-0.42,0.6-0.5,0.6 c-0.27,0-0.43-0.05-0.65-0.35c-0.9-1.27-1.91-1.83-3.39-2.16c-0.03-0.22-0.08-0.42-0.15-0.62C17.11,10.12,17.49,10,18,10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M1.39,4.22l3.89,3.89C5.04,8.05,4.78,8,4.5,8C3.28,8,2,8.95,2,10.6C2,14.09,3.89,16,6,16c1.06,0,1.64-0.29,3.91-1.19 c0.19,0.14,0.4,0.27,0.62,0.37c-0.25,1.03-0.61,1.53-1.33,2.04C8.39,17.79,8,18.56,8,19.5c0,1.22,0.95,2.5,2.6,2.5 c3.08,0,4.92-1.47,5.32-3.26l3.86,3.86l1.41-1.41L2.81,2.81L1.39,4.22z M12.52,15.46c0.03,0,0.06-0.02,0.09-0.02l0.97,0.97 C13.93,17.31,14,17.62,14,18c0,1.18-1.4,2-3.4,2c-0.57,0-0.6-0.42-0.6-0.5c0-0.27,0.05-0.43,0.35-0.65 C11.63,17.96,12.18,16.94,12.52,15.46z M8.54,12.52c0.03,0.22,0.08,0.42,0.15,0.62C6.89,13.88,6.51,14,6,14c-1.18,0-2-1.4-2-3.4 C4,10.03,4.42,10,4.5,10c0.27,0,0.43,0.05,0.65,0.35C6.04,11.63,7.06,12.18,8.54,12.52z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
