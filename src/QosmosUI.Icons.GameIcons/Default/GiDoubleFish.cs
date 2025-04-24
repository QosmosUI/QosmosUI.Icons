// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiDoubleFish : ComponentBase
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
		builder.AddAttribute(14, "d", "M336 32c-28.2 0-81.2 24.81-115.3 52.59C156.5 94.55 80 119.4 80 144c0 29 104.8 57.9 172.1 63.2C276.7 229 322.8 240 336 240c-12.5-12.5-25-25.1-22.2-37.6 34-8.2 69.4-24 100.5-37.9 21 23.9 53.2 43.5 65.7 43.5-16-32-16-48-16-64s16-48.05 32-64c-25.1 0-60 19.65-81.6 43.5-33.5-14.8-71.9-32.15-108.4-39.65 4.9-16.81 17.4-39.27 30-51.85zm-176 80a16 16 0 0 1 16 16 16 16 0 0 1-16 16 16 16 0 0 1-16-16 16 16 0 0 1 16-16zm16 176c12.6 12.6 25.1 35 30 51.8-36.5 7.5-74.9 24.9-108.4 39.7C76 355.6 41.1 336 16 336c16 15.9 32 48 32 64s0 32-16 64c12.5 0 44.7-19.6 65.7-43.5 31.1 13.9 66.5 29.7 100.5 37.9 2.8 12.5-9.7 25.1-22.2 37.6 13.2 0 59.3-11 83.9-32.8C327.2 457.9 432 429 432 400c0-24.6-76.5-49.4-140.7-59.4C257.2 312.8 204.2 288 176 288zm176 80a16 16 0 0 1 16 16 16 16 0 0 1-16 16 16 16 0 0 1-16-16 16 16 0 0 1 16-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
