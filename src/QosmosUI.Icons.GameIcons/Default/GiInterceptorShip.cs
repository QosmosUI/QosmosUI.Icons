// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiInterceptorShip : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 23.2c-75.5 0-132.9 56.75-172.05 131.2-35.92 68.2-55.33 150.3-58.34 211.4 36.08-21.9 74.59-45.9 112.19-65.6 26.8-14 52.8-25.8 77.2-32.7v-33l41-41 41 41v33c24.4 6.9 50.4 18.7 77.2 32.7 37.6 19.7 76.1 43.7 112.2 65.6-3-61.1-22.4-143.2-58.4-211.4-39.1-74.45-96.5-131.2-172-131.2zm-201.01 23v42.42l18-9V46.2zm384.01 0v33.42l18 8.99V46.2zm-235.2 7h104.4l82.7 99.2-11.4 13.6c-72.5-41.8-176.6-39.8-247.1 0l-11.3-13.6zM86.99 92.76l-46 23.04v91.4c7.7-20.9 16.71-41.6 27.04-61.2 5.87-11.1 12.2-22 18.96-32.4zm338.01 0v20.84c6.8 10.4 13.1 21.3 19 32.4 10.3 19.6 19.3 40.2 27 61.1v-91.3zM256 218.9l-23 23v67.3h46v-67.3zm-41 67.6c-7.4 2.3-15.2 5.1-23.1 8.3l8.2 49.5 30.9 16.5v124.4h16v-103h18v103h16V360.8l30.9-16.5 8.2-49.5c-7.9-3.2-15.7-6-23.1-8.3v40.7h-82zm-84.9 38.4c-8.8 4.8-17.7 9.8-26.5 15l-9.96 148.9 25.56-76.6zm251.8 0l10.9 87.3 25.6 76.6-10-148.9c-8.8-5.1-17.7-10.2-26.5-15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
