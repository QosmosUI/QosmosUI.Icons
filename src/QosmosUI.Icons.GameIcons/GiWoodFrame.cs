// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWoodFrame : ComponentBase
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
		builder.AddAttribute(14, "d", "M100.3 19.86l-36.62 2.02-.72 13.1a16 16 0 0 1 5.18-.86 16 16 0 0 1 16 16 16 16 0 0 1-16 16 16 16 0 0 1-16-16 16 16 0 0 1 2.38-8.4l-6.44-18.98-15.63.86-.78 377.3 23.01-.8.55-105.9 12.23 105.5 46.84-1.6zm353.5 11.6L121.5 41.71l2.6 58.39L485 85.15l3.5-36.38zm7 72.74l-25.4 1-15 39-13.2-37.8-22.5 1-2.8 83.3 7.6 34-9.5 24.1-7.5 226.6 14.1.7 11.3-33.5 11.3 34.7 4.7.3 14.1-21.1 4.6 22 18.3 1zm-61.1 299a16 16 0 0 1 16 16 16 16 0 0 1-16 16 16 16 0 0 1-16-16 16 16 0 0 1 16-16zm85.3.8l-14.1.5-1.9 75.2 16.2-.1zm-128.3 4.2l-93 3-43.7 20.3-22-18.1-174.24 5.7-.28 63.8 330.82-2.3 1.3-40c-12.9-.3-87.9-2.3-89.6-2.3-1.6 0 69-9.9 90.1-13zM103 431.7a16 16 0 0 1 16 16 16 16 0 0 1-16 16 16 16 0 0 1-15.96-16 16 16 0 0 1 15.96-16zm-51.48.3a16 16 0 0 1 16 16 16 16 0 0 1-16 16 16 16 0 0 1-16-16 16 16 0 0 1 16-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
