// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCandleSticks : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#546E7A");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "38");
		builder.AddAttribute(17, "y", "4");
		builder.AddAttribute(18, "width", "2");
		builder.AddAttribute(19, "height", "20");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "15");
		builder.AddAttribute(22, "y", "7");
		builder.AddAttribute(23, "width", "2");
		builder.AddAttribute(24, "height", "17");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "8");
		builder.AddAttribute(27, "y", "27");
		builder.AddAttribute(28, "width", "2");
		builder.AddAttribute(29, "height", "17");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "28");
		builder.AddAttribute(32, "y", "19");
		builder.AddAttribute(33, "width", "2");
		builder.AddAttribute(34, "height", "22");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "fill", "#4CAF50");
		builder.AddAttribute(37, "d", "M36,7h6c1.1,0,2,0.9,2,2v10c0,1.1-0.9,2-2,2h-6c-1.1,0-2-0.9-2-2V9C34,7.9,34.9,7,36,7z");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "fill", "#4CAF50");
		builder.AddAttribute(40, "d", "M13,10h6c1.1,0,2,0.9,2,2v7c0,1.1-0.9,2-2,2h-6c-1.1,0-2-0.9-2-2v-7C11,10.9,11.9,10,13,10z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "fill", "#F44336");
		builder.AddAttribute(43, "d", "M6,30h6c1.1,0,2,0.9,2,2v7c0,1.1-0.9,2-2,2H6c-1.1,0-2-0.9-2-2v-7C4,30.9,4.9,30,6,30z");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "fill", "#F44336");
		builder.AddAttribute(46, "d", "M26,22h6c1.1,0,2,0.9,2,2v12c0,1.1-0.9,2-2,2h-6c-1.1,0-2-0.9-2-2V24C24,22.9,24.9,22,26,22z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
