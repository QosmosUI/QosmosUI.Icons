// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImChrome : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M4.036 6.977l-2.29-3.966c1.466-1.835 3.722-3.012 6.254-3.012 2.929 0 5.489 1.574 6.883 3.922h-6.528c-0.117-0.010-0.236-0.016-0.356-0.016-1.904 0-3.509 1.307-3.964 3.071zM10.864 5.078h4.585c0.355 0.905 0.551 1.891 0.551 2.922 0 4.388-3.533 7.95-7.909 7.999l3.272-5.667c0.461-0.662 0.731-1.466 0.731-2.332 0-1.143-0.471-2.178-1.23-2.922zM5.094 8c0-1.603 1.304-2.906 2.906-2.906s2.906 1.304 2.906 2.906c0 1.602-1.304 2.906-2.906 2.906s-2.906-1.304-2.906-2.906zM9.097 11.944l-2.29 3.967c-3.852-0.576-6.806-3.899-6.806-7.911 0-1.425 0.373-2.763 1.026-3.922l3.266 5.657c0.654 1.392 2.070 2.359 3.707 2.359 0.38 0 0.747-0.052 1.097-0.149z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
