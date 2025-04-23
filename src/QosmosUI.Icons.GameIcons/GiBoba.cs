// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBoba : ComponentBase
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
		builder.AddAttribute(14, "d", "m187.4 22.88-21.5 4.54 22.7 108.08c7.2-.7 14.6-1.2 22-1.6L187.4 22.88zM256 147.7c-41.2 0-82.3 3.7-123.5 11.1l-11.6 1.1 4.3 22.1 10.6-2.1c20.1-3.2 40.1-6.3 61.2-7.4l8.4 40.1h22.2l-8.4-42.2c51.6-2.1 104.4 1.1 157.1 9.5l10.6 2.1 4.2-22.1-11.6-1.1c-41.2-7.4-82.3-11.1-123.5-11.1zm-119.1 51.6 26.4 281.3 8.3 1c56.2 9.5 112.3 10.6 168.5 0l8.1-1 26.5-281.3h-22.1l-3.6 37.8H232.2l42.3 202.3-24.3-9.5-40.4-192.8h-47.3l-3.6-37.8h-22zm188.8 155.3c7.4 0 13.5 6 13.5 13.5s-6.1 13.5-13.5 13.5c-7.5 0-13.5-6-13.5-13.5s6-13.5 13.5-13.5zM292 380.2c7.4 0 13.6 6.1 13.6 13.5 0 7.5-6.2 13-13.6 13-7.4 0-13.6-5.5-13.6-13 0-7.4 6.2-13.5 13.6-13.5zm-74.2 5.1c7.5 0 13.5 6.1 13.5 13.5 0 7.9-6 13.2-13.5 13.2-7.4 0-13.5-5.3-13.5-13.2 0-7.4 6.1-13.5 13.5-13.5zm107 7.8c7.5 0 13.6 6 13.6 13.6 0 7.4-6.1 13.7-13.6 13.7-7.4 0-13.5-6.3-13.5-13.7 0-7.6 6.1-13.6 13.5-13.6zm-140.9 10.5c7.5 0 13.5 5.2 13.5 12.6 0 7.4-6 13.7-13.5 13.7s-13.5-6.3-13.5-13.7c0-7.4 6-12.6 13.5-12.6zm111.2 12.6c7.5 0 13.5 6.3 13.5 13.7 0 7.4-6 13.7-13.5 13.7s-13.5-6.3-13.5-13.7c0-7.4 6-13.7 13.5-13.7zm-76.1 7.4c7.5 0 13.6 6.3 13.6 13.7 0 7.4-6.1 13.7-13.6 13.7-7.4 0-13.5-6.3-13.5-13.7 0-7.4 6.1-13.7 13.5-13.7zm-32.7 14.8c7.5 0 13.5 5.2 13.5 12.6 0 7.4-6 13.7-13.5 13.7-7.4 0-13.5-6.3-13.5-13.7 0-7.4 6.1-12.6 13.5-12.6zm134.7 2.1c7.5 0 13.5 6.3 13.5 13.7 0 7.4-6 13.7-13.5 13.7s-13.5-6.3-13.5-13.7c0-7.4 6-13.7 13.5-13.7zm-66.5 4.2c7.4 0 13.5 5.3 13.5 12.7 0 7.3-6.1 13.7-13.5 13.7-7.5 0-13.5-6.4-13.5-13.7 0-7.4 6-12.7 13.5-12.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
