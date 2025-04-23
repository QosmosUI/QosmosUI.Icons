// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxThickArrowLeft : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M1 7.5C1 7.66148 1.07798 7.81301 1.20938 7.90687L8.20938 12.9069C8.36179 13.0157 8.56226 13.0303 8.72879 12.9446C8.89533 12.8589 9 12.6873 9 12.5L9 10L11.5 10C11.7761 10 12 9.77614 12 9.5L12 5.5C12 5.22386 11.7761 5 11.5 5L9 5L9 2.5C9 2.31271 8.89533 2.14112 8.72879 2.05542C8.56226 1.96972 8.36179 1.98427 8.20938 2.09313L1.20938 7.09314C1.07798 7.18699 1 7.33853 1 7.5ZM8 3.4716L8 5.5C8 5.77614 8.22386 6 8.5 6L11 6L11 9L8.5 9C8.22386 9 8 9.22386 8 9.5L8 11.5284L2.36023 7.5L8 3.4716Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
