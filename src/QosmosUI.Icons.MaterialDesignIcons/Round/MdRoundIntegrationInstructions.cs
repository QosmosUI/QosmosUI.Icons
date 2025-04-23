// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundIntegrationInstructions : ComponentBase
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
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "12");
		builder.AddAttribute(20, "cy", "3.5");
		builder.AddAttribute(21, "fill", "none");
		builder.AddAttribute(22, "r", ".75");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "12");
		builder.AddAttribute(25, "cy", "3.5");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "r", ".75");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "12");
		builder.AddAttribute(30, "cy", "3.5");
		builder.AddAttribute(31, "fill", "none");
		builder.AddAttribute(32, "r", ".75");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M19,3h-4.18C14.4,1.84,13.3,1,12,1S9.6,1.84,9.18,3H5C4.86,3,4.73,3.01,4.6,3.04C4.21,3.12,3.86,3.32,3.59,3.59 c-0.18,0.18-0.33,0.4-0.43,0.64C3.06,4.46,3,4.72,3,5v14c0,0.27,0.06,0.54,0.16,0.78c0.1,0.24,0.25,0.45,0.43,0.64 c0.27,0.27,0.62,0.47,1.01,0.55C4.73,20.99,4.86,21,5,21h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M10.3,14.88L10.3,14.88 c-0.39,0.39-1.03,0.39-1.42,0l-2.17-2.17c-0.39-0.39-0.39-1.02,0-1.41l2.17-2.17c0.39-0.39,1.03-0.39,1.42,0l0,0 c0.39,0.39,0.39,1.02,0,1.41L8.83,12l1.46,1.46C10.68,13.85,10.69,14.49,10.3,14.88z M12,4.25c-0.41,0-0.75-0.34-0.75-0.75 S11.59,2.75,12,2.75s0.75,0.34,0.75,0.75S12.41,4.25,12,4.25z M13.7,14.88L13.7,14.88c-0.39-0.39-0.39-1.02,0-1.41L15.17,12 l-1.47-1.47c-0.39-0.39-0.39-1.02,0-1.41l0,0c0.39-0.39,1.03-0.39,1.42,0l2.17,2.17c0.39,0.39,0.39,1.02,0,1.41l-2.17,2.17 C14.73,15.27,14.09,15.27,13.7,14.88z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
