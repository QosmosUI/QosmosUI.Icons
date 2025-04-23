// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundExploreOff : ComponentBase
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
		builder.AddAttribute(17, "d", "M18 6l-2.91 6.26 5.25 5.25C21.39 15.93 22 14.04 22 12c0-5.52-4.48-10-10-10-2.04 0-3.93.61-5.51 1.66l5.25 5.25L18 6zM2.81 5.64l.85.85c-1.37 2.07-2 4.68-1.48 7.45.75 3.95 3.92 7.13 7.88 7.88 2.77.52 5.38-.1 7.45-1.48l.85.85c.39.39 1.02.39 1.41 0 .39-.39.39-1.02 0-1.41L4.22 4.22c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.03 0 1.42zm6.1 6.1l3.35 3.35L6 18l2.91-6.26z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
