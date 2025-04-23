// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneVpnKeyOff : ComponentBase
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
		builder.AddAttribute(20, "opacity", ".3");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M17,14.17V13h-1.17l-2-2H21v2h-2v3L17,14.17z M7,16c-2.21,0-4-1.79-4-4c0-1.67,1.02-3.1,2.47-3.7l1.71,1.71 C7.12,10,7.06,10,7,10c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2c0-0.06,0-0.12-0.01-0.18l1.74,1.74C10.22,14.48,9.14,16,7,16z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M2.81,2.81L1.39,4.22l2.59,2.59C2.2,7.85,1,9.79,1,12c0,3.31,2.69,6,6,6c2.22,0,4.15-1.21,5.19-3l7.59,7.61l1.41-1.41 L2.81,2.81z M7,16c-2.21,0-4-1.79-4-4c0-1.67,1.02-3.1,2.47-3.7l1.71,1.71C7.12,10,7.06,10,7,10c-1.1,0-2,0.9-2,2s0.9,2,2,2 s2-0.9,2-2c0-0.06,0-0.12-0.01-0.18l1.74,1.74C10.22,14.48,9.14,16,7,16z M17,14.17V13h-1.17L17,14.17z M13.83,11H21v2h-2v3l2,2 v-3h2V9H11.83L13.83,11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
