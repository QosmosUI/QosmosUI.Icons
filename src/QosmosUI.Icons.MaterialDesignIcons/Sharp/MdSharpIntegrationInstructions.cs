// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpIntegrationInstructions : ComponentBase
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
		builder.AddAttribute(34, "d", "M21,3h-6.18C14.4,1.84,13.3,1,12,1S9.6,1.84,9.18,3H3v18h18V3z M11,14.17l-1.41,1.42L6,12l3.59-3.59L11,9.83L8.83,12 L11,14.17z M12,4.25c-0.41,0-0.75-0.34-0.75-0.75S11.59,2.75,12,2.75s0.75,0.34,0.75,0.75S12.41,4.25,12,4.25z M14.41,15.59 L13,14.17L15.17,12L13,9.83l1.41-1.42L18,12L14.41,15.59z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
