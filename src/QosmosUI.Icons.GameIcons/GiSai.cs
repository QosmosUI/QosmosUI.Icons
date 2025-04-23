// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSai : ComponentBase
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
		builder.AddAttribute(14, "d", "M476.953 34.873C470.795 28.715 237.497 251.72 162.997 326.2l22.628 22.628C261.473 273.082 483.11 41.03 476.953 34.873zM233.747 166.356c-.24-.24-.6-.335-1.07-.293-9.55.855-113.11 97.3-143.888 124.035-3.515 3.515-3.515 9.213 0 12.728l43.84 43.842-13.442 13.504 32.53 32.53 13.443-13.507L209 423.037c3.515 3.514 9.213 3.514 12.728 0 28.048-32.29 129.91-138.957 123.743-144.957L215.363 403.944l-107.48-107.48zm-120.442 213.39l-2.346 21.12 21.12-2.346zm14.072 37.406l-18.455 2.05-2.062 18.564zM94.63 384.844L74.666 404.9l17.955-1.996zm-4.045 36.396l-32.575 3.62 28.955 28.958zM44.82 434.232l-9.9 9.9 33.122 33.12 9.902-9.896z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
