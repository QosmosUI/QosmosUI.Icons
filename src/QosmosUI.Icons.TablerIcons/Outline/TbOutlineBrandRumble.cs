// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Outline;

public class TbOutlineBrandRumble : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.AddAttribute(14, "d", "M19.993 9.108c.383 .4 .687 .863 .893 1.368a4.195 4.195 0 0 1 .006 3.166a4.37 4.37 0 0 1 -.887 1.372a20.233 20.233 0 0 1 -2.208 2a20.615 20.615 0 0 1 -2.495 1.669a21.322 21.322 0 0 1 -5.622 2.202a4.213 4.213 0 0 1 -3.002 -.404a3.98 3.98 0 0 1 -1.163 -.967a3.796 3.796 0 0 1 -.695 -1.312c-1.199 -3.902 -1.022 -8.312 .134 -12.23c.609 -2.057 2.643 -3.349 4.737 -2.874c3.88 .88 7.52 3.147 10.302 6.01z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M14.044 13.034c.67 -.505 .67 -1.489 0 -2.01a14.824 14.824 0 0 0 -1.498 -1.044a15.783 15.783 0 0 0 -1.62 -.865c-.77 -.35 -1.63 .139 -1.753 .973a15.385 15.385 0 0 0 -.1 3.786a1.232 1.232 0 0 0 1.715 1.027a14.783 14.783 0 0 0 1.694 -.827a14.46 14.46 0 0 0 1.562 -1.035v-.005z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
