// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoHourglass : ComponentBase
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
		builder.AddAttribute(14, "d", "M4.75 2h14.5a.75.75 0 0 1 0 1.5h-.75v2.982a4.75 4.75 0 0 1-2.215 4.017l-2.044 1.29a.25.25 0 0 0 0 .422l2.044 1.29a4.75 4.75 0 0 1 2.215 4.017V20.5h.75a.75.75 0 0 1 0 1.5H4.75a.75.75 0 0 1 0-1.5h.75v-2.982a4.75 4.75 0 0 1 2.215-4.017l2.044-1.29a.25.25 0 0 0 0-.422l-2.044-1.29A4.75 4.75 0 0 1 5.5 6.482V3.5h-.75a.75.75 0 0 1 0-1.5ZM17 3.5H7v2.982A3.25 3.25 0 0 0 8.516 9.23l2.044 1.29a1.75 1.75 0 0 1 0 2.96l-2.044 1.29A3.25 3.25 0 0 0 7 17.518V20.5h10v-2.982a3.25 3.25 0 0 0-1.516-2.748l-2.044-1.29a1.75 1.75 0 0 1 0-2.96l2.044-1.29A3.25 3.25 0 0 0 17 6.482Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
