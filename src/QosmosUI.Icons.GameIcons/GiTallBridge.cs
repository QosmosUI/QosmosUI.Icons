// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTallBridge : ComponentBase
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
		builder.AddAttribute(14, "d", "M18 151v18h37v30h18v-30h46v30h18v-30h46v30h18v-30h46v30h18v-30h46v30h18v-30h46v30h18v-30h46v30h18v-30h37v-18zm0 66v30h23v179.1c7.95-1.8 15.9-3.1 23-3.1 13.18 0 24.7 4.6 35.2 8.6 1.3.5 2.5 1 3.8 1.4V284.3l37.2-37.3h231.5l37.3 36.7V433c1.3-.4 2.5-.9 3.8-1.4 10.5-4 22-8.6 35.2-8.6 7.1 0 15.1 1.3 23 3.1V247h23v-30zm46 226c-16.54.8-31.84 5.3-46 9.4v18.8c2.59-.8 5.39-1.7 8.35-2.6C39.27 464.7 55.18 461 64 461s18.3 3.4 28.8 7.4 22 8.6 35.2 8.6c13.2 0 24.7-4.6 35.2-8.6 10.5-4 20-7.4 28.8-7.4s18.3 3.4 28.8 7.4 22 8.6 35.2 8.6c13.2 0 24.7-4.6 35.2-8.6 10.5-4 20-7.4 28.8-7.4s18.3 3.4 28.8 7.4 22 8.6 35.2 8.6c13.2 0 24.7-4.6 35.2-8.6 10.5-4 20-7.4 28.8-7.4s24.7 3.7 37.6 7.6c3 .9 5.8 1.8 8.4 2.6v-18.8c-14.8-4-32-9.2-46-9.4-13.2 0-24.7 4.6-35.2 8.6-10.5 4-20 7.4-28.8 7.4s-18.3-3.4-28.8-7.4-22-8.6-35.2-8.6c-13.2 0-24.7 4.6-35.2 8.6-10.5 4-20 7.4-28.8 7.4s-18.3-3.4-28.8-7.4-22-8.6-35.2-8.6c-13.2 0-24.7 4.6-35.2 8.6-10.5 4-20 7.4-28.8 7.4s-18.3-3.4-28.8-7.4S77.18 443 64 443z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
