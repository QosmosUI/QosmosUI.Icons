// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoCodeWorkingSharp : ComponentBase
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
		builder.AddAttribute(15, "cy", "256");
		builder.AddAttribute(16, "r", "26");
		builder.AddAttribute(17, "stroke-linecap", "square");
		builder.AddAttribute(18, "stroke-miterlimit", "10");
		builder.AddAttribute(19, "stroke-width", "10px");
		builder.CloseElement();
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "346");
		builder.AddAttribute(22, "cy", "256");
		builder.AddAttribute(23, "r", "26");
		builder.AddAttribute(24, "stroke-linecap", "square");
		builder.AddAttribute(25, "stroke-miterlimit", "10");
		builder.AddAttribute(26, "stroke-width", "10px");
		builder.CloseElement();
		builder.OpenElement(27, "circle");
		builder.AddAttribute(28, "cx", "166");
		builder.AddAttribute(29, "cy", "256");
		builder.AddAttribute(30, "r", "26");
		builder.AddAttribute(31, "stroke-linecap", "square");
		builder.AddAttribute(32, "stroke-miterlimit", "10");
		builder.AddAttribute(33, "stroke-width", "10px");
		builder.CloseElement();
		builder.OpenElement(34, "polyline");
		builder.AddAttribute(35, "points", "160 368 32 256 160 144");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "square");
		builder.AddAttribute(38, "stroke-miterlimit", "10");
		builder.AddAttribute(39, "stroke-width", "42px");
		builder.CloseElement();
		builder.OpenElement(40, "polyline");
		builder.AddAttribute(41, "points", "352 368 480 256 352 144");
		builder.AddAttribute(42, "fill", "none");
		builder.AddAttribute(43, "stroke-linecap", "square");
		builder.AddAttribute(44, "stroke-miterlimit", "10");
		builder.AddAttribute(45, "stroke-width", "42px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
