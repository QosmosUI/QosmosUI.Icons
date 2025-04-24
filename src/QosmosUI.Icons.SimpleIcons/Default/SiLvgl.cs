// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiLvgl : ComponentBase
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
		builder.AddAttribute(15, "d", "M9.23 16.615h5.54c.51 0 .922.412.922.923v5.539a.921.921 0 0 1-.923.923H9.231a.921.921 0 0 1-.923-.923v-5.539c0-.511.411-.923.923-.923zM0 17.538c0-.51.413-.923.923-.923h5.539c.51 0 .923.413.923.923v5.539c0 .51-.414.923-.923.923H2.769A2.77 2.77 0 0 1 0 21.23zm.923-9.23h5.539c.511 0 .923.411.923.922v5.539a.921.921 0 0 1-.923.923H.923A.921.921 0 0 1 0 14.769V9.23c0-.511.412-.923.923-.923zM2.77 0A2.77 2.77 0 0 0 0 2.769V6.46c0 .51.413.923.923.923h5.539c1.02 0 1.846.827 1.846 1.846v5.539c0 .51.413.923.923.923h5.538c1.02 0 1.847.826 1.847 1.846v5.539c0 .51.413.923.923.923h3.692A2.77 2.77 0 0 0 24 21.23V2.77a2.77 2.77 0 0 0-2.77-2.77zm18 1.846a1.385 1.385 0 1 1 0 2.769 1.385 1.385 0 0 1 0-2.77z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
