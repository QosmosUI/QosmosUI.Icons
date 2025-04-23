// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoRepoTemplate : ComponentBase
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
		builder.AddAttribute(14, "d", "M5.75 0A2.75 2.75 0 0 0 3 2.75v1a.75.75 0 0 0 1.5 0v-1c0-.69.56-1.25 1.25-1.25h1a.75.75 0 0 0 0-1.5h-1Zm4 0a.75.75 0 0 0 0 1.5h4.5a.75.75 0 0 0 0-1.5h-4.5Zm7.5 0a.75.75 0 0 0 0 1.5h2.25v2.25a.75.75 0 0 0 1.5 0v-3a.75.75 0 0 0-.75-.75h-3ZM4.5 6.5a.75.75 0 0 0-1.5 0v3.75a.75.75 0 0 0 1.5 0V6.5Zm16.5 0a.75.75 0 0 0-1.5 0v3.75a.75.75 0 0 0 1.5 0V6.5ZM4.5 13.25a.75.75 0 0 0-1.5 0v5.5a3.25 3.25 0 0 0 1.95 2.98.75.75 0 1 0 .6-1.375A1.75 1.75 0 0 1 4.5 18.75V18A1.5 1.5 0 0 1 6 16.5h.75a.75.75 0 0 0 0-1.5H6c-.546 0-1.059.146-1.5.401V13.25Zm16.5 0a.75.75 0 0 0-1.5 0V15h-2.25a.75.75 0 0 0 0 1.5h2.25v4h-5.25a.75.75 0 0 0 0 1.5h6a.75.75 0 0 0 .75-.75v-8ZM9.75 15a.75.75 0 0 0 0 1.5h4.5a.75.75 0 0 0 0-1.5h-4.5Zm-2.353 8.461A.25.25 0 0 1 7 23.26v-5.01a.25.25 0 0 1 .25-.25h5a.25.25 0 0 1 .25.25v5.01a.25.25 0 0 1-.397.201l-2.206-1.604a.25.25 0 0 0-.294 0L7.397 23.46Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
