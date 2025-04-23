// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiUmbrel : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.853 8.302c2.628-.05 4.698.656 6.303 2.05 1.166 1.01 2.14 2.43 2.895 4.305a7.584 7.584 0 0 0-1.818-.21c-1.345 0-2.552.31-3.558.987-1.127-.687-2.339-1.049-3.623-1.049-1.313 0-2.573.378-3.77 1.087-1.154-.726-2.456-1.087-3.875-1.087-.513 0-1.003.048-1.466.147.678-1.724 1.575-3.054 2.664-4.028 1.557-1.393 3.607-2.15 6.248-2.202zM1.842 17.616c.04-.037.078-.076.112-.119.48-.557 1.233-.91 2.453-.91 1.151 0 2.139.32 3.002.952l.035.025c.469.35 1.108.364 1.592.036 1.032-.698 2.032-1.014 3.017-1.014.967 0 1.906.304 2.836.965l.02.014a1.376 1.376 0 0 0 1.699-.078c.614-.53 1.455-.84 2.625-.84 1.232 0 2.186.344 2.94.98a1.092 1.092 0 0 0 .435.235 1.095 1.095 0 0 0 .806-.087 1.103 1.103 0 0 0 .547-1.267c-.873-3.383-2.3-6.03-4.363-7.82-2.084-1.808-4.712-2.646-7.787-2.588-3.063.06-5.653.955-7.673 2.762-2.003 1.793-3.344 4.39-4.104 7.67a1.1 1.1 0 0 0 1.807 1.083z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
