// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEmojiFoodBeverage : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M10,6.4l1.81,1.45C11.93,7.94,12,8.09,12,8.24v4.26c0,0.28-0.22,0.5-0.5,0.5h-4C7.22,13,7,12.78,7,12.5 V8.24c0-0.15,0.07-0.3,0.19-0.39L9,6.4V5H6v8c0,1.1,0.9,2,2,2h6c1.1,0,2-0.9,2-2V5h-6V6.4z");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "2");
		builder.AddAttribute(26, "width", "18");
		builder.AddAttribute(27, "x", "2");
		builder.AddAttribute(28, "y", "19");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M20,3H4v10c0,2.21,1.79,4,4,4h6c2.21,0,4-1.79,4-4v-3h2c1.11,0,2-0.89,2-2V5C22,3.89,21.11,3,20,3z M9.5,7.28l1.5,1.2V12 H8V8.48L9.5,7.28z M16,13c0,1.1-0.9,2-2,2H8c-1.1,0-2-0.9-2-2V5h3v1.4L7.19,7.85C7.07,7.94,7,8.09,7,8.24v4.26 C7,12.78,7.22,13,7.5,13h4c0.28,0,0.5-0.22,0.5-0.5V8.24c0-0.15-0.07-0.3-0.19-0.39L10,6.4V5h6V13z M20,8h-2V5h2V8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
