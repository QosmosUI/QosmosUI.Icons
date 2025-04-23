// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaMercury : ComponentBase
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
		builder.AddAttribute(14, "d", "M72.1 7C85.8-4 106-1.8 117 12c17.6 22 44.7 36 75 36s57.3-14 75-36c11.1-13.8 31.2-16 45-5s16 31.2 5 45c-7.8 9.7-16.6 18.4-26.4 26.1C337.3 109.7 368 163.3 368 224c0 89.1-66.2 162.7-152 174.4l0 25.6 32 0c13.3 0 24 10.7 24 24s-10.7 24-24 24l-32 0 0 16c0 13.3-10.7 24-24 24s-24-10.7-24-24l0-16-32 0c-13.3 0-24-10.7-24-24s10.7-24 24-24l32 0 0-25.6C82.2 386.7 16 313.1 16 224c0-60.7 30.7-114.3 77.5-145.9C83.7 70.5 74.9 61.7 67.1 52c-11.1-13.8-8.8-33.9 5-45zM80 224a112 112 0 1 0 224 0A112 112 0 1 0 80 224z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
