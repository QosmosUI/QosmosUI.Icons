// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAbstract087 : ComponentBase
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
		builder.AddAttribute(14, "d", "m21,21v71.6751h71.675v-71.6751h-71.675zm104.575,0v71.6751h260.85v-71.6751h-260.85zm293.75,0v71.6751h71.675v-71.6751h-71.675zm-398.325,104.575v260.85h71.675v-260.85h-71.675zm104.575,0v260.85h31.8719c2.6667-45.8772 36.6737-83.2489 80.9281-91.2094v-78.4313c-44.2544-7.9605-78.2614-45.3321-80.9281-91.2094h-31.8719zm228.9781,0c-2.6667,45.8773-36.6738,83.2489-80.9281,91.2094v78.4313c44.2543,7.9605 78.2614,45.3321 80.9281,91.2094h31.8719v-260.85h-31.8719zm64.7719,0v260.85h71.675v-260.85h-71.675zm-398.325,293.75v71.675h71.675v-71.675h-71.675zm104.575,0v71.675h260.85v-71.675h-260.85zm293.75,0v71.675h71.675v-71.675h-71.675z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
