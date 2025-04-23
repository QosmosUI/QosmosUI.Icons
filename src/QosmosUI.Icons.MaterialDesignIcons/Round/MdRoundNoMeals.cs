// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundNoMeals : ComponentBase
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
		builder.AddAttribute(18, "d", "M21,18.17l-2-2V14h-1c-1.1,0-2-0.9-2-2V6c0-1.49,1.6-3.32,3.76-3.85C20.39,2,21,2.48,21,3.13V18.17z M21.19,22.61 c-0.39,0.39-1.02,0.39-1.41,0l-9.76-9.76C9.69,12.94,9.36,13,9,13v8c0,0.55-0.45,1-1,1s-1-0.45-1-1v-8c-2.21,0-4-1.79-4-4V5.83 L1.39,4.22C1,3.83,1,3.2,1.39,2.81c0.39-0.39,1.02-0.39,1.41,0l18.38,18.38C21.58,21.58,21.58,22.22,21.19,22.61z M6.17,9L5,7.83V9 H6.17z M13,9V3c0-0.55-0.45-1-1-1s-1,0.45-1,1v5.17l1.85,1.85C12.94,9.69,13,9.36,13,9z M9,3c0-0.55-0.45-1-1-1S7,2.45,7,3v1.17l2,2 V3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
