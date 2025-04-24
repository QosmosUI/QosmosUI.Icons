// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFirewall : ComponentBase
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
		builder.AddAttribute(14, "d", "M293.4 23.17s-33 12.6-41.1 26.82c-8.7 15.15-2.3 52.31-2.3 52.31 9-28.63 23.2-55.07 43.4-79.13zm-172 47.78C130 140.8 87.44 197.2 95.7 251.5c-45.63-24.1-42.25-107.8-56.72-150.6-7.61 14.3-14.67 28.7-20.98 43.3V494h476V185.6c-14.6-27.9-21.9-60-16.4-99.66C419.3 118 431.2 210.8 439.6 255c-33.9-16.7-88.6-43-62.6-114.7-34.5 18.7-47.5 90.1-55.7 123.4 3.8-43.6-50-80.4-32.7-163.5-36.7 37.1-58.1 163.2-57.6 216.9-8.1-33-5.8-169.7-41.7-186.6 2.7 32-20.6 84.7-33.8 89.3 10.5-55.4-17.1-115.4-34.1-148.85z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
