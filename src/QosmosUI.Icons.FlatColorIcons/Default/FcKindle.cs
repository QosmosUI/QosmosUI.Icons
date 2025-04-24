// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcKindle : ComponentBase
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
		builder.AddAttribute(14, "fill", "#37474F");
		builder.AddAttribute(15, "d", "M8,41V7c0-2.2,1.8-4,4-4h24c2.2,0,4,1.8,4,4v34c0,2.2-1.8,4-4,4H12C9.8,45,8,43.2,8,41z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#eee");
		builder.AddAttribute(18, "d", "M35,6H13c-0.6,0-1,0.4-1,1v29c0,0.6,0.4,1,1,1h22c0.6,0,1-0.4,1-1V7C36,6.4,35.6,6,35,6z");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "20");
		builder.AddAttribute(21, "y", "40");
		builder.AddAttribute(22, "fill", "#546E7A");
		builder.AddAttribute(23, "width", "8");
		builder.AddAttribute(24, "height", "2");
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.AddAttribute(26, "fill", "#A1A1A1");
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "16");
		builder.AddAttribute(29, "y", "11");
		builder.AddAttribute(30, "width", "16");
		builder.AddAttribute(31, "height", "3");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "16");
		builder.AddAttribute(34, "y", "18");
		builder.AddAttribute(35, "width", "16");
		builder.AddAttribute(36, "height", "2");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "16");
		builder.AddAttribute(39, "y", "22");
		builder.AddAttribute(40, "width", "12");
		builder.AddAttribute(41, "height", "2");
		builder.CloseElement();
		builder.OpenElement(42, "rect");
		builder.AddAttribute(43, "x", "16");
		builder.AddAttribute(44, "y", "26");
		builder.AddAttribute(45, "width", "16");
		builder.AddAttribute(46, "height", "2");
		builder.CloseElement();
		builder.OpenElement(47, "rect");
		builder.AddAttribute(48, "x", "16");
		builder.AddAttribute(49, "y", "30");
		builder.AddAttribute(50, "width", "12");
		builder.AddAttribute(51, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
