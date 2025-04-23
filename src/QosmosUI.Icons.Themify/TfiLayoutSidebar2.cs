// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiLayoutSidebar2 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M17 0v17h-4v-17h4zM0 17h3v-17h-3v17zM11 17h1v-1h-1v1zM7.571 17h0.857v-1h-0.857v1zM9.286 17h0.857v-1h-0.857v1zM5.857 17h0.857v-1h-0.857v1zM4 17h1v-1h-1v1zM4 3h1v-1h-1v1zM4 13h1v-1h-1v1zM4 15h1v-1h-1v1zM4 11h1v-1h-1v1zM4 7h1v-1h-1v1zM4 5h1v-1h-1v1zM4 9h1v-1h-1v1zM4 1h1v-1h-1v1zM5.857 1h0.857v-1h-0.857v1zM9.286 1h0.857v-1h-0.857v1zM7.571 1h0.857v-1h-0.857v1zM11 1h1v-1h-1v1zM11 5h1v-1h-1v1zM11 3h1v-1h-1v1zM11 7h1v-1h-1v1zM11 9h1v-1h-1v1zM11 15h1v-1h-1v1zM11 13h1v-1h-1v1zM11 11h1v-1h-1v1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
