// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDwavesystems : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M10.1062 12.0046c0 1.5815-1.2842 2.8636-2.8685 2.8636-1.5842 0-2.8684-1.282-2.8684-2.8636 0-1.5815 1.2842-2.8635 2.8684-2.8635 1.5843 0 2.8685 1.2821 2.8685 2.8635zM7.2377 0C5.6536 0 4.3693 1.2817 4.3693 2.8628s1.2842 2.8629 2.8684 2.8629c1.5842 0 2.8685-1.2817 2.8685-2.8629C10.1062 1.2817 8.822 0 7.2377 0zm9.5246 18.2781c-1.5838 0-2.8677 1.2764-2.8677 2.8636 0 1.5763 1.2835 2.8583 2.8677 2.8583 1.5845 0 2.8684-1.282 2.8684-2.8583 0-1.5872-1.2843-2.8636-2.8684-2.8636zm-2.8685-6.2735c0-1.5815 1.2842-2.8635 2.8685-2.8635 1.5842 0 2.8684 1.282 2.8684 2.8635 0 1.5815-1.2842 2.8636-2.8684 2.8636-1.5843 0-2.8685-1.282-2.8685-2.8636zm.5 0c0 1.3033 1.0625 2.3636 2.3685 2.3636s2.3684-1.0603 2.3684-2.3636c0-1.3032-1.0624-2.3635-2.3684-2.3635s-2.3685 1.0603-2.3685 2.3635z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
