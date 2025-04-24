// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiWinterHat : ComponentBase
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
		builder.AddAttribute(14, "d", "M432 20.25c-30.5 0-55 24.52-55 55 0 30.45 24.5 54.95 55 54.95s55-24.5 55-54.95c0-30.48-24.5-55-55-55zM362.8 98.5c-51.5 28.9-108 60.6-158.1 94.9-63.1 43.2-114.49 90.7-132.73 139.4C189.3 360.6 308.8 394.7 453.8 394c9.2-83.5 18.1-171.1-.5-249a71.8 71.8 0 0 1-21.3 3.2c-32.1 0-59.4-20.8-69.2-49.7zM52 346.7c-19.24 28.5-25.15 57.6-25.05 85.3 9.72 3.3 20.13 6.5 31.06 9.6 1.19-13.4 5.49-31 13.2-55.1l17.14 5.4c-8.24 25.7-12 43.9-12.6 54.5 12.47 3.2 25.55 6.3 38.95 9.2 3.2-18.5 9-35.9 14.8-53l17 5.8c-5.9 17.1-11.4 34-14.1 50.9 14.9 2.9 30.2 5.7 45.7 8.3l9.5-51.7 17.8 3.2-9.4 51.4c16.1 2.5 32.4 4.7 48.7 6.8l7.3-49.8 17.8 2.6-7.3 49.3c17.8 2 35.5 3.8 52.9 5.2l5.9-47.4 17.8 2.2-5.8 46.6c19.6 1.4 38.7 2.4 56.8 2.9 3.7-15.4 4.4-27.9 5.4-44.6l18 1.2c-1 15.3-1.7 28.5-5.1 43.8 15.5.3 30.2.1 43.7-.4 15-24.1 23.4-53.4 20.7-77.3-163.2 4-294.2-35.6-420.8-64.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
