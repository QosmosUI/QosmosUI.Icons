// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiRssOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M8 4.999c-1.657 0-3.011 1.344-3.011 3l.005 9c0 2.209 1.793 4 4.002 4l9.003.001c1.655 0 3-1.346 3-3.001.001-7.179-5.819-13-12.999-13zm1.001 14c-1.105.002-2.001-.894-2.001-1.999-.002-1.105.894-2.001 2.001-2.001 1.105-.002 2.001.894 1.999 2.001.002 1.105-.894 2.001-1.999 1.999zm4.499 0c-.829 0-1.5-.671-1.5-1.5 0-1.931-1.57-3.5-3.5-3.5-.829 0-1.5-.671-1.5-1.5s.671-1.5 1.5-1.5c3.584 0 6.5 2.916 6.5 6.5 0 .829-.671 1.5-1.5 1.5zm4 0c-.829 0-1.5-.671-1.5-1.5 0-4.136-3.364-7.5-7.5-7.5-.829 0-1.5-.671-1.5-1.5s.671-1.5 1.5-1.5c5.79 0 10.5 4.71 10.5 10.5 0 .829-.671 1.5-1.5 1.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
