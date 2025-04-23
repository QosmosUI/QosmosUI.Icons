// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaMillSign : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 384 512";

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
		builder.AddAttribute(14, "d", "M302.1 42.8c5.9-16.6-2.7-35-19.4-40.9s-35 2.7-40.9 19.4L208 116.1c-5.7 4-11.1 8.5-16 13.5C171.7 108.9 143.3 96 112 96c-19.5 0-37.8 5-53.7 13.7C52.5 101.4 42.9 96 32 96C14.3 96 0 110.3 0 128l0 80L0 416c0 17.7 14.3 32 32 32s32-14.3 32-32l0-208c0-26.5 21.5-48 48-48s48 21.5 48 48l0 42.5L81.9 469.2c-5.9 16.6 2.7 35 19.4 40.9s35-2.7 40.9-19.4l21.4-60C168.9 441 179.6 448 192 448c17.7 0 32-14.3 32-32l0-154.5 35.7-100c3.9-1 8.1-1.6 12.3-1.6c26.5 0 48 21.5 48 48l0 208c0 17.7 14.3 32 32 32s32-14.3 32-32l0-208c0-58.2-44.3-106-101.1-111.5l19.2-53.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
