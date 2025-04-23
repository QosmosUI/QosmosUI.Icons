// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillBrandVimeo : ComponentBase
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
		builder.AddAttribute(14, "d", "M18.5 3c2.38 0 3.985 2.174 3.486 5.164c-.535 3.21 -2.25 6.074 -4.808 8.675c-1.277 1.298 -2.211 2.061 -4.112 3.485c-2.323 1.597 -4.408 .365 -5.47 -1.897c-.292 -.618 -.586 -1.724 -1.248 -4.477l-.03 -.126c-.483 -2.01 -.819 -3.319 -.982 -3.878l-.016 -.052l-.031 .013l-.13 .06l-.137 .07a4 4 0 0 0 -.43 .269a1 1 0 0 1 -1.3 -.099l-1 -1a1 1 0 0 1 -.124 -1.262a20 20 0 0 1 1.918 -2.382c.98 -1.037 1.955 -1.816 2.928 -2.233c.5 -.214 .996 -.33 1.486 -.33c2.237 0 3.02 1.588 3.567 4.963c.03 .183 .057 .359 .112 .709c.123 .784 .197 1.198 .292 1.588c.292 1.185 .528 1.984 .735 2.483l-.016 -.039l.096 -.107c.354 -.411 .757 -1.014 1.172 -1.771l.157 -.291c.391 -.745 .505 -1.528 .363 -1.9c-.028 -.073 .007 -.065 -.456 .218a1 1 0 0 1 -1.51 -1.013c.496 -3.053 2.745 -4.84 5.488 -4.84");
		builder.CloseElement();
		builder.CloseElement();
    }
}
