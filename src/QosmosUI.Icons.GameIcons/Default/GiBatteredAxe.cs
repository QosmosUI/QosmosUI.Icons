// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBatteredAxe : ComponentBase
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
		builder.AddAttribute(14, "d", "M27.47 15.344c62.946 25.422 108.824 61.313 115.843 132.03v.188c52.31 30.132 92.605 72.538 104.28 119.938 1.792 7.272 2.84 14.637 3.126 22.03 31.737-3.283 64-20.935 87.843-46.624 26.42-28.467 42.056-65.91 36.843-103.03-15.205 1.917-30.855.922-46.5-2.314-50.282-10.398-101.7-42.974-148.562-77.875-4.79-4.21-9.93-8.084-15.406-11.656-34.787-22.69-82.864-32.686-137.47-32.686zM234.687 41.25l-15.72 23c19.23 13.107 38.792 25.095 58.126 34.72l13.437-19.25c-12.406-18.774-34.986-32.363-55.842-38.47zm239.375 21.375c-16.886 31.464-37.035 52.625-59.72 64.875-6.702 3.62-13.573 6.434-20.593 8.53 6.67 44.027-11.746 87.505-41.5 119.564-27.275 29.387-64.424 49.947-102.53 52.844-4.482 31.48-23.408 62.858-59.75 90.312 40.743 9.164 78.742 9.05 113.436 1.906l7.72-49.03 2.937-18.595 13.03 13.595L359 379.875c27.795-16.753 64.71-44.308 83.22-67.906L413.31 262l-11.468-19.78 22.03 6.093 47.938 13.25c13.232-23.865 21.327-60.527 21.47-98.875.13-34.855-6.22-70.88-19.22-100.063zM146.092 170.97L20.564 354.75l.812 110.625 175.53-251.5c-13.78-15.612-31.054-30.19-50.81-42.906z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
