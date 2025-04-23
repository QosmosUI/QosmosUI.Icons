// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCameraAddon : ComponentBase
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
		builder.AddAttribute(14, "fill", "#512DA8");
		builder.AddAttribute(15, "d", "M33.9,12.1H14.2L17.6,7c0.4-0.6,1-0.9,1.7-0.9h9.6c0.7,0,1.3,0.3,1.7,0.9L33.9,12.1z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#8667C4");
		builder.AddAttribute(18, "d", "M14,11H8V9.2C8,8.5,8.5,8,9.2,8h3.6C13.5,8,14,8.5,14,9.2V11z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#5E35B1");
		builder.AddAttribute(21, "d", "M40,42H8c-2.2,0-4-1.8-4-4V14c0-2.2,1.8-4,4-4h32c2.2,0,4,1.8,4,4v24C44,40.2,42.2,42,40,42z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "fill", "#512DA8");
		builder.AddAttribute(24, "cx", "24");
		builder.AddAttribute(25, "cy", "26");
		builder.AddAttribute(26, "r", "12");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "fill", "#B388FF");
		builder.AddAttribute(29, "cx", "24");
		builder.AddAttribute(30, "cy", "26");
		builder.AddAttribute(31, "r", "9");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "fill", "#C7A7FF");
		builder.AddAttribute(34, "d", "M28.8,23c-1.2-1.4-3-2.2-4.8-2.2s-3.6,0.8-4.8,2.2c-0.5,0.5-0.4,1.3,0.1,1.8c0.5,0.5,1.3,0.4,1.8-0.1 c1.5-1.7,4.3-1.7,5.8,0c0.3,0.3,0.6,0.4,1,0.4c0.3,0,0.6-0.1,0.9-0.3C29.2,24.4,29.3,23.5,28.8,23z");
		builder.CloseElement();
		builder.OpenElement(35, "ellipse");
		builder.AddAttribute(36, "fill", "#8667C4");
		builder.AddAttribute(37, "cx", "11");
		builder.AddAttribute(38, "cy", "13.5");
		builder.AddAttribute(39, "rx", "2");
		builder.AddAttribute(40, "ry", "1.5");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "fill", "#8BC34A");
		builder.AddAttribute(43, "d", "M48,33.8c0-1.3-1.1-2.4-2.4-2.4H42c-0.4,0-0.7-0.5-0.4-0.8c0.4-0.6,0.5-1.3,0.4-2.1 c-0.2-1.2-1.1-2.1-2.3-2.4C37.7,25.7,36,27.1,36,29c0,0.6,0.2,1.1,0.4,1.6c0.2,0.4,0,0.8-0.5,0.8h-3.6c-1.3,0-2.4,1.1-2.4,2.4V37 c0,0.4,0.5,0.7,0.8,0.4c0.6-0.4,1.3-0.5,2.1-0.4c1.2,0.2,2.1,1.1,2.4,2.3c0.4,1.9-1.1,3.6-2.9,3.6c-0.6,0-1.1-0.2-1.6-0.4 c-0.4-0.2-0.8,0-0.8,0.5v2.6c0,1.3,1.1,2.4,2.4,2.4h13.2c1.3,0,2.4-1.1,2.4-2.4V33.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
