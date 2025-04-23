// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDiamond : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "polygon");
		builder.AddAttribute(26, "points", "12.16,3 11.84,3 9.21,8.25 14.79,8.25");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M16.46,8.25h5.16l-2.07-4.14C19.21,3.43,18.52,3,17.76,3h-3.93L16.46,8.25z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(30, "g");
		builder.OpenElement(31, "polygon");
		builder.AddAttribute(32, "points", "21.38,9.75 12.75,9.75 12.75,20.1");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(33, "g");
		builder.OpenElement(34, "polygon");
		builder.AddAttribute(35, "points", "11.25,20.1 11.25,9.75 2.62,9.75");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "g");
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M7.54,8.25L10.16,3H6.24C5.48,3,4.79,3.43,4.45,4.11L2.38,8.25H7.54z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
