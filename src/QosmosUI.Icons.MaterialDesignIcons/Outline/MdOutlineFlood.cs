// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineFlood : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M18.67,19c-1.95,0-2.09,1-3.33,1c-1.19,0-1.42-1-3.33-1c-1.95,0-2.1,1-3.34,1c-1.24,0-1.38-1-3.33-1c-1.95,0-2.1,1-3.34,1 v2c1.95,0,2.11-1,3.34-1c1.24,0,1.38,1,3.33,1c1.95,0,2.1-1,3.34-1c1.22,0,1.4,1,3.33,1c1.93,0,2.1-1,3.33-1c1.22,0,1.4,1,3.33,1 v-2C20.76,20,20.62,19,18.67,19z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M8.68,17.5c1.95,0,2.09-1,3.33-1c1.19,0,1.42,1,3.33,1c1.95,0,2.09-1,3.33-1c1.19,0,1.4,0.98,3.31,1v-2 c-0.63,0-1-0.28-1.48-0.55l-2.02-7.53l2.09,0.85l0.74-1.86L9.78,2L2,11.61l1.57,1.23l1.39-1.78l0.93,3.48 c-0.18-0.02-0.35-0.05-0.56-0.05c-1.95,0-2.09,1-3.33,1v2c1.9,0,2.17-1,3.35-1C6.54,16.5,6.77,17.5,8.68,17.5z M10.42,4.41 l5.74,2.09l2.15,8.02c-1.54,0.11-1.82,0.89-2.85,0.96l-1.42-5.31l-3.86,1.04l0.91,3.39c-1.12,0.25-1.41,0.9-2.42,0.9 c-0.18,0-0.33-0.02-0.45-0.05L6.5,9.09L10.42,4.41z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
