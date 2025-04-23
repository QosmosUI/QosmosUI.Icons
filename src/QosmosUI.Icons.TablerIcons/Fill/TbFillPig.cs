// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillPig : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.999 2a1 1 0 0 1 1.001 1v3.255l.026 .018a7 7 0 0 1 2.204 2.537l.092 .19h.676a2 2 0 0 1 1.995 1.85l.005 .15v2a2 2 0 0 1 -2 2h-.676l-.104 .213a7 7 0 0 1 -1.097 1.558l-.123 .125v1.604a2.5 2.5 0 0 1 -2.336 2.495l-.162 .005c-1.16 0 -2.135 -.79 -2.418 -1.86l-.032 -.141l-4.05 .001l-.05 -.002l-.032 .141a2.5 2.5 0 0 1 -2.254 1.856l-.164 .005a2.5 2.5 0 0 1 -2.5 -2.5v-1.602l-.056 -.055a7 7 0 0 1 -1.576 -7.085l.092 -.256a7 7 0 0 1 6.539 -4.502h2.196l4.25 -2.832a1 1 0 0 1 .436 -.161zm-.999 8a1 1 0 0 0 -.993 .883l-.007 .127a1 1 0 0 0 1.993 .117l.007 -.127a1 1 0 0 0 -1 -1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
