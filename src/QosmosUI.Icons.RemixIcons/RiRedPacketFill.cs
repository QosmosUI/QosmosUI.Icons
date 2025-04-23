// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiRedPacketFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M21.0049 5.94028C19.2657 7.91075 16.8895 9.30566 14.1986 9.80276C13.7739 9.02805 12.9507 8.50281 12.0049 8.50281C11.0591 8.50281 10.2359 9.02805 9.8112 9.80276C7.12025 9.30566 4.74405 7.91075 3.00488 5.94028V3.00281C3.00488 2.45052 3.4526 2.00281 4.00488 2.00281H20.0049C20.5572 2.00281 21.0049 2.45052 21.0049 3.00281V5.94028ZM21.0049 8.72704V21.0028C21.0049 21.5551 20.5572 22.0028 20.0049 22.0028H4.00488C3.4526 22.0028 3.00488 21.5551 3.00488 21.0028V8.72704C4.86501 10.2897 7.13757 11.3774 9.63575 11.8032C9.96947 12.7914 10.9041 13.5028 12.0049 13.5028C13.1057 13.5028 14.0403 12.7914 14.374 11.8032C16.8722 11.3774 19.1448 10.2897 21.0049 8.72704Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
