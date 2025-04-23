// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSportsBasketball : ComponentBase
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
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M17.09,11h4.86c-0.16-1.61-0.71-3.11-1.54-4.4C18.68,7.43,17.42,9.05,17.09,11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M6.91,11C6.58,9.05,5.32,7.43,3.59,6.6C2.76,7.89,2.21,9.39,2.05,11H6.91z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(30, "g");
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M15.07,11c0.32-2.59,1.88-4.79,4.06-6c-1.6-1.63-3.74-2.71-6.13-2.95V11H15.07z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(33, "g");
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M8.93,11H11V2.05C8.61,2.29,6.46,3.37,4.87,5C7.05,6.21,8.61,8.41,8.93,11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "g");
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M15.07,13H13v8.95c2.39-0.24,4.54-1.32,6.13-2.95C16.95,17.79,15.39,15.59,15.07,13z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(39, "g");
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M3.59,17.4c1.72-0.83,2.99-2.46,3.32-4.4H2.05C2.21,14.61,2.76,16.11,3.59,17.4z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(42, "g");
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M17.09,13c0.33,1.95,1.59,3.57,3.32,4.4c0.83-1.29,1.38-2.79,1.54-4.4H17.09z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(45, "g");
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "d", "M8.93,13c-0.32,2.59-1.88,4.79-4.06,6c1.6,1.63,3.74,2.71,6.13,2.95V13H8.93z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
