// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFilterTiltShift : ComponentBase
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
		builder.AddAttribute(17, "d", "M11 3.23c0-.64-.59-1.13-1.21-.99-1.12.26-2.18.7-3.12 1.3-.53.34-.61 1.1-.16 1.55.32.32.83.4 1.21.16.77-.49 1.62-.85 2.54-1.05.44-.1.74-.51.74-.97zm6.33.32c-.94-.6-2-1.04-3.12-1.3-.62-.14-1.21.34-1.21.98 0 .45.3.87.74.96.91.2 1.77.57 2.53 1.05.39.24.89.17 1.21-.16.46-.44.39-1.19-.15-1.53zM20.77 11c.64 0 1.13-.59.99-1.21-.26-1.12-.7-2.18-1.3-3.12-.34-.53-1.1-.61-1.55-.16-.32.32-.4.83-.16 1.21.49.77.85 1.62 1.05 2.53.1.45.51.75.97.75zM5.1 6.51c-.46-.45-1.21-.38-1.55.16-.6.94-1.04 2-1.3 3.12-.14.62.34 1.21.98 1.21.45 0 .87-.3.96-.74.2-.91.57-1.77 1.05-2.53.26-.39.18-.9-.14-1.22zM3.23 13c-.64 0-1.13.59-.99 1.21.26 1.12.7 2.17 1.3 3.12.34.54 1.1.61 1.55.16.32-.32.4-.83.15-1.21-.49-.76-.85-1.61-1.05-2.53-.09-.45-.5-.75-.96-.75zM15 12c0-1.66-1.34-3-3-3s-3 1.34-3 3 1.34 3 3 3 3-1.34 3-3zm3.9 5.49c.45.45 1.21.38 1.55-.15.6-.94 1.04-2 1.3-3.11.14-.62-.35-1.21-.98-1.21-.45 0-.87.3-.96.74-.2.91-.57 1.76-1.05 2.53-.26.37-.18.88.14 1.2zM13 20.77c0 .64.59 1.13 1.21.99 1.12-.26 2.17-.7 3.12-1.3.54-.34.61-1.1.16-1.55-.32-.32-.83-.4-1.21-.15-.76.49-1.61.85-2.53 1.05-.45.09-.75.5-.75.96zm-6.33-.32c.95.6 2 1.04 3.12 1.3.62.14 1.21-.35 1.21-.98 0-.45-.3-.87-.74-.96-.91-.2-1.77-.57-2.53-1.05-.39-.24-.89-.17-1.21.16-.46.44-.39 1.19.15 1.53z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
