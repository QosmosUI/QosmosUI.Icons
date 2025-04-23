// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoProjectTemplate : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.75 3.5a.25.25 0 0 0-.25.25v2.062a.75.75 0 1 1-1.5 0V3.75C2 2.783 2.783 2 3.75 2h2.062a.75.75 0 1 1 0 1.5Zm13.688-.75a.75.75 0 0 1 .75-.75h2.062c.966 0 1.75.783 1.75 1.75v2.062a.75.75 0 1 1-1.5 0V3.75a.25.25 0 0 0-.25-.25h-2.062a.75.75 0 0 1-.75-.75ZM2.75 17.438a.75.75 0 0 1 .75.75v2.062c0 .138.112.25.25.25h2.062a.75.75 0 1 1 0 1.5H3.75A1.75 1.75 0 0 1 2 20.25v-2.062a.75.75 0 0 1 .75-.75Zm18.5 0a.75.75 0 0 1 .75.75v2.062A1.75 1.75 0 0 1 20.25 22h-2.062a.75.75 0 1 1 0-1.5h2.062a.25.25 0 0 0 .25-.25v-2.062a.75.75 0 0 1 .75-.75Zm-18.5-8.25a.75.75 0 0 1 .75.75v4.124a.75.75 0 1 1-1.5 0V9.938a.75.75 0 0 1 .75-.75ZM9.188 2.75a.75.75 0 0 1 .75-.75h4.124a.75.75 0 1 1 0 1.5H9.938a.75.75 0 0 1-.75-.75Zm0 18.5a.75.75 0 0 1 .75-.75h4.124a.75.75 0 1 1 0 1.5H9.938a.75.75 0 0 1-.75-.75ZM21.25 9.188a.75.75 0 0 1 .75.75v4.124a.75.75 0 1 1-1.5 0V9.938a.75.75 0 0 1 .75-.75ZM3.75 8.25a.75.75 0 0 1 .75-.75h2a.75.75 0 0 1 0 1.5h-2a.75.75 0 0 1-.75-.75Zm5.5 0A.75.75 0 0 1 10 7.5h2A.75.75 0 0 1 12 9h-2a.75.75 0 0 1-.75-.75Zm-1-4.5A.75.75 0 0 1 9 4.5v2a.75.75 0 0 1-1.5 0v-2a.75.75 0 0 1 .75-.75Zm0 5.5A.75.75 0 0 1 9 10v2a.75.75 0 0 1-1.5 0v-2a.75.75 0 0 1 .75-.75Zm0 4.75a.75.75 0 0 1 .75.75v4a.75.75 0 0 1-1.5 0v-4a.75.75 0 0 1 .75-.75ZM14 8.25a.75.75 0 0 1 .75-.75h4a.75.75 0 0 1 0 1.5h-4a.75.75 0 0 1-.75-.75Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
