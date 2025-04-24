// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiByjus : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M2.327.016A2.325 2.325 0 0 0 0 2.34v19.32a2.325 2.325 0 0 0 2.327 2.323h19.346A2.325 2.325 0 0 0 24 21.66V2.34A2.325 2.325 0 0 0 21.673.016zm10.054 3.496a3.443 3.443 0 0 1 .07 0 4.317 4.317 0 0 1 3.267 1.462 4.447 4.447 0 0 1 .961 2.365 4.157 4.157 0 0 1-.456 2.27 5.024 5.024 0 0 1 2.424 2.008 5.237 5.237 0 0 1 .73 3.374 4.68 4.68 0 0 1-1.15 2.466 4.84 4.84 0 0 1-2.26 1.535l-4.987 1.439a1.494 1.494 0 0 1-.41.058 1.497 1.497 0 0 1-1.432-1.075L5.524 6.909a1.487 1.487 0 0 1 1.018-1.841l4.956-1.429a3.443 3.443 0 0 1 .883-.127zm.248.861a3.091 3.091 0 0 0-.855.122L6.94 5.888a.744.744 0 0 0-.51.922l3.53 12.206a.745.745 0 0 0 .921.509l4.664-1.345a4.085 4.085 0 0 0-.896-8.003 3.297 3.297 0 0 0 1.138-2.272 3.479 3.479 0 0 0-.928-2.549 2.989 2.989 0 0 0-2.23-.983Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
