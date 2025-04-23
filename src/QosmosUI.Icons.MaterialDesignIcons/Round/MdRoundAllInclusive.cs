// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAllInclusive : ComponentBase
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
		builder.AddAttribute(17, "d", "M20.22 6.86c-2-.6-4.06-.04-5.39 1.29L12 10.66 10.48 12h.01L7.8 14.39c-.81.81-1.95 1.15-3.12.92-1.25-.25-2.28-1.25-2.57-2.49-.52-2.23 1.16-4.2 3.29-4.2.91 0 1.76.35 2.44 1.03l.47.41c.38.34.95.34 1.33 0 .45-.4.45-1.1 0-1.5l-.42-.36C8.2 7.18 6.84 6.62 5.4 6.62 2.42 6.62 0 9.04 0 12s2.42 5.38 5.4 5.38c1.44 0 2.8-.56 3.77-1.53l2.83-2.5.01.01L13.52 12h-.01l2.69-2.39c.81-.81 1.95-1.15 3.12-.92 1.25.25 2.28 1.25 2.57 2.49.52 2.23-1.16 4.2-3.29 4.2-.9 0-1.76-.35-2.44-1.03l-.48-.42c-.38-.34-.95-.34-1.33 0-.45.4-.45 1.1 0 1.5l.42.37c1.02 1.01 2.37 1.57 3.82 1.57 3.27 0 5.86-2.9 5.33-6.25-.3-1.99-1.77-3.69-3.7-4.26z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
