// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWifiPassword : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M18.49,12.13C16.67,10.79,14.43,10,12,10c-2.43,0-4.67,0.79-6.49,2.13c-0.72,0.53-0.76,1.6-0.13,2.24 c0.53,0.54,1.37,0.57,1.98,0.12C8.67,13.55,10.27,13,12,13c1.73,0,3.33,0.55,4.64,1.49c0.62,0.44,1.45,0.41,1.98-0.12 C19.26,13.73,19.22,12.66,18.49,12.13z M22.8,7.89C19.86,5.46,16.1,4,12,4S4.14,5.46,1.2,7.89C0.53,8.44,0.49,9.47,1.11,10.1l0,0 c0.55,0.55,1.42,0.58,2.02,0.09C5.55,8.2,8.64,7,12,7s6.45,1.2,8.87,3.19c0.6,0.49,1.47,0.46,2.02-0.09l0,0 C23.51,9.47,23.47,8.44,22.8,7.89z M12,16c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S13.1,16,12,16z M23,19v-1c0-1.1-0.9-2-2-2 s-2,0.9-2,2v1c-0.55,0-1,0.45-1,1v3c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1v-3C24,19.45,23.55,19,23,19z M22,19h-2v-1 c0-0.55,0.45-1,1-1s1,0.45,1,1V19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
