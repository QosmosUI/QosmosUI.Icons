// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class Si1001tracklists : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.0957 1.334v1.3457H6.7461v1.3457H5.3984V5.371H4.0488v1.3457H2.6992v6.6816H1.3496v1.3477H0v2.4512h1.3496v1.3457h1.3496v1.3457h2.457v-7.836H3.8067V7.8223h1.3497V6.4766h1.3496V5.1309h1.3496V3.7852h8.289v1.3457h1.3496v1.3457h1.3496v1.3457h1.3497v4.2304h-1.3497v7.836h2.457V18.543h1.3497v-1.3457H24V14.746h-1.3496v-1.3477h-1.3496V6.7168h-1.3496V5.3711h-1.3496V4.0254h-1.3477V2.6797h-1.3496V1.334Zm1.3711 8v1.3515H8.1113v3.8165h2.4688v-4.0567h2.9512v4.3477h-1.3555v1.3515h-1.3535v2.4649h2.4668v-2.7051H16v-5.2188h-1.3555V9.334Zm1.3555 10.8691v2.463h2.4668v-2.463z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
