// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdHive : ComponentBase
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
		builder.AddAttribute(21, "points", "13.79,8 15.59,5 13.79,2 10.21,2 8.41,5 10.21,8");
		builder.CloseElement();
		builder.OpenElement(22, "polygon");
		builder.AddAttribute(23, "points", "10.21,9 8.41,12 10.21,15 13.79,15 15.59,12 13.79,9");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "points", "16.45,11.51 20.04,11.51 21.83,8.51 20.04,5.51 16.45,5.51 14.65,8.51");
		builder.CloseElement();
		builder.OpenElement(26, "polygon");
		builder.AddAttribute(27, "points", "20.04,12.51 16.45,12.51 14.65,15.51 16.45,18.51 20.04,18.51 21.83,15.51");
		builder.CloseElement();
		builder.OpenElement(28, "polygon");
		builder.AddAttribute(29, "points", "7.55,11.51 9.35,8.51 7.55,5.51 3.96,5.51 2.17,8.51 3.96,11.51");
		builder.CloseElement();
		builder.OpenElement(30, "polygon");
		builder.AddAttribute(31, "points", "7.55,12.51 3.96,12.51 2.17,15.51 3.96,18.51 7.55,18.51 9.35,15.51");
		builder.CloseElement();
		builder.OpenElement(32, "polygon");
		builder.AddAttribute(33, "points", "10.21,16 8.41,19 10.21,22 13.79,22 15.59,19 13.79,16");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
