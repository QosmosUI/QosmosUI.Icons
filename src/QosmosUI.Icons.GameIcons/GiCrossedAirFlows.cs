// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCrossedAirFlows : ComponentBase
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
		builder.AddAttribute(14, "d", "M21 18.035v5.088c109.998 50.032 220.054 122.967 293.453 201.82-2.054 3.538-4.134 7.048-6.23 10.54C218.595 169.884 117.723 122.586 21 92.822v77.1c75.186 16.99 155.106 46.088 231.27 89.356-54.09-19.95-113.754-32.143-175.204-33.876 59.19 20.343 123.45 46.638 184.955 78.492-65.03 85.433-145.31 149.098-239.266 174.39C141.178 511.62 307.632 481.4 414 401.755c30.91 25.406 58.157 52.78 79.965 82.025v-5.17c-10.706-36.043-26.167-71.84-45.272-106.794 12.84-12.864 24.225-26.682 33.852-41.416-56.283 49.778-128.067 78.627-216.725 105.834 78.377-44.805 146.055-100.623 199.133-159.6 10.04-11.92 19.72-24.115 29.012-36.52v-38.41c-75.202 99.392-188.794 188.773-302.738 236.14 122.326-68.48 252.93-199.788 297.607-323.684-38.43 54.704-84.59 103.334-133.86 144.86 57.522-73.943 108.355-152.33 138.99-216.06V18.036h-90.03c-20.39 65.42-46.51 128.732-78.065 186.61-72.37-77.783-156.326-143.35-233.247-186.61H21zM186.703 439.5h.492c-.32.13-.64.265-.96.395.156-.13.313-.265.468-.395z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
