// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundBrightnessMedium : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20 15.31l1.9-1.9c.78-.78.78-2.05 0-2.83L20 8.69V6c0-1.1-.9-2-2-2h-2.69l-1.9-1.9c-.78-.78-2.05-.78-2.83 0L8.69 4H6c-1.1 0-2 .9-2 2v2.69l-1.9 1.9c-.78.78-.78 2.05 0 2.83l1.9 1.9V18c0 1.1.9 2 2 2h2.69l1.9 1.9c.78.78 2.05.78 2.83 0l1.9-1.9H18c1.1 0 2-.9 2-2v-2.69zm-8 1.59V7.1c0-.61.55-1.11 1.15-.99C15.91 6.65 18 9.08 18 12s-2.09 5.35-4.85 5.89c-.6.12-1.15-.38-1.15-.99z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
