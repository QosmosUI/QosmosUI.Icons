// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoRibbon : ComponentBase
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
		builder.AddAttribute(14, "d", "M269,335.61q-6.33.47-12.78.47c-5.23,0-10.4-.24-15.51-.69a176.11,176.11,0,0,1-127.67-72.94,4,4,0,0,0-6.77.35l-72,129.4c-2.74,5-3.17,11-.28,15.88A16.78,16.78,0,0,0,48.22,416h78a15.28,15.28,0,0,1,13.62,7.33L178.5,488a16.26,16.26,0,0,0,13.75,8h0c5.94-.33,12.09-4.19,14.56-9.6l66.11-145.15A4,4,0,0,0,269,335.61Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M477.64,391.88,406.11,262.71a4,4,0,0,0-6.74-.36,176.5,176.5,0,0,1-78.31,61.42,16.09,16.09,0,0,0-8.72,8.25l-36.86,81.1a7.92,7.92,0,0,0,0,6.6l30.27,66.59c2.45,5.41,8.59,9.36,14.52,9.69h0a16.3,16.3,0,0,0,13.7-8.12L372.5,423.3c2.89-4.85,8.13-7.33,13.78-7.3h78.77c6.67,0,11.72-3.48,14-10A16.92,16.92,0,0,0,477.64,391.88Z");
		builder.CloseElement();
		builder.OpenElement(17, "ellipse");
		builder.AddAttribute(18, "cx", "256.26");
		builder.AddAttribute(19, "cy", "160");
		builder.AddAttribute(20, "rx", "48.01");
		builder.AddAttribute(21, "ry", "48");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M256.26,16c-79.42,0-144,64.59-144,144s64.61,144,144,144,144-64.6,144-144S335.67,16,256.26,16Zm0,224a80,80,0,1,1,80-80A80.1,80.1,0,0,1,256.26,240Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
