// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundNoiseControlOff : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,4c1.2,0,2.33,0.26,3.35,0.74c0.36,0.17,0.79,0.12,1.07-0.17l0.06-0.06c0.47-0.47,0.35-1.29-0.25-1.57 C14.95,2.34,13.51,2,12,2S9.05,2.34,7.76,2.94c-0.6,0.28-0.72,1.1-0.25,1.57l0.06,0.06c0.28,0.28,0.71,0.34,1.07,0.17 C9.67,4.26,10.8,4,12,4z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M20,12c0,1.2-0.26,2.33-0.74,3.35c-0.17,0.36-0.12,0.79,0.17,1.07l0.06,0.06c0.47,0.47,1.29,0.35,1.57-0.25 C21.66,14.95,22,13.51,22,12s-0.34-2.95-0.94-4.24c-0.28-0.6-1.1-0.72-1.57-0.25l-0.06,0.06c-0.28,0.28-0.34,0.71-0.17,1.07 C19.74,9.67,20,10.8,20,12z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M12,20c-1.2,0-2.33-0.26-3.35-0.74c-0.36-0.17-0.79-0.12-1.07,0.17l-0.06,0.06c-0.47,0.47-0.35,1.29,0.25,1.57 C9.05,21.66,10.49,22,12,22s2.95-0.34,4.24-0.94c0.6-0.28,0.72-1.1,0.25-1.57l-0.06-0.06c-0.28-0.28-0.71-0.34-1.07-0.17 C14.33,19.74,13.2,20,12,20z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M4,12c0-1.2,0.26-2.33,0.74-3.35c0.17-0.36,0.12-0.79-0.17-1.07L4.51,7.51C4.04,7.04,3.23,7.16,2.94,7.76 C2.34,9.05,2,10.49,2,12s0.34,2.95,0.94,4.24c0.28,0.6,1.1,0.72,1.57,0.25l0.06-0.06c0.28-0.28,0.34-0.71,0.17-1.07 C4.26,14.33,4,13.2,4,12z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M11.5,6c-2.89,0-5.15,2.74-4.33,5.76c0.22,0.8,0.68,1.51,1.27,2.1l1.27,1.27c0.15,0.16,0.28,0.38,0.4,0.71 c0.41,1.13,1.38,2.04,2.58,2.16c1.25,0.12,2.37-0.53,2.93-1.53c0.36-0.65-0.15-1.45-0.9-1.45h0c-0.34,0-0.68,0.16-0.84,0.47 C13.72,15.78,13.38,16,13,16c-0.43,0-0.81-0.27-0.95-0.68c-0.15-0.44-0.4-1.08-0.93-1.61l-1.36-1.36C9.28,11.87,9,11.19,9,10.5 C9,9.12,10.12,8,11.5,8c0.98,0,1.83,0.57,2.24,1.4c0.18,0.36,0.52,0.6,0.91,0.6h0c0.75,0,1.22-0.79,0.89-1.46 C14.82,7.04,13.28,6,11.5,6z");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "13.5");
		builder.AddAttribute(36, "cy", "12.5");
		builder.AddAttribute(37, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
