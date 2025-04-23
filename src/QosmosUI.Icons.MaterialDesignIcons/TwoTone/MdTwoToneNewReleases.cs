// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneNewReleases : ComponentBase
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
		builder.AddAttribute(17, "d", "m18.49 9.89.26-2.79-2.74-.62-1.43-2.41L12 5.18 9.42 4.07 7.99 6.48l-2.74.62.26 2.78L3.66 12l1.85 2.11-.26 2.8 2.74.62 1.43 2.41L12 18.82l2.58 1.11 1.43-2.41 2.74-.62-.26-2.79L20.34 12l-1.85-2.11zM13 17h-2v-2h2v2zm0-4h-2V7h2v6z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "m20.9 5.54-3.61-.82-1.89-3.18L12 3 8.6 1.54 6.71 4.72l-3.61.81.34 3.68L1 12l2.44 2.78-.34 3.69 3.61.82 1.89 3.18L12 21l3.4 1.46 1.89-3.18 3.61-.82-.34-3.68L23 12l-2.44-2.78.34-3.68zM18.75 16.9l-2.74.62-1.43 2.41L12 18.82l-2.58 1.11-1.43-2.41-2.74-.62.26-2.8L3.66 12l1.85-2.12-.26-2.78 2.74-.61 1.43-2.41L12 5.18l2.58-1.11 1.43 2.41 2.74.62-.26 2.79L20.34 12l-1.85 2.11.26 2.79zM11 15h2v2h-2zm0-8h2v6h-2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
