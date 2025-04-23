// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneElectricalServices : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20,15h-2v-2h2c0.55,0,1,0.45,1,1v0C21,14.55,20.55,15,20,15z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M20,19h-2v-2h2c0.55,0,1,0.45,1,1v0C21,18.55,20.55,19,20,19z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M14,12L14,12L14,12c-1.1,0-2,0.9-2,2v0h-2v4h2v0c0,1.1,0.9,2,2,2h0h3l0,0v-8H14z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M4,5L4,5c0,0.55,0.45,1,1,1h3.5C9.33,6,10,6.67,10,7.5v0C10,8.33,9.33,9,8.5,9H7c-2.21,0-4,1.79-4,4v0c0,2.21,1.79,4,4,4h2 v-2H7c-1.1,0-2-0.9-2-2v0c0-1.1,0.9-2,2-2h1.5c1.93,0,3.5-1.57,3.5-3.5v0C12,5.57,10.43,4,8.5,4H5C4.45,4,4,4.45,4,5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
