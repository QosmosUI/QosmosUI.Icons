// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiBrightnessUp : ComponentBase
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
		builder.AddAttribute(14, "id", "Brightness_Up");
		builder.AddAttribute(15, "data-name", "Brightness Up");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M12,17.5A5.5,5.5,0,1,1,17.5,12,5.506,5.506,0,0,1,12,17.5Zm0-10A4.5,4.5,0,1,0,16.5,12,4.505,4.505,0,0,0,12,7.5Z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "12");
		builder.AddAttribute(21, "cy", "3.063");
		builder.AddAttribute(22, "r", "1");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "12");
		builder.AddAttribute(25, "cy", "20.937");
		builder.AddAttribute(26, "r", "1");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "20.937");
		builder.AddAttribute(29, "cy", "12");
		builder.AddAttribute(30, "r", "1");
		builder.CloseElement();
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "3.063");
		builder.AddAttribute(33, "cy", "12");
		builder.AddAttribute(34, "r", "1");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "18.319");
		builder.AddAttribute(37, "cy", "5.681");
		builder.AddAttribute(38, "r", "1");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "cx", "5.681");
		builder.AddAttribute(41, "cy", "18.319");
		builder.AddAttribute(42, "r", "1");
		builder.CloseElement();
		builder.OpenElement(43, "circle");
		builder.AddAttribute(44, "cx", "18.319");
		builder.AddAttribute(45, "cy", "18.319");
		builder.AddAttribute(46, "r", "1");
		builder.CloseElement();
		builder.OpenElement(47, "circle");
		builder.AddAttribute(48, "cx", "5.681");
		builder.AddAttribute(49, "cy", "5.681");
		builder.AddAttribute(50, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
