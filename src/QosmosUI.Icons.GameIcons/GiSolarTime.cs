// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSolarTime : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 26.37l-35.4 97.23c11.3-3 23.2-4.6 35.4-4.6s24.1 1.6 35.4 4.6zm162.5 67.22l-94 43.81c20.8 12 38.1 29.3 50.1 50.1zm-324.88 0l43.78 93.81c12.1-20.7 29.3-38 50.1-50zM247 137.3c-58.6 4.4-105.3 51.1-109.7 109.7H176v18h-38.7c4.4 58.6 51.1 105.3 109.7 109.7V336h18v38.7c58.6-4.4 105.3-51.1 109.7-109.7H336v-18h38.7c-4.4-58.6-51.1-105.3-109.7-109.7V176h-18zm54.5 25.9l15.4 9.2-49.9 82.7 37.2 44.1-13.8 11.6-45.4-53.9zm-177.9 57.4L26.38 256l97.22 35.3c-3-11.2-4.6-23.1-4.6-35.3 0-12.2 1.6-24.1 4.6-35.4zm264.8.1c3 11.2 4.6 23.1 4.6 35.3 0 12.2-1.6 24.1-4.6 35.4l97.2-35.4zm-13.8 103.8c-12 20.8-29.3 38.1-50.1 50.1l94 43.9zm-237.1.2l-43.8 93.8 93.8-43.9c-20.7-12-38-29.2-50-49.9zm83.1 63.7l35.4 97.2 35.3-97.2c-11.2 3-23.1 4.6-35.3 4.6-12.2 0-24.1-1.6-35.4-4.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
