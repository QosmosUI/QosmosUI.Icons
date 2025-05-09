// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRibbonShield : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 32.19c34.6 42.07 92.8 57.46 150.1 71.71L395.7 198c-66.1-6.6-103-9.9-139.7-9.9-36.6 0-73.6 3.3-139.7 9.9l-10.5-94.1C163 89.65 221.4 74.26 256 32.19zM421.3 195.3c19.3 5.9 41.8 9.2 67.3 10.4-11.8 11.1-32.7 23.3-34.3 39.2-1.6 18.9 4.7 36.3 12.1 52.5-17.3 1-33.2-1.8-48.7-6.3 7.2-32.4 7.3-57.7 7.3-82v-6.2c-3.7-7.6-2.9-6.3-3.7-7.6zm-330.73 0l-3.5 7.7-.1 6c-.2 24.3 0 49.7 7.3 82.1-15.6 4.5-31.5 7.3-48.8 6.3 7.4-16.3 13.8-33.6 12.2-52.6-4.4-17.5-21.7-28.8-34.4-39.1 25.6-1.2 48.1-4.5 67.3-10.4zM256 206.1c38 0 77 3.7 151 11.1-.1 27.5-1.3 55.1-13.4 94.1-133.3-14.7-141.9-14.7-275.2 0-12.2-39.1-13.5-66.7-13.4-94 74-7.4 113-11.2 151-11.2zm0 111.9c32.4 0 65.1 3.4 125.3 10l-6.2 55.6c-7.3 36.1-36.6 60.3-65.3 75.6-25.9 13.7-49.1 19.5-53.8 20.6-4.7-1.1-27.9-6.9-53.8-20.6-28.7-15.4-58-39.5-65.3-75.6l-6.2-55.6c60.2-6.6 92.9-10 125.3-10z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
