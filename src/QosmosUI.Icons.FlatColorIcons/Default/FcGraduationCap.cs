// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcGraduationCap : ComponentBase
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
		builder.AddAttribute(14, "fill", "#37474F");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "9");
		builder.AddAttribute(17, "y", "20");
		builder.AddAttribute(18, "width", "30");
		builder.AddAttribute(19, "height", "13");
		builder.CloseElement();
		builder.OpenElement(20, "ellipse");
		builder.AddAttribute(21, "cx", "24");
		builder.AddAttribute(22, "cy", "33");
		builder.AddAttribute(23, "rx", "15");
		builder.AddAttribute(24, "ry", "6");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#78909C");
		builder.AddAttribute(27, "d", "M23.1,8.2L0.6,18.1c-0.8,0.4-0.8,1.5,0,1.9l22.5,9.9c0.6,0.2,1.2,0.2,1.8,0l22.5-9.9c0.8-0.4,0.8-1.5,0-1.9 L24.9,8.2C24.3,7.9,23.7,7.9,23.1,8.2z");
		builder.CloseElement();
		builder.OpenElement(28, "g");
		builder.AddAttribute(29, "fill", "#37474F");
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M43.2,20.4l-20-3.4c-0.5-0.1-1.1,0.3-1.2,0.8c-0.1,0.5,0.3,1.1,0.8,1.2L42,22.2V37c0,0.6,0.4,1,1,1 s1-0.4,1-1V21.4C44,20.9,43.6,20.5,43.2,20.4z");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "43");
		builder.AddAttribute(34, "cy", "37");
		builder.AddAttribute(35, "r", "2");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M46,40c0,1.7-3,6-3,6s-3-4.3-3-6s1.3-3,3-3S46,38.3,46,40z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
