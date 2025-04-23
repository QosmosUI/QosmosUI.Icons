// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiLayoutGrid4 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M1 4h3v-3h-3v3zM2 2h1v1h-1v-1zM5 4h3v-3h-3v3zM6 2h1v1h-1v-1zM9 4h3v-3h-3v3zM10 2h1v1h-1v-1zM13 1v3h3v-3h-3zM15 3h-1v-1h1v1zM1 8h3v-3h-3v3zM2 6h1v1h-1v-1zM5 8h3v-3h-3v3zM6 6h1v1h-1v-1zM9 8h3v-3h-3v3zM10 6h1v1h-1v-1zM13 8h3v-3h-3v3zM14 6h1v1h-1v-1zM1 12h3v-3h-3v3zM2 10h1v1h-1v-1zM5 12h3v-3h-3v3zM6 10h1v1h-1v-1zM9 12h3v-3h-3v3zM10 10h1v1h-1v-1zM13 12h3v-3h-3v3zM14 10h1v1h-1v-1zM1 16h3v-3h-3v3zM2 14h1v1h-1v-1zM5 16h3v-3h-3v3zM6 14h1v1h-1v-1zM9 16h3v-3h-3v3zM10 14h1v1h-1v-1zM13 16h3v-3h-3v3zM14 14h1v1h-1v-1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
