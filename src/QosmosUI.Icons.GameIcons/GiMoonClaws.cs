// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiMoonClaws : ComponentBase
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
		builder.AddAttribute(14, "d", "M257.893 25.73c-129.963 0-235.13 105.166-235.13 235.13 0 52.99 17.487 101.856 47.007 141.154 18.687-22.89 36.79-51.545 40.99-78.98l-60.55-123.81 102.927-67.675c-32.11 41.175-42.93 80.322-36.914 113.11 6.575 35.84 33.437 62.59 69.39 74.065l5.682-17.807c-30.667-9.787-51.42-30.922-56.688-59.63-.662-3.61-1.076-7.368-1.22-11.26 20.214 13.75 81.03-26.946 139.773-113.604l101.445 20.11c-87.707 2.83-148.702 57.44-137.615 108.94l109.625-63.956 92.942 26.306c-86.43.5-159.89 25.05-162.032 83.56l106.065-37.67 85.447 68.612c-128.788-47.823-210.17 2.972-273.937 56.713-14.598 27.523-21.196 63.61-24.002 100.435 26.848 10.654 56.13 16.515 86.795 16.515 129.962 0 235.13-105.168 235.13-235.13 0-129.964-105.168-235.13-235.13-235.13z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
