// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneOilBarrel : ComponentBase
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
		builder.AddAttribute(21, "d", "M7,11c0.55,0,1,0.45,1,1s-0.45,1-1,1v6h10v-6c-0.55,0-1-0.45-1-1s0.45-1,1-1V5H7V11z M12,8.5 c2.47,2.86,3,3.24,3,4.55c0,1.63-1.34,2.95-3,2.95s-3-1.32-3-2.95C9,11.75,9.52,11.38,12,8.5z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M12,16c1.66,0,3-1.32,3-2.95c0-1.31-0.53-1.69-3-4.55c-2.48,2.88-3,3.25-3,4.55C9,14.68,10.34,16,12,16z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M20,13c0.55,0,1-0.45,1-1s-0.45-1-1-1h-1V5h1c0.55,0,1-0.45,1-1s-0.45-1-1-1H4C3.45,3,3,3.45,3,4s0.45,1,1,1h1v6H4 c-0.55,0-1,0.45-1,1s0.45,1,1,1h1v6H4c-0.55,0-1,0.45-1,1s0.45,1,1,1h16c0.55,0,1-0.45,1-1s-0.45-1-1-1h-1v-6H20z M17,11 c-0.55,0-1,0.45-1,1s0.45,1,1,1v6H7v-6c0.55,0,1-0.45,1-1s-0.45-1-1-1V5h10V11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
