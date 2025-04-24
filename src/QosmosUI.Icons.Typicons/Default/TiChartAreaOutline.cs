// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiChartAreaOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M20 17h-16c-.552 0-1-.447-1-1v-3c0-.68.234-1.346.658-1.874l4-5c.98-1.226 2.885-1.469 4.143-.524l1.674 1.254 2.185-2.729c.57-.717 1.424-1.127 2.341-1.127.679 0 1.343.232 1.873.657.716.572 1.126 1.426 1.126 2.343v10c0 .553-.448 1-1 1zm-15-2h14v-9c0-.307-.137-.59-.375-.779-.227-.183-.465-.221-.624-.221-.306 0-.591.137-.782.376l-2.789 3.485c-.337.423-.949.5-1.381.176l-2.449-1.837c-.422-.316-1.055-.233-1.381.176l-4 5c-.181.228-.219.464-.219.624v2zM20 21h-16c-.552 0-1-.447-1-1s.448-1 1-1h16c.552 0 1 .447 1 1s-.448 1-1 1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
