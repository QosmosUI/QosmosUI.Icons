// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCalculator1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Calculator_1");
		builder.AddAttribute(15, "data-name", "Calculator 1");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M16.5,21.937h-9a2.5,2.5,0,0,1-2.5-2.5V4.563a2.5,2.5,0,0,1,2.5-2.5h9a2.5,2.5,0,0,1,2.5,2.5V19.437A2.5,2.5,0,0,1,16.5,21.937ZM7.5,3.063A1.5,1.5,0,0,0,6,4.563V19.437a1.5,1.5,0,0,0,1.5,1.5h9a1.5,1.5,0,0,0,1.5-1.5V4.563a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14.5,9.757h-5A1.5,1.5,0,0,1,8,8.257V6.563a1.5,1.5,0,0,1,1.5-1.5h5a1.5,1.5,0,0,1,1.5,1.5V8.257A1.5,1.5,0,0,1,14.5,9.757Zm-5-3.694a.5.5,0,0,0-.5.5V8.257a.5.5,0,0,0,.5.5h5a.5.5,0,0,0,.5-.5V6.563a.5.5,0,0,0-.5-.5Z");
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "12");
		builder.AddAttribute(24, "cy", "11.508");
		builder.AddAttribute(25, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "15.25");
		builder.AddAttribute(28, "cy", "11.508");
		builder.AddAttribute(29, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "8.75");
		builder.AddAttribute(32, "cy", "11.508");
		builder.AddAttribute(33, "r", "0.75");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(34, "g");
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "12");
		builder.AddAttribute(37, "cy", "14.848");
		builder.AddAttribute(38, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "cx", "15.25");
		builder.AddAttribute(41, "cy", "14.848");
		builder.AddAttribute(42, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "cx", "8.75");
		builder.AddAttribute(45, "cy", "14.848");
		builder.AddAttribute(46, "r", "0.75");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(47, "g");
		builder.OpenElement(48, "circle");
		builder.AddAttribute(49, "cx", "15.25");
		builder.AddAttribute(50, "cy", "18.187");
		builder.AddAttribute(51, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(52, "path");
		builder.AddAttribute(53, "d", "M12.248,18.687H8.5a.5.5,0,0,1,0-1h3.744a.5.5,0,1,1,0,1Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
