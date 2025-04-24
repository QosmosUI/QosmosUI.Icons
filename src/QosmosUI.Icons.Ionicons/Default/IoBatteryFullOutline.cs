// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBatteryFullOutline : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "32");
		builder.AddAttribute(15, "y", "144");
		builder.AddAttribute(16, "width", "400");
		builder.AddAttribute(17, "height", "224");
		builder.AddAttribute(18, "rx", "45.7");
		builder.AddAttribute(19, "ry", "45.7");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "square");
		builder.AddAttribute(22, "stroke-miterlimit", "10");
		builder.AddAttribute(23, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "85.69");
		builder.AddAttribute(26, "y", "198.93");
		builder.AddAttribute(27, "width", "292.63");
		builder.AddAttribute(28, "height", "114.14");
		builder.AddAttribute(29, "rx", "4");
		builder.AddAttribute(30, "ry", "4");
		builder.AddAttribute(31, "stroke-linecap", "square");
		builder.AddAttribute(32, "stroke-miterlimit", "10");
		builder.AddAttribute(33, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(34, "line");
		builder.AddAttribute(35, "x1", "480");
		builder.AddAttribute(36, "y1", "218.67");
		builder.AddAttribute(37, "x2", "480");
		builder.AddAttribute(38, "y2", "293.33");
		builder.AddAttribute(39, "fill", "none");
		builder.AddAttribute(40, "stroke-linecap", "round");
		builder.AddAttribute(41, "stroke-miterlimit", "10");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
