// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiHtc : ComponentBase
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
		builder.AddAttribute(15, "d", "M22 14.75h-2.8c-.7-.05-1.15-.5-1.2-1.15v-1.15c.05-.65.6-1.25 1.2-1.25H24V9.95h-4.85c-.65.05-1.25.25-1.7.7-.4.4-.65 1.1-.7 1.75 0 .35-.05.85 0 1.15.05.75.3 1.3.7 1.7.4.45 1.05.7 1.7.7H24V14.7c0 .05-1.3.05-2 .05M8.5 10v1.25h2.95v4.7h1.25v-4.7h2.95V10Zm-1.3 2.35c0-.65-.25-1.25-.7-1.7-.5-.5-1.2-.7-1.7-.7H2.35c-.55 0-.95.2-1.15.35V8H0v8h1.25v-3.6c.05-.65.55-1.15 1.15-1.2.5-.05 1.95-.05 2.4 0 .65.05 1.1.55 1.15 1.2V16H7.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
