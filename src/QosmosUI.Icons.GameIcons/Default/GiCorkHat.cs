// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCorkHat : ComponentBase
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
		builder.AddAttribute(14, "d", "M293 54.44c-59.6 2.43-107.8 6.61-153.5 43.8l-1.2 120.16c5.9 12.7 21.4 16.3 32.8 17.9 19.3 2.7 45.2.9 72.2-3.9 50.4-9 104.7-29 129.4-45L335.5 81.42zM120.6 185.1c-19.2 6.8-36.16 16.9-48.81 31-12.99 14.6-24.45 29.5-30.59 42.1-6.14 12.7-6.79 21.3-2.24 27.7 4.56 6.4 17.62 13.3 44.88 15.8 27.26 2.4 67.76.5 124.56-7.6 50.6-7.3 113-18.8 166.9-35 45.1-13.5 83.8-31.1 104.3-49.6-25.6-5.1-54.9-10.1-86.1-14.8l-4.5 3.4c-27.3 20.9-86.2 42-142.5 52-28.2 5-55.5 7.2-77.9 4-11.2-1.5-21.3-4.4-29.7-9.3-25.3-18.2-18.6-29.4-18.3-59.7zm350.7 53.7c-5.6 3.5-11.6 6.8-18 10v60.3l18-4.8zm-62 28.3c-5.9 2-11.9 4-18 5.9v61.5l18 1.7zm-170 40.5c-6.1 1-12.1 1.9-18 2.8v76.5l18 3zm-201.96.4v73.5l18 3.7v-70c-6.98-1.9-12.98-4.3-18-7.2zm99.96 11.7c-6.3.4-12.3.7-18 .8v80.9l18-1.3zm339 2l-29.3 7.7 13.6 35.7 22.8-6zM385.2 352l.6 38.2 23.4 2.2 6.2-37.5zM32.25 398.8l-3.69 38 23.05 4.8L61.94 405zm182.95 5.3l-2.2 38.2 23.1 3.8 9.1-36.9zm-74 13.8l-30.2 2.2 6.8 37.5 23.5-1.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
