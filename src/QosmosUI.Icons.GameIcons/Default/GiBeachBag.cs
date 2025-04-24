// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBeachBag : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 23c-35 0-63.7 17.8-85.8 43.07-22.1 25.28-38.4 58.13-50.6 90.73-10.1 27-17.4 53.9-22.52 76.2H27.49c3.45 14.4 15.83 65.6 33.14 124.5 9.96 33.8 20.92 67.6 31.19 92.6 5.14 12.4 10.18 22.7 14.38 29.3 2.2 3.3 4.2 5.7 5.5 6.8.6.6.9.7 1 .8h286.6c.1-.1.4-.2 1-.8 1.3-1.1 3.3-3.5 5.5-6.8 4.2-6.6 9.2-16.9 14.4-29.3 10.2-25 21.2-58.8 31.2-92.6 17.3-58.9 29.7-110.1 33.1-124.5h-69.6c-5.1-22.3-12.4-49.2-22.5-76.2-12.2-32.6-28.5-65.45-50.6-90.73C319.7 40.8 291 23 256 23zm0 18c29 0 52.3 14.2 72.2 36.93 19.9 22.67 35.6 53.87 47.4 85.27 9.2 24.5 16 49 20.9 69.8h-281c4.9-20.8 11.7-45.3 20.9-69.8 11.8-31.4 27.5-62.6 47.4-85.27C203.7 55.2 227 41 256 41zm163.8 215.3A24 24 0 0 1 440 280a24 24 0 0 1-24 24 24 24 0 0 1-24-24 24 24 0 0 1 10.3-19.7c3.4 17.6 4.8 28.8 4.8 28.8l17.8-2.2s-1.5-11.9-5.1-30.6zm-327.64 0c-3.6 18.7-5.09 30.6-5.09 30.6l17.83 2.2s1.4-11.2 4.8-28.8A24 24 0 0 1 120 280a24 24 0 0 1-24 24 24 24 0 0 1-24-24 24 24 0 0 1 20.16-23.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
