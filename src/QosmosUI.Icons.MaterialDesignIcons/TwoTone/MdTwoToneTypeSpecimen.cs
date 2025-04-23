// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneTypeSpecimen : ComponentBase
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
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "opacity", ".3");
		builder.AddAttribute(22, "points", "14.04,7.17 13.96,7.17 12.65,10.89 15.34,10.89");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M8,16h12V4H8V16z M13.2,5.5h1.61l3.38,9h-1.56l-0.8-2.3h-3.63l-0.82,2.3H9.81L13.2,5.5z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M4,6H2v14c0,1.1,0.9,2,2,2h14v-2H4V6z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M20,2H8C6.9,2,6,2.9,6,4v12c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2V4C22,2.9,21.1,2,20,2z M20,16H8V4h12V16z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M12.19,12.2h3.63l0.8,2.3h1.56l-3.38-9H13.2l-3.38,9h1.56L12.19,12.2z M13.96,7.17h0.08l1.31,3.72h-2.69L13.96,7.17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
