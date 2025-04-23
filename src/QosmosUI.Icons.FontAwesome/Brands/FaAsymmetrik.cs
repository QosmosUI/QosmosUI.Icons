// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaAsymmetrik : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 576 512";

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
		builder.AddAttribute(14, "d", "M517.5 309.2c38.8-40 58.1-80 58.5-116.1.8-65.5-59.4-118.2-169.4-135C277.9 38.4 118.1 73.6 0 140.5 52 114 110.6 92.3 170.7 82.3c74.5-20.5 153-25.4 221.3-14.8C544.5 91.3 588.8 195 490.8 299.2c-10.2 10.8-22 21.1-35 30.6L304.9 103.4 114.7 388.9c-65.6-29.4-76.5-90.2-19.1-151.2 20.8-22.2 48.3-41.9 79.5-58.1 20-12.2 39.7-22.6 62-30.7-65.1 20.3-122.7 52.9-161.6 92.9-27.7 28.6-41.4 57.1-41.7 82.9-.5 35.1 23.4 65.1 68.4 83l-34.5 51.7h101.6l22-34.4c22.2 1 45.3 0 68.6-2.7l-22.8 37.1h135.5L340 406.3c18.6-5.3 36.9-11.5 54.5-18.7l45.9 71.8H542L468.6 349c18.5-12.1 35-25.5 48.9-39.8zm-187.6 80.5l-25-40.6-32.7 53.3c-23.4 3.5-46.7 5.1-69.2 4.4l101.9-159.3 78.7 123c-17.2 7.4-35.3 13.9-53.7 19.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
