// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaRug : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 640 512";

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
		builder.AddAttribute(14, "d", "M24 64l32 0 24 0 0 24 0 88 0 80 0 80 0 88 0 24-24 0-32 0c-13.3 0-24-10.7-24-24s10.7-24 24-24l8 0 0-40-8 0c-13.3 0-24-10.7-24-24s10.7-24 24-24l8 0 0-32-8 0c-13.3 0-24-10.7-24-24s10.7-24 24-24l8 0 0-32-8 0c-13.3 0-24-10.7-24-24s10.7-24 24-24l8 0 0-40-8 0C10.7 112 0 101.3 0 88S10.7 64 24 64zm88 0l416 0 0 384-416 0 0-384zM640 88c0 13.3-10.7 24-24 24l-8 0 0 40 8 0c13.3 0 24 10.7 24 24s-10.7 24-24 24l-8 0 0 32 8 0c13.3 0 24 10.7 24 24s-10.7 24-24 24l-8 0 0 32 8 0c13.3 0 24 10.7 24 24s-10.7 24-24 24l-8 0 0 40 8 0c13.3 0 24 10.7 24 24s-10.7 24-24 24l-32 0-24 0 0-24 0-88 0-80 0-80 0-88 0-24 24 0 32 0c13.3 0 24 10.7 24 24z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
