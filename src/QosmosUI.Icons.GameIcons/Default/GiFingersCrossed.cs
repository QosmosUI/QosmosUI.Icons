// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFingersCrossed : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.18 18.52V225.3c41.18 86.6 59.73 144.5 161.52 237l.3.2.1.2c3.3 3.2 6.3 4.1 10.9 3.7 4.5-.4 10.2-2.7 15.7-6.4 10-6.7 20.1-19.5 21.5-24.6L169.6 374l12.1-12.1 67.5 67.4c1.4 1.4 2.8 2 7 1.2 4-.6 9.9-3.3 15.6-7.1 10.9-7.5 21.2-20.1 24.5-28.5l-57.6-62 11.7-12.1s144.8 107.3 218.3 131.6c9.8 3.2 19.6-8.8 22.2-17.9 2.9-10.4-1.9-25-10.9-30.6-43.5-27.2-192.5-126.1-192.5-126.1l10.1-9.2 94.1 64.2-56-97.1L279 165l8.4-8 50.4 61.6s1.2-26.4-1.8-39.2c-2.3-9.9-5.9-20-12.4-27.8-16.8-20.4-42.2-31.9-64.6-45.8-51.4-32.06-113.5-51.14-159.14-87.28zM364.7 410.8s0 .4.2.9l.4.3c-.3-.7-.5-1.2-.6-1.2zm.6 1.2c2.2 4.8 10.5 25.1 15 33.8 4.5 9.1 9 17.7 14.8 26.4 8.2 12.4 14 20.2 24.9 21.1 8.9.8 19.4-5.7 23.1-13.9 3.9-8.1-4.5-26.6-4.5-26.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
