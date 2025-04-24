// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiNestedHexagons : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 21.52l-4.5 2.597L52.934 138.76v234.48L256 490.48l203.066-117.24V138.76L256 21.52zm0 20.783l185.066 106.85v213.695L256 469.698 70.934 362.847V149.152L256 42.302zm0 30.93l-4.5 2.597-153.78 88.785v182.77L256 438.768l158.28-91.383v-182.77L256 73.232zm0 20.783l140.28 80.992v161.984L256 417.984l-140.28-80.992V175.008L256 94.016zm0 30.93l-4.5 2.597-108.998 62.93v131.054L256 387.055l113.498-65.528V190.473L256 124.945zm0 20.783l95.498 55.135v110.27L256 366.27l-95.498-55.135v-110.27L256 145.73zm0 30.928l-4.5 2.598-64.213 37.072v79.344L256 335.342l68.713-39.67v-79.344L256 176.658zm0 20.783l50.713 29.28v58.56L256 314.56l-50.713-29.28v-58.56L256 197.44zm0 30.93l-4.5 2.6-19.428 11.216v27.628L256 283.63l23.928-13.816v-27.628L256 228.37z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
