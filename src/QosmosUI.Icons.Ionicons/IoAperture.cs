// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoAperture : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M250.54,129.17l-67.8-67.8A209.65,209.65,0,0,0,86.32,136h161.4A4,4,0,0,0,250.54,129.17Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M167.72,168H67.63A207.34,207.34,0,0,0,51.48,293.9L170.54,174.83A4,4,0,0,0,167.72,168Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M344,167.72V67.56A207.82,207.82,0,0,0,218.11,51.48L337.17,170.54A4,4,0,0,0,344,167.72Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M460.52,218.1,341.46,337.17a4,4,0,0,0,2.82,6.83H444.37a207.34,207.34,0,0,0,16.15-125.9Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M382.83,250.54l67.83-67.82A209.08,209.08,0,0,0,376,86.2V247.72A4,4,0,0,0,382.83,250.54Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M221.68,341.77a8,8,0,0,0,5.54,2.23h59.66a8,8,0,0,0,5.7-2.39l49.18-50a8,8,0,0,0,2.3-5.62L344,225.18a8,8,0,0,0-2.38-5.69l-50-49.25a8,8,0,0,0-5.63-2.3l-60.84.06a8,8,0,0,0-5.69,2.38l-49.25,50a8,8,0,0,0-2.3,5.63l.06,60.78a8,8,0,0,0,2.45,5.76Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M261.46,382.83l67.8,67.8A209.65,209.65,0,0,0,425.68,376H264.28A4,4,0,0,0,261.46,382.83Z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M168,344.28V444.44a207.82,207.82,0,0,0,125.89,16.08L174.83,341.46A4,4,0,0,0,168,344.28Z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M129.17,261.46,61.34,329.29A209.1,209.1,0,0,0,136,425.8V264.28A4,4,0,0,0,129.17,261.46Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
