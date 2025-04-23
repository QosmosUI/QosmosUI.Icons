// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiWeatherDownpour : ComponentBase
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
		builder.AddAttribute(15, "d", "M15 22c-.552 0-1-.447-1-1v-6c0-.553.448-1 1-1s1 .447 1 1v6c0 .553-.448 1-1 1zM9 22c-.552 0-1-.447-1-1v-6c0-.553.448-1 1-1s1 .447 1 1v6c0 .553-.448 1-1 1zM12 24c-.552 0-1-.447-1-1v-6c0-.553.448-1 1-1s1 .447 1 1v6c0 .553-.448 1-1 1zM6 18c-2.206 0-4-1.794-4-4 0-1.861 1.277-3.429 3.001-3.874l-.001-.126c0-3.309 2.691-6 6-6 2.587 0 4.824 1.639 5.65 4.015 2.936-.244 5.35 2.113 5.35 4.985 0 2.241-1.507 4.223-3.666 4.819-.535.146-1.083-.166-1.23-.697-.147-.532.165-1.083.698-1.23 1.294-.358 2.198-1.547 2.198-2.892 0-1.654-1.346-3-3-3-.242 0-.499.041-.811.13l-1.074.306-.185-1.102c-.326-1.932-1.978-3.334-3.93-3.334-2.206 0-4 1.794-4 4 0 .272.027.545.082.808l.248 1.202-1.422-.016c-1.011.006-1.908.903-1.908 2.006s.897 2 2 2c.552 0 1 .447 1 1s-.448 1-1 1z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
