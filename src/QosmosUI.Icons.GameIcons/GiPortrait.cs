// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPortrait : ComponentBase
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
		builder.AddAttribute(14, "d", "M105 25v462h302V25H105zm30 30h242v402H135V55zm121 34c-23.3 0-44.6 12.5-60.7 33.9-16 21.4-26.3 51.6-26.3 85.1 0 33.5 10.3 63.7 26.3 85.1 16.1 21.4 37.4 33.9 60.7 33.9 23.3 0 44.6-12.5 60.7-33.9 16-21.4 26.3-51.6 26.3-85.1 0-33.5-10.3-63.7-26.3-85.1C300.6 101.5 279.3 89 256 89zm-64 110h128v18H192v-18zm48 48h32v18h-32v-18zm-39.7 77.2c-5.1 1.9-10 3.9-14.6 6-10.5 4.8-19.5 10-25.4 14.7-5.9 4.6-7.3 9.1-7.3 7.1v87h206v-87c0 2-1.4-2.5-7.3-7.1-5.9-4.7-14.9-9.9-25.4-14.7-4.6-2.1-9.5-4.1-14.6-6-16 13.1-35.1 20.8-55.7 20.8s-39.7-7.7-55.7-20.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
