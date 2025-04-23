// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaIoxhost : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 640 512";

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
		builder.AddAttribute(14, "d", "M616 160h-67.3C511.2 70.7 422.9 8 320 8 183 8 72 119 72 256c0 16.4 1.6 32.5 4.7 48H24c-13.3 0-24 10.8-24 24 0 13.3 10.7 24 24 24h67.3c37.5 89.3 125.8 152 228.7 152 137 0 248-111 248-248 0-16.4-1.6-32.5-4.7-48H616c13.3 0 24-10.8 24-24 0-13.3-10.7-24-24-24zm-96 96c0 110.5-89.5 200-200 200-75.7 0-141.6-42-175.5-104H424c13.3 0 24-10.8 24-24 0-13.3-10.7-24-24-24H125.8c-3.8-15.4-5.8-31.4-5.8-48 0-110.5 89.5-200 200-200 75.7 0 141.6 42 175.5 104H216c-13.3 0-24 10.8-24 24 0 13.3 10.7 24 24 24h298.2c3.8 15.4 5.8 31.4 5.8 48zm-304-24h208c13.3 0 24 10.7 24 24 0 13.2-10.7 24-24 24H216c-13.3 0-24-10.7-24-24 0-13.2 10.7-24 24-24z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
