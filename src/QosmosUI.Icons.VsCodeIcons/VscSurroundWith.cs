// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons;

public class VscSurroundWith : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M2 3.99988H3V2.99988H1.5L1 3.49988V12.4999L1.5 12.9999H3V11.9999H2V3.99988ZM14.5 2.99988H13V3.99988H14V11.9999H13V12.9999H14.5L15 12.4999V3.49988L14.5 2.99988ZM5 8.99988C5.55228 8.99988 6 8.55216 6 7.99988C6 7.44759 5.55228 6.99988 5 6.99988C4.44772 6.99988 4 7.44759 4 7.99988C4 8.55216 4.44772 8.99988 5 8.99988ZM9 7.99988C9 8.55216 8.55228 8.99988 8 8.99988C7.44772 8.99988 7 8.55216 7 7.99988C7 7.44759 7.44772 6.99988 8 6.99988C8.55228 6.99988 9 7.44759 9 7.99988ZM11 8.99988C11.5523 8.99988 12 8.55216 12 7.99988C12 7.44759 11.5523 6.99988 11 6.99988C10.4477 6.99988 10 7.44759 10 7.99988C10 8.55216 10.4477 8.99988 11 8.99988Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
