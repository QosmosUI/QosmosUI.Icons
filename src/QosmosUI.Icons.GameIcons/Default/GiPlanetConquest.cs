// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiPlanetConquest : ComponentBase
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
		builder.AddAttribute(14, "d", "M215 32v140c5.9-1.4 11.9-2.6 18-3.4v-42.9c45-8 90 32.3 135 2.3V48c-45 30-90-10.31-135-2.29V32h-18zm41 153c-83.5 0-151 67.5-151 151s67.5 151 151 151 151-67.5 151-151-67.5-151-151-151zm-20.6 25.8l77.4 119.3-83.7 27.6-22.8-54.1-24.4 21.2-57.9-12.5 48.3-50 41.4 7.9 21.7-59.4zm103.2 6.1l-10.2 34.9 38.3-.7-36.4 31.1-31.1-24.8 12.7-23.6 26.7-16.9zm33.6 148.4l-26.5 42.9-21.2-36.1 47.7-6.8zM316 398l15.9 46.7c-35.1 28.4-87.1 35.9-115.6 16.9l38.2-60.9 29.2 30.7L316 398z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
