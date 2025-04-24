// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiThorHammer : ComponentBase
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
		builder.AddAttribute(14, "d", "M266.033 32.42l-85.238 85.238v19.799L285.832 32.42h-19.799zm41.528 3.728L184.523 159.186l168.291 168.29L475.852 204.44 307.56 36.15zm172.02 190.02L374.542 331.205h19.799l85.238-85.238v-19.799zm-239.903 13.627l-9.9 9.9 32.527 32.528 9.9-9.9-32.527-32.528zm-22.627 22.627l-23.528 23.527h47.055l-23.527-23.527zm-41.528 41.527l-27.255 27.256h65.054l27.256-27.256h-65.055zm-45.255 45.256l-27.254 27.254h65.054l27.254-27.254h-65.054zm-27.254 45.254l23.527 23.527 23.527-23.527h-47.054zm-21.729 3.728l-9.898 9.899 32.527 32.527 9.898-9.898-32.527-32.527zm-38.767 18.899l-7.504 22.512 37.388 37.388 22.512-7.504v-12.414L54.93 417.086H42.518z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
