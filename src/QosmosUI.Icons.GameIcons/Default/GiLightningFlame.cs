// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLightningFlame : ComponentBase
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
		builder.AddAttribute(14, "d", "M18 18v84l53.61 85.3 47.99-47.8L155 281.3l108.8-120.9 8.8 93.6c-3.3 7.7-5.6 15.8-6.6 24 22 54.2 0 150.6-32 32-32 32-35.3 94.7-16 128 9.8 25.7 39.4 40.8 75.7 48.9-25.8-17.5-41.1-43.1-43.7-74.9 9.7 10 39.4 36.4 57.8 26 28.1-15.8 16.6-61.8 11.9-96 41.7 26.7 55.8 58.2 66 90.5 2.5-34.8 20.1-33.3 33.3-42.5-19.5 47.8 21.3 72.7 13.3 100.4 9.4-1.3 18.1-2.7 25.7-4.4 41-13.3 37.2-54.2 32-96-6.8 13.7-27.3 22.9-48 32 32.1-48.1 42.6-85.4 32-112-9.8-16.8-30.1-23.2-48-32 0 0 28.3 36.4 16 48-70.1 62.4-142.6-136.6-32-160-46.7.1-100.2 34.3-123.4 64l3.1-138.59L175.2 205.7 151.6 66.56 87.61 114.6 73.34 18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
