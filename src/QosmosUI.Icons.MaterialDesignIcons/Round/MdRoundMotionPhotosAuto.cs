// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMotionPhotosAuto : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M4,9L4,9c0.26,0.26,0.34,0.63,0.25,0.98c-0.35,1.36-0.36,2.87,0.1,4.38c0.88,2.91,3.44,5.1,6.44,5.55 c5.52,0.81,10.19-4.06,9.03-9.62c-0.65-3.13-3.23-5.61-6.37-6.16c-1.21-0.21-2.38-0.15-3.46,0.13C9.64,4.35,9.26,4.26,9.01,4.01l0,0 C8.45,3.45,8.73,2.52,9.48,2.32c1.47-0.38,3.06-0.44,4.7-0.09c3.98,0.86,7.09,4.18,7.7,8.2c1.04,6.81-4.82,12.58-11.64,11.42 C6.23,21.16,2.98,17.99,2.2,14c-0.31-1.59-0.24-3.12,0.12-4.53C2.52,8.72,3.45,8.45,4,9z M7,5.5C7,6.33,6.33,7,5.5,7S4,6.33,4,5.5 S4.67,4,5.5,4S7,4.67,7,5.5z M12.03,8.99h-0.07l-1.16,3.31h2.39L12.03,8.99z M12,18c3.31,0,6-2.69,6-6s-2.69-6-6-6s-6,2.69-6,6 S8.69,18,12,18z M8.61,14.63l2.43-6.46C11.19,7.77,11.57,7.5,12,7.5s0.82,0.27,0.97,0.67l2.43,6.46c0.16,0.42-0.15,0.87-0.6,0.87 c-0.27,0-0.52-0.17-0.61-0.43l-0.56-1.61h-3.23l-0.57,1.62c-0.09,0.26-0.33,0.43-0.61,0.43C8.76,15.5,8.45,15.05,8.61,14.63z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
