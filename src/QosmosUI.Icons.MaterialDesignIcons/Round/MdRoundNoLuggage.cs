// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundNoLuggage : ComponentBase
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
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M20.49,20.49L3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0c-0.39,0.39-0.39,1.02,0,1.41l2.92,2.92C5.02,7.9,5,7.95,5,8v11 c0,1.1,0.9,2,2,2c0,0.55,0.45,1,1,1c0.55,0,1-0.45,1-1h6c0,0.55,0.45,1,1,1c0.55,0,1-0.45,1-1c0.34,0,0.65-0.09,0.93-0.24 l1.14,1.14c0.39,0.39,1.02,0.39,1.41,0C20.88,21.51,20.88,20.88,20.49,20.49z M8.75,18C8.34,18,8,17.66,8,17.25v-6.42l1.5,1.5v4.92 C9.5,17.66,9.16,18,8.75,18z M12,18c-0.41,0-0.75-0.34-0.75-0.75v-3.17l1.5,1.5v1.67C12.75,17.66,12.41,18,12,18z M12,9 c0.41,0,0.75,0.34,0.75,0.75v0.17l1.75,1.75V9.75C14.5,9.34,14.84,9,15.25,9S16,9.34,16,9.75v3.42l3,3V8c0-1.1-0.9-2-2-2h-2V3 c0-0.55-0.45-1-1-1h-4C9.45,2,9,2.45,9,3v3H8.83l3.03,3.03C11.91,9.02,11.95,9,12,9z M10.5,3.5h3V6h-3V3.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
