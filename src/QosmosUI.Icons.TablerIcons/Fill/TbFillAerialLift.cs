// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillAerialLift : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.876 2.008a1 1 0 1 1 .248 1.984l-7.124 .891v2.117h4.2a1 1 0 0 1 .688 .274l.087 .093c2.79 3.417 2.717 9.963 -.226 13.295a1 1 0 0 1 -.749 .338h-10.106a1 1 0 0 1 -.763 -.353c-2.86 -3.373 -2.86 -9.92 0 -13.294a1 1 0 0 1 .763 -.353h4.106v-1.867l-6.876 .86a1 1 0 0 1 -1.095 -.754l-.021 -.115a1 1 0 0 1 .868 -1.116l7.996 -1l.011 -.001l.008 -.001zm-8.876 6.992h-3.617l-.051 .072c-.718 1.042 -1.149 2.41 -1.292 3.844l-.008 .084h4.968zm5.698 0h-3.698v4h4.979l-.005 -.072c-.123 -1.436 -.533 -2.811 -1.232 -3.864z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
