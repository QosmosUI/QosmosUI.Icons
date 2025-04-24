// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBoxUnpacking : ComponentBase
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
		builder.AddAttribute(14, "d", "M61.39 25.39C93.9 58.33 115.8 96.55 133.3 134.5c4.9-12 7.3-22.2 18.9-32.3 47 26.5 60.3 43.3 64.4 80.4h66.8c1.8-36 7.6-56.3 36.5-82.81 15.9 12.41 20 26.91 28.1 40.71 8.5-38.9 37.3-81.28 76.7-101.89-52.5-11.56-108.5-.43-153.3 17.54 9.3 6.39 22.7 11.23 26.9 19.5-19 9.79-39.5 42.35-51.2 69.35-14.1-25.1-43.5-53.44-72-67.64 11.5-11.58 23-15.79 34.5-22.89C176.6 36.1 117.5 27 61.39 25.39zm8.85 175.21l-41.25 110H137.8l41.2-110zm134.76 0l41.2 110H483l-41.2-110zm-22 40.6l-32.8 87.4H73v158h110zm18 0v245.4h238v-158H233.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
