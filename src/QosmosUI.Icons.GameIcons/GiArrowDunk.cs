// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiArrowDunk : ComponentBase
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
		builder.AddAttribute(14, "d", "M237.13 18.283c-51.748 0-99.183 27.58-136.067 73.395 11.946-6.97 24.526-11.903 37.51-14.76 8.952-1.97 18.062-2.96 27.25-3 27.562-.123 55.824 8.283 82.636 24.318 70.828 42.362 132.585 137.45 153.704 275.178l-49.44 12.637 74.33 109.74 74.327-147.733-51.84 13.25c.564-8.534.9-17.16.9-25.905 0-175.088-95.847-317.12-213.307-317.12h-.002zm-71.165 74.305c-7.924.04-15.734.9-23.375 2.582-30.47 6.705-58.785 26.48-81.356 61.89C37.996 207.88 24.4 269.28 24.4 335.4c0 15.983 1.35 31.378 2.883 46.73 14.387-135.103 92.702-238.62 187.363-238.62 34.713 0 67.177 13.976 95.083 38.334-21.608-29.968-45.915-52.65-70.863-67.57-24.337-14.556-49.13-21.81-72.902-21.688z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
