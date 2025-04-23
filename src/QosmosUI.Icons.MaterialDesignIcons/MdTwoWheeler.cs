// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdTwoWheeler : ComponentBase
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
		builder.AddAttribute(16, "fill-rule", "evenodd");
		builder.AddAttribute(17, "height", "24");
		builder.AddAttribute(18, "width", "24");
		builder.AddAttribute(19, "x", "0");
		builder.AddAttribute(20, "y", "0");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M20,11c-0.18,0-0.36,0.03-0.53,0.05L17.41,9H20V6l-3.72,1.86L13.41,5H9v2h3.59l2,2H11l-4,2L5,9H0v2h4c-2.21,0-4,1.79-4,4 c0,2.21,1.79,4,4,4c2.21,0,4-1.79,4-4l2,2h3l3.49-6.1l1.01,1.01C16.59,12.64,16,13.75,16,15c0,2.21,1.79,4,4,4c2.21,0,4-1.79,4-4 C24,12.79,22.21,11,20,11z M4,17c-1.1,0-2-0.9-2-2c0-1.1,0.9-2,2-2c1.1,0,2,0.9,2,2C6,16.1,5.1,17,4,17z M20,17c-1.1,0-2-0.9-2-2 c0-1.1,0.9-2,2-2s2,0.9,2,2C22,16.1,21.1,17,20,17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
