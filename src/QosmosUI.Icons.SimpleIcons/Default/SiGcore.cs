// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGcore : ComponentBase
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
		builder.AddAttribute(15, "d", "M22.2852 12c0 6.627-5.3608 12-11.973 12-2.6711 0-5.1385-.877-7.1298-2.3583 1.1668.6558 3.0299 1.4182 5.392 1.4187 2.7791 0 5.4545-1.0542 7.4915-2.9458a11.06 11.06 0 0 0 3.5004-7.2625 8.3 8.3 0 0 0 .05-.7875c.0099-.4174-.0662-1.0793-.075-1.2959l-.0103.0104a24 24 0 0 0-.1018-.8145h-8.6868c-.7485 1.398-1.486 2.8019-2.2262 4.2042h6.5644a6.91 6.91 0 0 1-1.0747 2.0187 6.82 6.82 0 0 1-2.403 1.9813 6.796 6.796 0 0 1-3.0306.7082c-.8044 0-1.6026-.1458-2.3572-.425a6.845 6.845 0 0 1-3.2635-2.5145A6.893 6.893 0 0 1 1.7148 12a6.88 6.88 0 0 1 .5218-2.6312 6.92 6.92 0 0 1 1.4862-2.2313 6.82 6.82 0 0 1 2.2263-1.4896c.8335-.3437 1.7252-.5229 2.6253-.5229a6.82 6.82 0 0 1 4.043 1.3208c.6626-1.2376 1.317-2.4795 1.9726-3.7208C11.1651.4884 6.7805.3489 3.2156 2.3292 5.205.8667 7.6577 0 10.3122 0c6.6122 0 11.973 5.373 11.973 12");
		builder.CloseElement();
		builder.CloseElement();
    }
}
