// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaResolving : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 496 512";

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
		builder.AddAttribute(14, "d", "M281.2 278.2c46-13.3 49.6-23.5 44-43.4L314 195.5c-6.1-20.9-18.4-28.1-71.1-12.8L54.7 236.8l28.6 98.6 197.9-57.2zM248.5 8C131.4 8 33.2 88.7 7.2 197.5l221.9-63.9c34.8-10.2 54.2-11.7 79.3-8.2 36.3 6.1 52.7 25 61.4 55.2l10.7 37.8c8.2 28.1 1 50.6-23.5 73.6-19.4 17.4-31.2 24.5-61.4 33.2L203 351.8l220.4 27.1 9.7 34.2-48.1 13.3-286.8-37.3 23 80.2c36.8 22 80.3 34.7 126.3 34.7 137 0 248.5-111.4 248.5-248.3C497 119.4 385.5 8 248.5 8zM38.3 388.6L0 256.8c0 48.5 14.3 93.4 38.3 131.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
