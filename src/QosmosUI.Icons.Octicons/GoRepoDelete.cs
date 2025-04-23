// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoRepoDelete : ComponentBase
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
		builder.AddAttribute(14, "d", "M4.75 0A2.75 2.75 0 0 0 2 2.75v16.5A2.75 2.75 0 0 0 4.75 22h8a.75.75 0 0 0 0-1.5h-8c-.69 0-1.25-.56-1.25-1.25V18A1.5 1.5 0 0 1 5 16.5h7.75a.75.75 0 0 0 0-1.5H5c-.546 0-1.059.146-1.5.401V2.75c0-.69.56-1.25 1.25-1.25H18.5v12.25a.75.75 0 0 0 1.5 0v-13a.75.75 0 0 0-.75-.75H4.75Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M15.22 16.22a.75.75 0 0 1 1.06 0L19 18.94l2.72-2.72a.75.75 0 1 1 1.06 1.06L20.06 20l2.72 2.72a.75.75 0 1 1-1.06 1.06L19 21.06l-2.72 2.72a.75.75 0 1 1-1.06-1.06L17.94 20l-2.72-2.72a.75.75 0 0 1 0-1.06Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
