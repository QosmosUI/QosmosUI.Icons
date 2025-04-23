// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiOden : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M480.2 31.81L351.5 50.26 461.7 160.5zm-92.7 79.99l-13.1 13.1c2.3 1.8 4.6 3.8 6.7 5.9 2.2 2.2 4.2 4.5 6 6.9l13.2-13.2zm-58.1 15.5c-14 0-28.1 5.4-38.9 16.2-21.5 21.5-21.5 56.2 0 77.8 21.6 21.5 56.3 21.5 77.8 0 21.6-21.6 21.6-56.3 0-77.8-10.8-10.8-24.8-16.2-38.9-16.2zm-127.1 82l-32.6 32.5 100.5 100.5 32.5-32.6zm69.6 18l-13.1 13.1 12.8 12.8 13.1-13.1c-2.4-1.9-4.7-3.9-6.9-6.1-2.1-2.1-4.1-4.4-5.9-6.7zm-71 71.1l-169.09 169 12.72 12.8L213.6 311.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
