// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Default;

public class MdWavingHand : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M23,17c0,3.31-2.69,6-6,6v-1.5c2.48,0,4.5-2.02,4.5-4.5H23z M1,7c0-3.31,2.69-6,6-6v1.5C4.52,2.5,2.5,4.52,2.5,7H1z M8.01,4.32l-4.6,4.6c-3.22,3.22-3.22,8.45,0,11.67s8.45,3.22,11.67,0l7.07-7.07c0.49-0.49,0.49-1.28,0-1.77 c-0.49-0.49-1.28-0.49-1.77,0l-4.42,4.42l-0.71-0.71l6.54-6.54c0.49-0.49,0.49-1.28,0-1.77s-1.28-0.49-1.77,0l-5.83,5.83l-0.71-0.71 l6.89-6.89c0.49-0.49,0.49-1.28,0-1.77s-1.28-0.49-1.77,0l-6.89,6.89L11.02,9.8l5.48-5.48c0.49-0.49,0.49-1.28,0-1.77 s-1.28-0.49-1.77,0l-7.62,7.62c1.22,1.57,1.11,3.84-0.33,5.28l-0.71-0.71c1.17-1.17,1.17-3.07,0-4.24l-0.35-0.35l4.07-4.07 c0.49-0.49,0.49-1.28,0-1.77C9.29,3.83,8.5,3.83,8.01,4.32z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
