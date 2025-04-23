// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHexes : ComponentBase
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
		builder.AddAttribute(14, "d", "M18 18v61.193l25.22-7.142L56.886 18zm56.643 0L59.91 76.28l53.06 51.58 71.16-20.15L202.27 36l-18.5-18zm133.845 0l5.782 5.62L234.123 18zm104.27 0l42.453 41.27 71.158-20.15L431.715 18zm136.701 0l-6.43 25.33L494 92.842V18zm-159.328 2l-71.16 20.18-18.16 71.74 53 51.57 71.25-20.16 18.138-71.71zm140.988 35.69l-71.228 20.15-18.131 71.71 53.05 51.58L465.98 179l18.14-71.74zM47.891 88.62L18 97.083v133.191l64.81-18.355 18.13-71.71zm140.99 35.65l-71.192 20.16-18.18 71.71 53.061 51.58 71.17-20.14 18.14-71.74zM494 138.408L482.68 183.2 494 194.203zM329.74 159.9L258.57 180l-18.14 71.74 53 51.57 71.19-20.16 18.19-71.67zm140.93 35.65l-71.19 20.15-18.13 71.71L434.41 339 494 322.125V218.227zM87.49 228.49L18 248.168v91.406l33.23 32.276 71.18-20.07 18.13-71.71zm140.95 35.65l-71.19 20.16-18.14 71.7 53.06 51.58 71.16-20.15 18.14-71.74zm140.9 35.62l-71.16 20.15-18.14 71.74 53 51.57 71.19-20.16 18.14-71.71zM494 340.018l-54.92 15.543-18.13 71.709 53.06 51.58 19.99-5.657zm-476 23.63v93.233l3.09-.881 18.14-71.71zm109.07 4.702L55.93 388.5l-18.12 71.74L72.515 494h81.154l8.332-2.36 18.13-71.71zM268.03 404l-71.22 20.15L179.185 494H311.36l9.72-38.44zm140.91 35.62l-71.13 20.15-8.677 34.23h132.162l.705-2.79zM25.81 472.59L18 474.8V494h29.824zM494 487.73l-15.92 4.5-.447 1.77H494z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
