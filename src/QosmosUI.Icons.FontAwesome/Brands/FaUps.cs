// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaUps : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 384 512";

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
		builder.AddAttribute(14, "d", "M103.2 303c-5.2 3.6-32.6 13.1-32.6-19V180H37.9v102.6c0 74.9 80.2 51.1 97.9 39V180h-32.6zM4 74.82v220.9c0 103.7 74.9 135.2 187.7 184.1 112.4-48.9 187.7-80.2 187.7-184.1V74.82c-116.3-61.6-281.8-49.6-375.4 0zm358.1 220.9c0 86.6-53.2 113.6-170.4 165.3-117.5-51.8-170.5-78.7-170.5-165.3v-126.4c102.3-93.8 231.6-100 340.9-89.8zm-209.6-107.4v212.8h32.7v-68.7c24.4 7.3 71.7-2.6 71.7-78.5 0-97.4-80.7-80.92-104.4-65.6zm32.7 117.3v-100.3c8.4-4.2 38.4-12.7 38.4 49.3 0 67.9-36.4 51.8-38.4 51zm79.1-86.4c.1 47.3 51.6 42.5 52.2 70.4.6 23.5-30.4 23-50.8 4.9v30.1c36.2 21.5 81.9 8.1 83.2-33.5 1.7-51.5-54.1-46.6-53.4-73.2.6-20.3 30.6-20.5 48.5-2.2v-28.4c-28.5-22-79.9-9.2-79.7 31.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
