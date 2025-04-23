// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCloseUpMode : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#2E7D32");
		builder.AddAttribute(15, "d", "M5,24c0,18.9,14.8,19,17,19s4,0,4,0S24.1,26.5,5,24z");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "22");
		builder.AddAttribute(18, "y", "26");
		builder.AddAttribute(19, "fill", "#388E3C");
		builder.AddAttribute(20, "width", "4");
		builder.AddAttribute(21, "height", "17");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#C62828");
		builder.AddAttribute(24, "d", "M34,16c0,5.1-5.2,8.2-8,8.2s-2-3.1-2-8.2s5-9.2,5-9.2S34,10.9,34,16z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#C62828");
		builder.AddAttribute(27, "d", "M14,16c0,5.1,5.2,8.2,8,8.2s2-3.1,2-8.2s-5-9.2-5-9.2S14,10.9,14,16z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#E53935");
		builder.AddAttribute(30, "d", "M24,27c-2.2-1.6-1.9-4.5,2.4-8.8C30.8,13.8,32,7,32,7s5,3.4,5,9C37,21.9,31.3,27,24,27z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "fill", "#E53935");
		builder.AddAttribute(33, "d", "M24,27c2.2-1.6,1.9-4.5-2.4-8.8C17.2,13.8,16,7,16,7s-5,3.4-5,9C11,21.9,16.7,27,24,27z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "fill", "#F44336");
		builder.AddAttribute(36, "d", "M30,16c0,6.1-2.7,11-6,11s-6-4.9-6-11s6-11,6-11S30,9.9,30,16z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#4CAF50");
		builder.AddAttribute(39, "d", "M22,43c0,0,1.8,0,4,0s17-0.1,17-19C23.9,26.5,22,43,22,43z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
