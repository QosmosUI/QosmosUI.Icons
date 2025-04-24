// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBlackmagicdesign : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M10.385 0c-1.15 0-2.076.93-2.076 2.076V5.31c0 1.148.929 2.076 2.076 2.076h3.23c1.15 0 2.076-.93 2.076-2.076V2.076A2.074 2.074 0 0 0 13.615 0h-3.23zm0 .924h3.23c.638 0 1.155.514 1.155 1.152V5.31c0 .638-.516 1.152-1.155 1.152h-3.23A1.152 1.152 0 0 1 9.23 5.309V2.076c0-.638.516-1.152 1.155-1.152zm0 7.385c-1.15 0-2.076.929-2.076 2.076v3.23c0 1.15.929 2.076 2.076 2.076h3.23c1.15 0 2.076-.929 2.076-2.076v-3.23c0-1.15-.929-2.076-2.076-2.076h-3.23zm0 .921h3.23c.638 0 1.155.516 1.155 1.155v3.23c0 .638-.516 1.155-1.155 1.155h-3.23a1.154 1.154 0 0 1-1.155-1.155v-3.23c0-.638.516-1.155 1.155-1.155zm0 7.385c-1.15 0-2.076.93-2.076 2.076v3.233c0 1.149.929 2.076 2.076 2.076h3.23c1.15 0 2.076-.93 2.076-2.076V18.69a2.075 2.075 0 0 0-2.076-2.076h-3.23zm0 .924h3.23c.638 0 1.155.514 1.155 1.152v3.233c0 .638-.516 1.152-1.155 1.152h-3.23a1.152 1.152 0 0 1-1.155-1.152V18.69c0-.638.516-1.152 1.155-1.152Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
