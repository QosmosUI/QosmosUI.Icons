// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdSunny : ComponentBase
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
		builder.AddAttribute(18, "d", "M11,4V2c0-0.55,0.45-1,1-1s1,0.45,1,1v2c0,0.55-0.45,1-1,1S11,4.55,11,4z M18.36,7.05l1.41-1.42c0.39-0.39,0.39-1.02,0-1.41 c-0.39-0.39-1.02-0.39-1.41,0l-1.41,1.42c-0.39,0.39-0.39,1.02,0,1.41C17.34,7.44,17.97,7.44,18.36,7.05z M22,11h-2 c-0.55,0-1,0.45-1,1s0.45,1,1,1h2c0.55,0,1-0.45,1-1S22.55,11,22,11z M12,19c-0.55,0-1,0.45-1,1v2c0,0.55,0.45,1,1,1s1-0.45,1-1v-2 C13,19.45,12.55,19,12,19z M5.64,7.05L4.22,5.64c-0.39-0.39-0.39-1.03,0-1.41s1.03-0.39,1.41,0l1.41,1.41 c0.39,0.39,0.39,1.03,0,1.41S6.02,7.44,5.64,7.05z M16.95,16.95c-0.39,0.39-0.39,1.03,0,1.41l1.41,1.41c0.39,0.39,1.03,0.39,1.41,0 c0.39-0.39,0.39-1.03,0-1.41l-1.41-1.41C17.98,16.56,17.34,16.56,16.95,16.95z M2,13h2c0.55,0,1-0.45,1-1s-0.45-1-1-1H2 c-0.55,0-1,0.45-1,1S1.45,13,2,13z M5.64,19.78l1.41-1.41c0.39-0.39,0.39-1.03,0-1.41s-1.03-0.39-1.41,0l-1.41,1.41 c-0.39,0.39-0.39,1.03,0,1.41C4.61,20.17,5.25,20.17,5.64,19.78z M12,6c-3.31,0-6,2.69-6,6s2.69,6,6,6s6-2.69,6-6S15.31,6,12,6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
