// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class Si1password : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 .007C5.373.007 0 5.376 0 11.999c0 6.624 5.373 11.994 12 11.994S24 18.623 24 12C24 5.376 18.627.007 12 .007Zm-.895 4.857h1.788c.484 0 .729.002.914.096a.86.86 0 0 1 .377.377c.094.185.095.428.095.912v6.016c0 .12 0 .182-.015.238a.427.427 0 0 1-.067.137.923.923 0 0 1-.174.162l-.695.564c-.113.092-.17.138-.191.194a.216.216 0 0 0 0 .15c.02.055.078.101.191.193l.695.565c.094.076.14.115.174.162.03.042.053.087.067.137a.936.936 0 0 1 .015.238v2.746c0 .484-.001.727-.095.912a.86.86 0 0 1-.377.377c-.185.094-.43.096-.914.096h-1.788c-.484 0-.726-.002-.912-.096a.86.86 0 0 1-.377-.377c-.094-.185-.095-.428-.095-.912v-6.016c0-.12 0-.182.015-.238a.437.437 0 0 1 .067-.139c.034-.047.08-.083.174-.16l.695-.564c.113-.092.17-.138.191-.194a.216.216 0 0 0 0-.15c-.02-.055-.078-.101-.191-.193l-.695-.565a.92.92 0 0 1-.174-.162.437.437 0 0 1-.067-.139.92.92 0 0 1-.015-.236V6.25c0-.484.001-.727.095-.912a.86.86 0 0 1 .377-.377c.186-.094.428-.096.912-.096z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
