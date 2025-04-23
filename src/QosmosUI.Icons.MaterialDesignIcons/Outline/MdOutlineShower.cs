// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineShower : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M9,17c0,0.55-0.45,1-1,1s-1-0.45-1-1s0.45-1,1-1S9,16.45,9,17z M12,16c-0.55,0-1,0.45-1,1s0.45,1,1,1s1-0.45,1-1 S12.55,16,12,16z M16,16c-0.55,0-1,0.45-1,1s0.45,1,1,1c0.55,0,1-0.45,1-1S16.55,16,16,16z M19,12v2H5v-2c0-3.53,2.61-6.43,6-6.92 V3h2v2.08C16.39,5.57,19,8.47,19,12z M17,12c0-2.76-2.24-5-5-5s-5,2.24-5,5H17z M8,19c-0.55,0-1,0.45-1,1s0.45,1,1,1s1-0.45,1-1 S8.55,19,8,19z M12,19c-0.55,0-1,0.45-1,1s0.45,1,1,1s1-0.45,1-1S12.55,19,12,19z M16,19c-0.55,0-1,0.45-1,1s0.45,1,1,1 c0.55,0,1-0.45,1-1S16.55,19,16,19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
