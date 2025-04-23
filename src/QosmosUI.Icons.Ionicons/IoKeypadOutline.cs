// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoKeypadOutline : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "cx", "256");
		builder.AddAttribute(15, "cy", "448");
		builder.AddAttribute(16, "r", "32");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "stroke-miterlimit", "10");
		builder.AddAttribute(19, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "256");
		builder.AddAttribute(22, "cy", "320");
		builder.AddAttribute(23, "r", "32");
		builder.AddAttribute(24, "fill", "none");
		builder.AddAttribute(25, "stroke-miterlimit", "10");
		builder.AddAttribute(26, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M288,192a32,32,0,1,1-32-32A32,32,0,0,1,288,192Z");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-miterlimit", "10");
		builder.AddAttribute(31, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "256");
		builder.AddAttribute(34, "cy", "64");
		builder.AddAttribute(35, "r", "32");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-miterlimit", "10");
		builder.AddAttribute(38, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "cx", "384");
		builder.AddAttribute(41, "cy", "320");
		builder.AddAttribute(42, "r", "32");
		builder.AddAttribute(43, "fill", "none");
		builder.AddAttribute(44, "stroke-miterlimit", "10");
		builder.AddAttribute(45, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(46, "circle");
		builder.AddAttribute(47, "cx", "384");
		builder.AddAttribute(48, "cy", "192");
		builder.AddAttribute(49, "r", "32");
		builder.AddAttribute(50, "fill", "none");
		builder.AddAttribute(51, "stroke-miterlimit", "10");
		builder.AddAttribute(52, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(53, "circle");
		builder.AddAttribute(54, "cx", "384");
		builder.AddAttribute(55, "cy", "64");
		builder.AddAttribute(56, "r", "32");
		builder.AddAttribute(57, "fill", "none");
		builder.AddAttribute(58, "stroke-miterlimit", "10");
		builder.AddAttribute(59, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(60, "circle");
		builder.AddAttribute(61, "cx", "128");
		builder.AddAttribute(62, "cy", "320");
		builder.AddAttribute(63, "r", "32");
		builder.AddAttribute(64, "fill", "none");
		builder.AddAttribute(65, "stroke-miterlimit", "10");
		builder.AddAttribute(66, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(67, "circle");
		builder.AddAttribute(68, "cx", "128");
		builder.AddAttribute(69, "cy", "192");
		builder.AddAttribute(70, "r", "32");
		builder.AddAttribute(71, "fill", "none");
		builder.AddAttribute(72, "stroke-miterlimit", "10");
		builder.AddAttribute(73, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(74, "circle");
		builder.AddAttribute(75, "cx", "128");
		builder.AddAttribute(76, "cy", "64");
		builder.AddAttribute(77, "r", "32");
		builder.AddAttribute(78, "fill", "none");
		builder.AddAttribute(79, "stroke-miterlimit", "10");
		builder.AddAttribute(80, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
