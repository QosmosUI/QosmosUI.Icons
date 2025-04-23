// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiKeyboard : ComponentBase
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
		builder.AddAttribute(14, "id", "Keyboard");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19.437,18.5H4.562a2.5,2.5,0,0,1-2.5-2.5V8a2.5,2.5,0,0,1,2.5-2.5H19.437a2.5,2.5,0,0,1,2.5,2.5v8A2.5,2.5,0,0,1,19.437,18.5ZM4.562,6.5A1.5,1.5,0,0,0,3.062,8v8a1.5,1.5,0,0,0,1.5,1.5H19.437a1.5,1.5,0,0,0,1.5-1.5V8a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M5.548,16.5h12.9a.5.5,0,0,0,0-1H5.548a.5.5,0,0,0,0,1Z");
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "5.82");
		builder.AddAttribute(23, "cy", "9.248");
		builder.AddAttribute(24, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "9.94");
		builder.AddAttribute(27, "cy", "9.248");
		builder.AddAttribute(28, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "cx", "14.06");
		builder.AddAttribute(31, "cy", "9.248");
		builder.AddAttribute(32, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "18.18");
		builder.AddAttribute(35, "cy", "9.248");
		builder.AddAttribute(36, "r", "0.75");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(37, "g");
		builder.OpenElement(38, "circle");
		builder.AddAttribute(39, "cx", "5.82");
		builder.AddAttribute(40, "cy", "12.998");
		builder.AddAttribute(41, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "cx", "9.94");
		builder.AddAttribute(44, "cy", "12.998");
		builder.AddAttribute(45, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "14.06");
		builder.AddAttribute(48, "cy", "12.998");
		builder.AddAttribute(49, "r", "0.75");
		builder.CloseElement();
		builder.OpenElement(50, "circle");
		builder.AddAttribute(51, "cx", "18.18");
		builder.AddAttribute(52, "cy", "12.998");
		builder.AddAttribute(53, "r", "0.75");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
