// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiToothbrush : ComponentBase
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
		builder.AddAttribute(14, "d", "M223.2 38.3 212.7 103l-41.7 6.8c-2.4.7-2.1 3.6 0 4.1l41.7 6.8 10.5 64.7c.7 2.3 3.8 1.9 4.1 0l10.6-64.7 41.7-6.8c2.3-.8 2-3.7 0-4.1l-41.7-6.8-10.6-64.7c-.7-2.35-3.7-1.89-4.1 0zm228.1 37-6.4 37.5-25.3 3.9c-2.3.8-2 3.8 0 4.2l25.3 3.9 6.4 37.5c.8 2.4 3.6 2.1 4.1 0l6.4-37.5 25.3-3.9c2.3-.8 2-3.8 0-4.2l-25.3-3.9-6.4-37.5c-.7-2.31-3.7-1.94-4.1 0zm-85 92.2c17.1 36 5 49.4-104 49.4-108.9 0-72 56.3-72 56.3h26.1c-.6-48.5 204.1-25.3 187.3-79.7 78.7 66.3-167.5 38.1-150.8 79.7H412c47.3 0 54.5-84.4-45.7-105.7zM92.53 179.3l-6.41 37.5-25.24 4c-2.43.7-1.96 3.7 0 4.1l25.24 3.9 6.41 37.6c.73 2.3 3.72 1.9 4.1 0l6.37-37.6 25.3-3.9c2.3-.7 1.9-3.8 0-4.1l-25.3-4-6.37-37.5c-.73-2.3-3.72-1.9-4.1 0zm85.17 106.2 5 90.3h18l3-64.8 3 64.8h16.6l3-64.8 3 64.8h16.5l3-64.8 3 64.8h16.6l3-64.8 3 64.8h16.5l3-64.8 3 64.8h16.6l3-64.8 3 64.8H336l3-64.8 3 64.8h16.6l3-64.8 3 64.8h16.6l3-64.8 3 64.8h16.5l3-64.8 3 64.8h20.4l5-90.3zM32.26 393.3v43h62.28c5.86 0 11.66-.7 17.26-2 19.1-4.3 38.1-4.1 57.1.1 5.6 1.2 11.3 1.9 17 1.9h243.8c7.9 0 14.4-6.5 14.4-14.5v-28.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
