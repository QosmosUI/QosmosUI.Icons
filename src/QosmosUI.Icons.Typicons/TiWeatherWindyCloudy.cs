// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiWeatherWindyCloudy : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M4.798 15.75c-.134 0-.27-.026-.4-.084-1.457-.639-2.398-2.077-2.398-3.666 0-1.861 1.277-3.429 3.001-3.874l-.001-.126c0-3.309 2.691-6 6-6 2.932 0 5.413 2.104 5.902 5.001.092.544-.275 1.061-.82 1.152-.544.083-1.06-.276-1.152-.82-.326-1.931-1.979-3.333-3.93-3.333-2.206 0-4 1.794-4 4 0 .272.027.546.081.812l.259 1.27-1.431-.088c-1.012.006-1.909.903-1.909 2.006 0 .795.471 1.515 1.2 1.834.506.222.736.812.515 1.317-.164.375-.531.599-.917.599zM19 7c-.553 0-1 .447-1 1s.447 1 1 1c.552 0 1 .448 1 1s-.448 1-1 1h-9.6c-.553 0-1 .447-1 1s.447 1 1 1h4.6c.552 0 1 .448 1 1s-.448 1-1 1h-5c-1.654 0-3 1.346-3 3s1.346 3 3 3c.553 0 1-.447 1-1s-.447-1-1-1c-.552 0-1-.448-1-1s.448-1 1-1h5c1.654 0 3-1.346 3-3 0-.353-.072-.686-.185-1h2.185c1.654 0 3-1.346 3-3s-1.346-3-3-3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
