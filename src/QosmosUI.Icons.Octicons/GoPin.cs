// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoPin : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "m16.114 1.553 6.333 6.333a1.75 1.75 0 0 1-.603 2.869l-1.63.633a5.67 5.67 0 0 0-3.395 3.725l-1.131 3.959a1.75 1.75 0 0 1-2.92.757L9 16.061l-5.595 5.594a.749.749 0 1 1-1.06-1.06L7.939 15l-3.768-3.768a1.75 1.75 0 0 1 .757-2.92l3.959-1.131a5.666 5.666 0 0 0 3.725-3.395l.633-1.63a1.75 1.75 0 0 1 2.869-.603ZM5.232 10.171l8.597 8.597a.25.25 0 0 0 .417-.108l1.131-3.959A7.17 7.17 0 0 1 19.67 9.99l1.63-.634a.25.25 0 0 0 .086-.409l-6.333-6.333a.25.25 0 0 0-.409.086l-.634 1.63a7.17 7.17 0 0 1-4.711 4.293L5.34 9.754a.25.25 0 0 0-.108.417Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
