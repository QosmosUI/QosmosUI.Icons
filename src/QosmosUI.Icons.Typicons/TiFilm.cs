// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiFilm : ComponentBase
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
		builder.AddAttribute(15, "d", "M8 8v7h8v-7h-8zm7 6h-6v-5h6v5zM17 2h-3v2h-4v-2h-3c-1.654 0-3 1.346-3 3v13c0 1.654 1.346 3 3 3h3v-2h4v2h3c1.654 0 3-1.346 3-3v-13c0-1.654-1.346-3-3-3zm1 4c-.553 0-1 .447-1 1s.447 1 1 1v1c-.553 0-1 .447-1 1s.447 1 1 1v1c-.553 0-1 .447-1 1s.447 1 1 1v1c-.553 0-1 .447-1 1s.447 1 1 1v1c0 .551-.448 1-1 1h-1v-2h-8v2h-1c-.552 0-1-.449-1-1v-1c.553 0 1-.447 1-1s-.447-1-1-1v-1c.553 0 1-.447 1-1s-.447-1-1-1v-1c.553 0 1-.447 1-1s-.447-1-1-1v-1c.553 0 1-.447 1-1s-.447-1-1-1v-1c0-.551.448-1 1-1h1v2h8v-2h1c.552 0 1 .449 1 1v1z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
