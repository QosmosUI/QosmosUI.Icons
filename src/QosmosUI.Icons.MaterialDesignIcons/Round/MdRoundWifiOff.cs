// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWifiOff : ComponentBase
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
		builder.AddAttribute(17, "d", "M20.06 10.14c.56.46 1.38.42 1.89-.09.59-.59.55-1.57-.1-2.1-3.59-2.94-8.2-4.03-12.55-3.26l2.59 2.59c2.89-.03 5.8.92 8.17 2.86zm-2.27 1.83c-.78-.57-1.63-1-2.52-1.3l2.95 2.95c.24-.58.1-1.27-.43-1.65zm-3.84 4.26c-1.22-.63-2.68-.63-3.91 0-.59.31-.7 1.12-.23 1.59l1.47 1.47c.39.39 1.02.39 1.41 0l1.47-1.47c.49-.47.39-1.28-.21-1.59zm5.73 1.67L4.12 2.34c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41L5.05 6.1c-1.01.5-1.99 1.11-2.89 1.85-.65.53-.69 1.51-.1 2.1.51.51 1.32.56 1.87.1 1-.82 2.1-1.46 3.25-1.93l2.23 2.23c-1.13.3-2.21.8-3.19 1.51-.69.5-.73 1.51-.13 2.11l.01.01c.49.49 1.26.54 1.83.13 1.19-.84 2.58-1.26 3.97-1.29l6.37 6.37c.39.39 1.02.39 1.41 0 .39-.37.39-1 0-1.39z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
