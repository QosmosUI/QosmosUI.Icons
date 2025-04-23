// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDisplaySettings : ComponentBase
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
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M20,3H4C2.9,3,2,3.9,2,5v12c0,1.1,0.89,2,2,2h4v1c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1v-1h4c1.1,0,2-0.9,2-2V5 C22,3.89,21.1,3,20,3z M20,17H4V5h16V17z");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "1.5");
		builder.AddAttribute(28, "width", "8");
		builder.AddAttribute(29, "x", "6");
		builder.AddAttribute(30, "y", "8.25");
		builder.CloseElement();
		builder.OpenElement(31, "polygon");
		builder.AddAttribute(32, "points", "16.5,9.75 18,9.75 18,8.25 16.5,8.25 16.5,7 15,7 15,11 16.5,11");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "height", "1.5");
		builder.AddAttribute(35, "width", "8");
		builder.AddAttribute(36, "x", "10");
		builder.AddAttribute(37, "y", "12.25");
		builder.CloseElement();
		builder.OpenElement(38, "polygon");
		builder.AddAttribute(39, "points", "7.5,15 9,15 9,11 7.5,11 7.5,12.25 6,12.25 6,13.75 7.5,13.75");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
