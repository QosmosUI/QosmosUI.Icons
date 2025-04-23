// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoFileMedia : ComponentBase
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
		builder.AddAttribute(14, "d", "M21.75 21.5H2.25A1.75 1.75 0 0 1 .5 19.75V4.25c0-.966.784-1.75 1.75-1.75h19.5c.966 0 1.75.784 1.75 1.75v15.5a1.75 1.75 0 0 1-1.75 1.75ZM2.25 4a.25.25 0 0 0-.25.25v15.5c0 .138.112.25.25.25h3.178L14 10.977a1.749 1.749 0 0 1 2.506-.032L22 16.44V4.25a.25.25 0 0 0-.25-.25ZM22 19.75v-1.19l-6.555-6.554a.248.248 0 0 0-.18-.073.247.247 0 0 0-.178.077L7.497 20H21.75a.25.25 0 0 0 .25-.25ZM10.5 9.25a3.25 3.25 0 1 1-6.5 0 3.25 3.25 0 0 1 6.5 0Zm-1.5 0a1.75 1.75 0 1 0-3.501.001A1.75 1.75 0 0 0 9 9.25Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
