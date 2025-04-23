// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneRocket : ComponentBase
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
		builder.AddAttribute(20, "opacity", ".3");
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M7.98,18.25c-0.29-0.9-0.57-1.94-0.76-3L6,16.07v2.98L7.98,18.25z M12,4.36c0,0-3,2.02-3,8.64c0,2.25,1,5,1,5h4 c0,0,1-2.75,1-5C15,6.38,12,4.36,12,4.36z M12,13c-1.1,0-2-0.9-2-2c0-1.1,0.9-2,2-2s2,0.9,2,2C14,12.1,13.1,13,12,13z M18,19.05 v-2.98l-1.22-0.81c-0.19,1.05-0.47,2.1-0.76,3L18,19.05z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "g");
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M14,11c0-1.1-0.9-2-2-2s-2,0.9-2,2s0.9,2,2,2S14,12.1,14,11z M7.98,18.25c-0.29-0.9-0.57-1.94-0.76-3L6,16.07v2.98 L7.98,18.25z M12,2c0,0,5,2,5,11l2.11,1.41c0.56,0.37,0.89,1,0.89,1.66V22l-5-2H9l-5,2v-5.93c0-0.67,0.33-1.29,0.89-1.66L7,13 C7,4,12,2,12,2z M12,4.36c0,0-3,2.02-3,8.64c0,2.25,1,5,1,5h4c0,0,1-2.75,1-5C15,6.38,12,4.36,12,4.36z M18,19.05v-2.98 l-1.22-0.81c-0.19,1.05-0.47,2.1-0.76,3L18,19.05z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
