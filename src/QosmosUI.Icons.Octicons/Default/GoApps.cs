// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons.Default;

public class GoApps : ComponentBase
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
		builder.AddAttribute(14, "d", "M5.5 2.75A2.75 2.75 0 0 0 2.75 5.5v3a2.75 2.75 0 0 0 2.75 2.75h3a2.75 2.75 0 0 0 2.75-2.75v-3A2.75 2.75 0 0 0 8.5 2.75h-3ZM4.25 5.5c0-.69.56-1.25 1.25-1.25h3c.69 0 1.25.56 1.25 1.25v3c0 .69-.56 1.25-1.25 1.25h-3c-.69 0-1.25-.56-1.25-1.25v-3Zm1.25 7.25a2.75 2.75 0 0 0-2.75 2.75v3a2.75 2.75 0 0 0 2.75 2.75h3a2.75 2.75 0 0 0 2.75-2.75v-3a2.75 2.75 0 0 0-2.75-2.75h-3ZM4.25 15.5c0-.69.56-1.25 1.25-1.25h3c.69 0 1.25.56 1.25 1.25v3c0 .69-.56 1.25-1.25 1.25h-3c-.69 0-1.25-.56-1.25-1.25v-3Zm8.5-10a2.75 2.75 0 0 1 2.75-2.75h3a2.75 2.75 0 0 1 2.75 2.75v3a2.75 2.75 0 0 1-2.75 2.75h-3a2.75 2.75 0 0 1-2.75-2.75v-3Zm2.75-1.25c-.69 0-1.25.56-1.25 1.25v3c0 .69.56 1.25 1.25 1.25h3c.69 0 1.25-.56 1.25-1.25v-3c0-.69-.56-1.25-1.25-1.25h-3Zm0 8.5a2.75 2.75 0 0 0-2.75 2.75v3a2.75 2.75 0 0 0 2.75 2.75h3a2.75 2.75 0 0 0 2.75-2.75v-3a2.75 2.75 0 0 0-2.75-2.75h-3Zm-1.25 2.75c0-.69.56-1.25 1.25-1.25h3c.69 0 1.25.56 1.25 1.25v3c0 .69-.56 1.25-1.25 1.25h-3c-.69 0-1.25-.56-1.25-1.25v-3Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
