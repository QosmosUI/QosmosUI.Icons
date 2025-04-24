// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiWikibooks : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.027.29c-.424.143-.776.418-1.106.707C.434 5.314.254 5.497.254 5.497c-.236.22-.257.537-.254.859l.021 1.819s2.07-2.013 5.164-4.99c1.665 4.337 3.405 8.651 5.116 12.974.234.653-.329 1.188-1.04 1.902-.982.958-3.034 2.93-5.136 5.561h2.107l5.067-5.554c.482-.662 1.077-1.309.824-1.909L8.145 5.806c.924-.785 1.763-1.676 2.618-2.531l5.252 13.173c.303.891-.175 1.684-1.134 2.549-1.148.922-3.508 3.073-4.58 4.712h1.631c1.71-1.758 2.017-1.994 3.964-3.68 1.308-1.334 2.488-2.022 1.871-3.731l-4.13-10.325c1.007-.99 2.013-1.875 2.98-2.852 2.113 4.643 3.559 8.384 5.33 13.33.58 1.607.458 1.682-.928 2.55-2.228 1.107-2.929 1.834-5.585 4.66h1.815c2.22-2.008 3.045-2.716 5.825-4.18.983-.569 1.116-1.285.713-2.4-1.3-3.616-4.116-11.41-6.719-16.755l-4.103 3.971-1.569-3.92C9.912 1.38 8.74 2.78 7.466 4.04z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
