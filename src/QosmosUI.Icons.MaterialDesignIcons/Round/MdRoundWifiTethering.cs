// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWifiTethering : ComponentBase
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
		builder.AddAttribute(17, "d", "M12 11c-1.1 0-2 .9-2 2s.9 2 2 2 2-.9 2-2-.9-2-2-2zm6 2c0-3.56-3.11-6.4-6.75-5.95-2.62.32-4.78 2.41-5.18 5.02-.33 2.15.49 4.11 1.93 5.4.48.43 1.23.33 1.56-.23l.01-.01c.24-.42.14-.93-.22-1.26-1.03-.93-1.59-2.37-1.22-3.94.33-1.42 1.48-2.57 2.9-2.91C13.65 8.49 16 10.47 16 13c0 1.18-.52 2.23-1.33 2.96-.36.32-.47.84-.23 1.26l.01.01c.31.53 1.03.69 1.5.28C17.2 16.41 18 14.8 18 13zm-7.17-9.93c-4.62.52-8.35 4.33-8.78 8.96-.35 3.7 1.32 7.02 4.02 9.01.48.35 1.16.2 1.46-.31.25-.43.14-.99-.26-1.29-2.28-1.69-3.65-4.55-3.16-7.7.54-3.5 3.46-6.29 6.98-6.68C15.91 4.51 20 8.28 20 13c0 2.65-1.29 4.98-3.27 6.44-.4.3-.51.85-.26 1.29.3.52.98.66 1.46.31C20.4 19.22 22 16.3 22 13c0-5.91-5.13-10.62-11.17-9.93z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
