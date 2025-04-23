// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxLoaderCircle : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "12");
		builder.AddAttribute(15, "cy", "20");
		builder.AddAttribute(16, "r", "2");
		builder.CloseElement();
		builder.OpenElement(17, "circle");
		builder.AddAttribute(18, "cx", "12");
		builder.AddAttribute(19, "cy", "4");
		builder.AddAttribute(20, "r", "2");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "6.343");
		builder.AddAttribute(23, "cy", "17.657");
		builder.AddAttribute(24, "r", "2");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "17.657");
		builder.AddAttribute(27, "cy", "6.343");
		builder.AddAttribute(28, "r", "2");
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "cx", "4");
		builder.AddAttribute(31, "cy", "12");
		builder.AddAttribute(32, "r", "2.001");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "20");
		builder.AddAttribute(35, "cy", "12");
		builder.AddAttribute(36, "r", "2");
		builder.CloseElement();
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "cx", "6.343");
		builder.AddAttribute(39, "cy", "6.344");
		builder.AddAttribute(40, "r", "2");
		builder.CloseElement();
		builder.OpenElement(41, "circle");
		builder.AddAttribute(42, "cx", "17.657");
		builder.AddAttribute(43, "cy", "17.658");
		builder.AddAttribute(44, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
