// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxBrightnessHalf : ComponentBase
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
		builder.AddAttribute(14, "d", "m21.707 11.293-2-2L19 8.586V6a1 1 0 0 0-1-1h-2.586l-.707-.707-2-2a.999.999 0 0 0-1.414 0l-2 2L8.586 5H6a1 1 0 0 0-1 1v2.586l-.707.707-2 2a.999.999 0 0 0 0 1.414l2 2 .707.707V18a1 1 0 0 0 1 1h2.586l.707.707 2 2a.997.997 0 0 0 1.414 0l2-2 .707-.707H18a1 1 0 0 0 1-1v-2.586l.707-.707 2-2a.999.999 0 0 0 0-1.414zm-4.414 3-.293.293V17h-2.414l-.293.293-1 1L12 19.586l-1.293-1.293-1-1L9.414 17H7v-2.414l-.293-.293-1-1L4.414 12l1.293-1.293 1-1L7 9.414V7h2.414l.293-.293 1-1L12 4.414l1.293 1.293 1 1 .293.293H17v2.414l.293.293 1 1L19.586 12l-1.293 1.293-1 1z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M12 8v8c2.206 0 4-1.794 4-4s-1.794-4-4-4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
