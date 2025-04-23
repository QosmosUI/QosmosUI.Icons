// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFormatShapes : ComponentBase
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
		builder.AddAttribute(17, "d", "M23 6V2c0-.55-.45-1-1-1h-4c-.55 0-1 .45-1 1v1H7V2c0-.55-.45-1-1-1H2c-.55 0-1 .45-1 1v4c0 .55.45 1 1 1h1v10H2c-.55 0-1 .45-1 1v4c0 .55.45 1 1 1h4c.55 0 1-.45 1-1v-1h10v1c0 .55.45 1 1 1h4c.55 0 1-.45 1-1v-4c0-.55-.45-1-1-1h-1V7h1c.55 0 1-.45 1-1zM3 3h2v2H3V3zm2 18H3v-2h2v2zm12-2H7v-1c0-.55-.45-1-1-1H5V7h1c.55 0 1-.45 1-1V5h10v1c0 .55.45 1 1 1h1v10h-1c-.55 0-1 .45-1 1v1zm4 2h-2v-2h2v2zM19 5V3h2v2h-2zm-6.06 2.65c-.15-.39-.53-.65-.95-.65-.42 0-.8.26-.94.65l-2.77 7.33c-.19.49.17 1.02.7 1.02.32 0 .6-.2.71-.5l.55-1.5h3.49l.56 1.51c.11.29.39.49.71.49h.01c.53 0 .89-.53.71-1.02l-2.78-7.33zm-2.25 5.09L12 8.91l1.3 3.83h-2.61z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
