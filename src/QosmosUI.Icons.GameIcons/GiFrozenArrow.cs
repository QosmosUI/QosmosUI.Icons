// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiFrozenArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M16.37 29.06V52L193.3 154.3c19.7-14.4 39.3-28.8 58.9-43.1 66.2 81.7 123.6 152.7 182.7 225.5-97.5-15.7-199.6-31.9-286.9-45.5 2.8-24.7 5.6-49.4 8.5-74L16.38 136.1v63.5l24.5 141.1L66.94 190l22.18 106 17.38-83.4 25.5 14.7-9.9 84.7c8 40.9 15.5 83 23.1 124.3l10.7-58.5 19.9 117 28.5-167.4 21.5 117.4 20.4-111.1 17.7 36 16-32.7 18.8 3 22.1 132.9 20.8-126.1 12.8 2 24.5 63 14.8-38.1 18.1 98.4 17.6-96.3 16.8 23.5 22.9-32.3 25.6 4C413.2 270.3 327.5 165.2 257 78.41l-68.4 50.19zm0 44.53v40.91c53.31 31 106.83 61.6 160.03 92.6-2.6 22.8-5.2 45.7-7.8 68.5l221.1 35-44.9-55.4-9.6 31.3-20.4-66.1-13.3 46.5-19.3-72.2-16.2 79-28-110.2-15.5 51.9-13.9-46.5-12.4 67.6-12.1-66z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
