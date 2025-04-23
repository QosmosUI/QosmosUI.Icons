// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineChair : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M20,8V6c0-1.65-1.35-3-3-3H7C5.35,3,4,4.35,4,6v2c-1.65,0-3,1.35-3,3v5c0,1.65,1.35,3,3,3v1c0,0.55,0.45,1,1,1 c0.55,0,1-0.45,1-1v-1h12v1c0,0.55,0.45,1,1,1c0.55,0,1-0.45,1-1v-1c1.65,0,3-1.35,3-3v-5C23,9.35,21.65,8,20,8z M6,6 c0-0.55,0.45-1,1-1h10c0.55,0,1,0.45,1,1v2.78c-0.61,0.55-1,1.34-1,2.22v2H7v-2c0-0.88-0.39-1.67-1-2.22V6z M21,16 c0,0.55-0.45,1-1,1H4c-0.55,0-1-0.45-1-1v-5c0-0.55,0.45-1,1-1s1,0.45,1,1v4h14v-4c0-0.55,0.45-1,1-1s1,0.45,1,1V16z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
