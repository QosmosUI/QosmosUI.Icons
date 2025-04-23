// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillCookieMan : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.007 1l.238 .005a6 6 0 0 1 5.405 3.974l.078 .233a6 6 0 0 1 -.182 4.08l-.093 .21l.05 -.002a2.94 2.94 0 0 1 2.638 1.511l.081 .158a2.887 2.887 0 0 1 -1.234 3.764l-.19 .096l-1.798 .821v.963l1.166 1.166l.14 .154a2.96 2.96 0 0 1 -.17 4.002c-1.087 1.088 -2.827 1.161 -4.03 .144l-.16 -.146l-1.946 -1.948l-1.946 1.947a2.96 2.96 0 0 1 -3.95 .22l-.15 -.128c-1.17 -1.073 -1.284 -2.879 -.234 -4.12l.146 -.158l1.134 -1.134v-.962l-1.834 -.84l-.181 -.093a2.88 2.88 0 0 1 -1.205 -3.75a2.93 2.93 0 0 1 2.646 -1.661l.13 .003l-.03 -.064a6.1 6.1 0 0 1 -.503 -1.968l-.017 -.26v-.217a6 6 0 0 1 5.775 -5.996l.224 -.004zm.003 15h-.01a1 1 0 0 0 0 2h.01a1 1 0 0 0 0 -2m0 -3h-.01a1 1 0 0 0 0 2h.01a1 1 0 0 0 0 -2m0 -5h-.01a1 1 0 0 0 0 2h.01a1 1 0 0 0 0 -2m-2 -3h-.01a1 1 0 1 0 0 2h.01a1 1 0 0 0 0 -2m4 0h-.01a1 1 0 0 0 0 2h.01a1 1 0 0 0 0 -2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
