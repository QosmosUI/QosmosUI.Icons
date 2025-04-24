// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSnakeTongue : ComponentBase
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
		builder.AddAttribute(14, "d", "M300.9 23.76C198 24.02 80.84 87.55 46.35 177 15.2 257.8 97.86 306.6 127.1 389.3c21.1 59.7-96.61 98.2-96.61 98.2H231.5s34.3-42.2 32.8-94.4c-2.8-99.1-134.7-126.8-127-198.8 6.8-64.2 164.6-128.97 213-86.3 24 21.2 16 85.5 16 85.5-24 3-34.5 8.2-48.7 17.9 21.1 51.8 17.3 105.3 19.8 158.4 19.5 13.9 43.4 16.1 69.5 12.9 19.3-50 44.7-95.4 74.6-137.5-5.1-14-12.3-22.6-29.9-35.3 0 0 18.2-97.6-24.9-140.43-32-31.89-77.3-45.83-125.8-45.71zm53.6 198.84l23.9 58.3s-27-6.9-32.2-17.6c-6.1-12.8 8.3-40.7 8.3-40.7zm93.6 15.2s4.2 31.1-5.8 41.1c-8.5 8.4-36.2 5.9-36.2 5.9zm-99 100.3l16.1 23.3-16.4-3.2zm58 10.1l-6.3 19.1-16.6-2.3zm-47.4 49.7l-6.1 35.1-36.7 34.7 12.4 13 29-27.4 13.6 34.9 16.8-6.6-17.5-45 6.3-35.9c-6-.8-11.9-1.7-17.8-2.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
