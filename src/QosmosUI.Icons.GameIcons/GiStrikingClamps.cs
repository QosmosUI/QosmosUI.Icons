// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiStrikingClamps : ComponentBase
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
		builder.AddAttribute(14, "d", "M40.98 33.47c42.365 69.924 62.112 128.807 67.23 167.143-2.18-.5-4.446-.773-6.776-.773-15.047 0-27.516 11.026-29.778 25.437-14.03-22.296-30.308-61.62-45.88-121.623C86.005 464.07 279.215 338.11 40.978 33.47zm166.485 48.26c81.832 9.75 131.982 36.245 149.36 55.81-4.444 4.413-7.198 10.53-7.198 17.288 0 1.892.223 3.73.63 5.498-15.305.858-43.695-6.828-85.5-28.885 233.85 149.603 273.12-20.542-57.292-49.71zm-65.473 3.71c133.425 99.39 206.29 185.384 234.88 241.12-1.758-.23-3.546-.36-5.366-.36-22.58 0-40.885 18.302-40.885 40.882 0 3.86.547 7.59 1.546 11.13-41.953-26.657-103.148-88.887-173.48-197.18 321.64 535.806 553.76 265.665-16.694-95.593z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
