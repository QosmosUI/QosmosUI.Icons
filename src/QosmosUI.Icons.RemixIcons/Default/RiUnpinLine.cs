// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiUnpinLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.9701 17.1716 19.5559 18.5858 16.0214 15.0513 15.9476 15.1251 15.2405 18.6606 13.8263 20.0748 9.58369 15.8322 4.63394 20.7819 3.21973 19.3677 8.16947 14.418 3.92683 10.1753 5.34105 8.7611 8.87658 8.05399 8.95029 7.98028 5.41373 4.44371 6.82794 3.0295 20.9701 17.1716ZM10.3645 9.39449 9.86261 9.8964 7.04072 10.4608 13.5409 16.9609 14.1052 14.139 14.6071 13.6371 10.3645 9.39449ZM18.7761 9.46821 17.4356 10.8087 18.8498 12.2229 20.1903 10.8824 20.8974 11.5895 22.3116 10.1753 13.8263 1.69003 12.4121 3.10425 13.1192 3.81135 11.7787 5.15185 13.1929 6.56607 14.5334 5.22557 18.7761 9.46821Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
