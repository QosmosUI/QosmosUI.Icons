// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSnorkel : ComponentBase
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
		builder.AddAttribute(14, "d", "M353.5 16c-15 0-15 15-15 30v60a15 15 0 0 0-15 15v30a15 15 0 0 0 15 15v210c0 33.137-26.863 60-60 60s-60-26.863-60-60c0 0 15-15 15-30s45-30 45-45-15-15-15-15-8.565 8.59-20.72 18.25A15 15 0 0 0 218.5 316a15 15 0 0 0 .72 4.53C208.733 326.586 197.885 331 188.5 331c-9.375 0-20.214-4.395-30.688-10.438A15 15 0 0 0 158.5 316a15 15 0 0 0-24.28-11.78C122.072 294.562 113.5 286 113.5 286s-15 0-15 15 45 30 45 45 15 30 15 30c0 66.274 53.726 120 120 120s120-53.726 120-120V166a15 15 0 0 0 15-15v-30a15 15 0 0 0-15-15V46c0-15 0-30-15-30h-30z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
