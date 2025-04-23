// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFaceRetouchingOff : ComponentBase
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
		builder.AddAttribute(21, "d", "M12,4c-0.46,0-0.91,0.05-1.34,0.12C12.06,6.44,14.6,8,17.5,8c0.46,0,0.91-0.05,1.34-0.12 C17.44,5.56,14.9,4,12,4z M4.42,9.47C5.09,9.09,5.7,8.61,6.23,8.06L5.51,7.34C5.05,7.99,4.68,8.7,4.42,9.47z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M9,14.25c0.69,0,1.25-0.56,1.25-1.25S9.69,11.75,9,11.75S7.75,12.31,7.75,13S8.31,14.25,9,14.25z M17.5,10 c0.75,0,1.47-0.09,2.17-0.24C19.88,10.47,20,11.22,20,12c0,1.22-0.28,2.37-0.77,3.4l1.49,1.49C21.53,15.44,22,13.78,22,12 c0-5.52-4.48-10-10-10c-1.78,0-3.44,0.47-4.89,1.28l5.33,5.33C13.93,9.49,15.65,10,17.5,10z M10.66,4.12C11.09,4.05,11.54,4,12,4 c2.9,0,5.44,1.56,6.84,3.88C18.41,7.95,17.96,8,17.5,8C14.6,8,12.06,6.44,10.66,4.12z M1.89,3.72l2.19,2.19C2.78,7.6,2,9.71,2,12 c0,5.52,4.48,10,10,10c2.29,0,4.4-0.78,6.09-2.08l2.19,2.19l1.41-1.41L3.31,2.31L1.89,3.72z M16.66,18.49 C15.35,19.44,13.74,20,12,20c-4.41,0-8-3.59-8-8c0-0.05,0.01-0.1,0-0.14c1.39-0.52,2.63-1.35,3.64-2.39L16.66,18.49z M5.51,7.34 l0.72,0.72C5.7,8.61,5.09,9.09,4.42,9.47C4.68,8.7,5.05,7.99,5.51,7.34z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
