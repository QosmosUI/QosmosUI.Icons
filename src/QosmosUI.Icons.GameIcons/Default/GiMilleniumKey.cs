// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMilleniumKey : ComponentBase
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
		builder.AddAttribute(14, "d", "M458.888 51.697c-16.687-16.687-36.67-26.1-56.998-26.912-20.327-.814-40.034 6.726-57.094 19.626-24.845 18.785-45.254 48.744-59.135 86.723 9.75 11.124 18.958 21.279 28.077 30.927 12.097-42.184 32.322-73.476 52.768-88.935 11.93-9.02 23.337-12.795 33.945-12.37 10.609.424 21.385 4.8 32.982 16.397 11.596 11.597 15.973 22.373 16.397 32.982.424 10.608-3.35 22.014-12.37 33.945-15.46 20.446-46.751 40.67-88.936 52.768 9.649 9.12 19.804 18.327 30.928 28.077 37.979-13.882 67.938-34.29 86.723-59.135 12.9-17.06 20.44-36.767 19.626-57.095-.813-20.327-10.225-40.31-26.913-56.998zM207.932 66.48l-42.56 42.56c114.63 93.989 142.185 121.544 236.174 236.173l42.56-42.559C329.475 208.664 301.92 181.109 207.931 66.48zM278.6 231.985a868.658 868.658 0 0 0-16.487-16.04L150.106 327.952c.976 7.424 4.937 15.284 11.09 21.437 6.154 6.154 14.014 10.115 21.437 11.09l112.008-112.007a868.658 868.658 0 0 0-16.04-16.487zm-137.23 121.673L26.14 468.89l15.556 15.557 115.233-115.232a63.201 63.201 0 0 1-8.46-7.098 63.201 63.201 0 0 1-7.097-8.459zm-31.793 88.362L77.05 474.547l12.728 12.728 32.527-32.527z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
