// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoCpu : ComponentBase
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
		builder.AddAttribute(14, "d", "M8.75 8h6.5a.75.75 0 0 1 .75.75v6.5a.75.75 0 0 1-.75.75h-6.5a.75.75 0 0 1-.75-.75v-6.5A.75.75 0 0 1 8.75 8Zm.75 6.5h5v-5h-5Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M15.25 1a.75.75 0 0 1 .75.75V4h2.25c.966 0 1.75.784 1.75 1.75V8h2.25a.75.75 0 0 1 0 1.5H20v5h2.25a.75.75 0 0 1 0 1.5H20v2.25A1.75 1.75 0 0 1 18.25 20H16v2.25a.75.75 0 0 1-1.5 0V20h-5v2.25a.75.75 0 0 1-1.5 0V20H5.75A1.75 1.75 0 0 1 4 18.25V16H1.75a.75.75 0 0 1 0-1.5H4v-5H1.75a.75.75 0 0 1 0-1.5H4V5.75C4 4.784 4.784 4 5.75 4H8V1.75a.75.75 0 0 1 1.5 0V4h5V1.75a.75.75 0 0 1 .75-.75Zm3 17.5a.25.25 0 0 0 .25-.25V5.75a.25.25 0 0 0-.25-.25H5.75a.25.25 0 0 0-.25.25v12.5c0 .138.112.25.25.25Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
