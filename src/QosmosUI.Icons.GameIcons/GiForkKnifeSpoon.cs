// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiForkKnifeSpoon : ComponentBase
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
		builder.AddAttribute(14, "d", "M48 34v144c0 16 32 32 32 32 0 112-16 176-16 208 0 16 0 32 16 48s16 16 32 0 16-32 16-48c0-32-16-96-16-208 0 0 32-16 32-32V34h-18v96h-21V34H87v96H66V34H48zm202 0c-16 0-16 16-16 16v272h.4c-4.6 45.8-10.4 76.8-10.4 96 0 16 0 32 16 48s16 16 32 0 16-32 16-48c0-22.1-7.6-59.5-12.4-117.5C287.9 270.4 298 232.2 298 194c0-48-25.8-137.6-48-160zm166 0a64 96 0 0 0-64 96 64 96 0 0 0 47.9 92.8C398.8 326.9 384 387.2 384 418c0 16 0 32 16 48s16 16 32 0 16-32 16-48c0-30.8-14.8-91.1-15.9-195.1A64 96 0 0 0 480 130a64 96 0 0 0-64-96z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
