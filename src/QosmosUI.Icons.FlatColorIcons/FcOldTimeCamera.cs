// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcOldTimeCamera : ComponentBase
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
		builder.AddAttribute(14, "fill", "#546E7A");
		builder.AddAttribute(15, "d", "M14,13H8v-1.8C8,10.5,8.5,10,9.2,10h3.6c0.7,0,1.2,0.5,1.2,1.2V13z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#5E35B1");
		builder.AddAttribute(18, "d", "M40,40H8c-2.2,0-4-1.8-4-4V22h40v14C44,38.2,42.2,40,40,40z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#42257A");
		builder.AddAttribute(21, "d", "M12.7,22c-0.4,1.3-0.7,2.6-0.7,4c0,6.6,5.4,12,12,12s12-5.4,12-12c0-1.4-0.3-2.7-0.7-4H12.7z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#78909C");
		builder.AddAttribute(24, "d", "M8,12h32c2.2,0,4,1.8,4,4v6H4v-6C4,13.8,5.8,12,8,12z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#78909C");
		builder.AddAttribute(27, "d", "M33.9,13.1H14.2L17.6,8c0.4-0.6,1-0.9,1.7-0.9h9.6c0.7,0,1.3,0.3,1.7,0.9L33.9,13.1z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#455A64");
		builder.AddAttribute(30, "d", "M35.3,22c-1.6-4.7-6.1-8-11.3-8s-9.7,3.3-11.3,8H35.3z");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "fill", "#B388FF");
		builder.AddAttribute(33, "cx", "24");
		builder.AddAttribute(34, "cy", "26");
		builder.AddAttribute(35, "r", "9");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "fill", "#C7A7FF");
		builder.AddAttribute(38, "d", "M29,23c-1.2-1.4-3-2.2-4.8-2.2c-1.8,0-3.6,0.8-4.8,2.2c-0.5,0.5-0.4,1.3,0.1,1.8c0.5,0.5,1.3,0.4,1.8-0.1 c1.5-1.7,4.3-1.7,5.8,0c0.3,0.3,0.6,0.4,1,0.4c0.3,0,0.6-0.1,0.9-0.3C29.4,24.4,29.5,23.5,29,23z");
		builder.CloseElement();
		builder.OpenElement(39, "rect");
		builder.AddAttribute(40, "x", "36");
		builder.AddAttribute(41, "y", "15");
		builder.AddAttribute(42, "fill", "#DBE2E5");
		builder.AddAttribute(43, "width", "5");
		builder.AddAttribute(44, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
    }
}
