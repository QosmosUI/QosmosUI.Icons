// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons.Default;

public class GoPivotColumn : ComponentBase
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
		builder.AddAttribute(14, "d", "M2 3.75C2 2.783 2.783 2 3.75 2h16.5c.966 0 1.75.783 1.75 1.75V10a.75.75 0 0 1-1.5 0V8.75H8.75V20.5H10a.75.75 0 0 1 0 1.5H3.75A1.75 1.75 0 0 1 2 20.25Zm6.75-.25v3.75H20.5v-3.5a.25.25 0 0 0-.25-.25Zm-1.5 17V8.75H3.5v11.5c0 .138.112.25.25.25ZM3.5 7.25h3.75V3.5h-3.5a.25.25 0 0 0-.25.25Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M21.25 12.312a.75.75 0 0 1 .75.75v2.626a3.75 3.75 0 0 1-3.75 3.75h-3.502l2.032 2.032a.749.749 0 1 1-1.06 1.06l-3.25-3.25a.749.749 0 0 1 0-1.06l3.25-3.25a.749.749 0 1 1 1.06 1.06l-1.907 1.908h3.377a2.25 2.25 0 0 0 2.25-2.25v-2.626a.75.75 0 0 1 .75-.75Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
