// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiWidgetized : ComponentBase
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
		builder.AddAttribute(15, "d", "M2 0h1v1h-1v-1zM4 1h1v-1h-1v1zM6 1h1v-1h-1v1zM8 1h1v-1h-1v1zM10 1h1v-1h-1v1zM12 1h1v-1h-1v1zM14 1h1v-1h-1v1zM2 9h1v-1h-1v1zM4 9h1v-1h-1v1zM6 9h1v-1h-1v1zM10 9h1v-1h-1v1zM12 9h1v-1h-1v1zM14 9h1v-1h-1v1zM2 17h1v-1h-1v1zM4 17h1v-1h-1v1zM6 17h1v-1h-1v1zM8 17h1v-1h-1v1zM10 17h1v-1h-1v1zM12 17h1v-1h-1v1zM14 17h1v-1h-1v1zM16 0v1h1v-1h-1zM16 3h1v-1h-1v1zM16 5h1v-1h-1v1zM16 7h1v-1h-1v1zM16 9h1v-1h-1v1zM16 11h1v-1h-1v1zM16 13h1v-1h-1v1zM16 15h1v-1h-1v1zM8 3h1v-1h-1v1zM8 5h1v-1h-1v1zM8 7h1v-1h-1v1zM8 9h1v-1h-1v1zM8 11h1v-1h-1v1zM8 13h1v-1h-1v1zM8 15h1v-1h-1v1zM16 17h1v-1h-1v1zM0 1h1v-1h-1v1zM0 3h1v-1h-1v1zM0 5h1v-1h-1v1zM0 7h1v-1h-1v1zM0 9h1v-1h-1v1zM0 11h1v-1h-1v1zM0 13h1v-1h-1v1zM0 15h1v-1h-1v1zM0 17h1v-1h-1v1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
