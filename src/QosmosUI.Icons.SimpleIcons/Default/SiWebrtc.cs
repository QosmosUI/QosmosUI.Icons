// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiWebrtc : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.9998.3598c-2.8272 0-5.1456 2.1733-5.3793 4.94a5.4117 5.4117 0 00-1.2207-.1401C2.418 5.1597 0 7.5779 0 10.5603c0 2.2203 1.341 4.1274 3.2568 4.957a5.3734 5.3734 0 00-.7372 2.7227c0 2.9823 2.4175 5.4002 5.4002 5.4002 1.6627 0 3.1492-.7522 4.1397-1.934.9906 1.1818 2.4773 1.934 4.1398 1.934 2.983 0 5.4004-2.418 5.4004-5.4002 0-.9719-.258-1.883-.7073-2.6708C22.7283 14.7068 24 12.8418 24 10.6795c0-2.9823-2.4175-5.4006-5.3998-5.4006-.417 0-.8223.049-1.2121.1384C17.2112 2.5949 14.867.3598 11.9998.3598zm-5.717 6.8683h10.5924c.7458 0 1.352.605 1.352 1.3487v7.6463c0 .7438-.6062 1.3482-1.352 1.3482h-3.6085l-7.24 3.5491 1.1008-3.5491h-.8447c-.7458 0-1.3522-.6044-1.3522-1.3482V8.5768c0-.7438.6064-1.3487 1.3522-1.3487Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
