// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiEightsleep : ComponentBase
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
		builder.AddAttribute(15, "d", "M19.847 7.28V4.105A4.104 4.104 0 0 0 15.745 0H8.258a4.104 4.104 0 0 0-4.105 4.102v3.183a4.092 4.092 0 0 0 2.415 3.738v.588a4.102 4.102 0 0 0-2.415 3.738v4.546A4.104 4.104 0 0 0 8.255 24h7.488a4.104 4.104 0 0 0 4.104-4.104v-4.553a4.102 4.102 0 0 0-2.415-3.738v-.587a4.102 4.102 0 0 0 2.415-3.738zM8.451 5.126c0-.818.662-1.482 1.48-1.483h4.133c.819 0 1.483.663 1.483 1.482v1.991c0 .819-.664 1.482-1.483 1.482H9.93a1.482 1.482 0 0 1-1.482-1.482l.003-1.99zm7.1 13.732c0 .818-.664 1.482-1.483 1.482H9.93a1.482 1.482 0 0 1-1.482-1.482v-2.752c0-.819.664-1.483 1.482-1.483h4.134c.819 0 1.483.664 1.483 1.483l.003 2.752z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
