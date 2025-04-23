// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineNoTransfer : ComponentBase
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
		builder.AddAttribute(18, "d", "M8.5,13c0.83,0,1.5,0.67,1.5,1.5S9.33,16,8.5,16S7,15.33,7,14.5S7.67,13,8.5,13z M19.78,22.61l-1.64-1.64 C18.09,20.98,18.05,21,18,21h-1c-0.55,0-1-0.45-1-1v-1H8v1c0,0.55-0.45,1-1,1H6c-0.55,0-1-0.45-1-1v-1.78C4.39,17.67,4,16.88,4,16 V6.83L1.39,4.22l1.41-1.41l18.38,18.38L19.78,22.61z M6,8.83V10h1.17L6,8.83z M14.17,17l-5-5H6v4c0,0.37,0.21,0.62,0.34,0.73 L6.63,17H14.17z M12,4c3.69,0,5.11,0.46,5.66,0.99H7.82l2,2H18V10h-5.17l2,2H18v3.17l1.81,1.81C19.92,16.67,20,16.35,20,16V6 c0-3.5-3.58-4-8-4C9.48,2,7.24,2.16,5.78,2.95l1.53,1.53C8.17,4.2,9.6,4,12,4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
