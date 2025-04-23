// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBilledCap : ComponentBase
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
		builder.AddAttribute(14, "d", "M195.7 53.97c-6.5-.1-16.1 2.87-15.6 9.53.4 5.62 36.7 4.08 36.8-.21.2-6.21-14.1-9.26-21.2-9.32zm-74.6 41.99c-16 7.14-33.09 16.14-45.82 28.34-33.62 35.1-56.12 87.9-50.74 172.6 16.25 22.5 76.46 36.7 108.06 41.7 51.1-22 206.3-45.3 265.1-22.1-1.4-47.7-13.8-105.6-45.1-151.9-19.6-35.8-50.2-62-89.9-75.84-45.6-14.5-97-13.1-141.6 7.2zM151.4 356c30.9 46 62.2 82.9 108.7 101.6 2.6.5 6.6 1.1 9.8-1.3 38.8-29.3 146.8-33.6 212.6-14.8 3.6 1 7.1-4.5 5.1-8.2-17.4-31.7-36.9-63.7-75-90-78.8-32.6-191.1-7.8-261.2 12.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
