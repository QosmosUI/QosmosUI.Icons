// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoFilterCircleOutline : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "32");
		builder.AddAttribute(16, "stroke-miterlimit", "10");
		builder.AddAttribute(17, "d", "M448,256c0-106-86-192-192-192S64,150,64,256s86,192,192,192S448,362,448,256Z");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "stroke-width", "32");
		builder.AddAttribute(21, "stroke-linecap", "round");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "x1", "144");
		builder.AddAttribute(24, "y1", "208");
		builder.AddAttribute(25, "x2", "368");
		builder.AddAttribute(26, "y2", "208");
		builder.CloseElement();
		builder.OpenElement(27, "line");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-width", "32");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "x1", "176");
		builder.AddAttribute(33, "y1", "272");
		builder.AddAttribute(34, "x2", "336");
		builder.AddAttribute(35, "y2", "272");
		builder.CloseElement();
		builder.OpenElement(36, "line");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-width", "32");
		builder.AddAttribute(39, "stroke-linecap", "round");
		builder.AddAttribute(40, "stroke-linejoin", "round");
		builder.AddAttribute(41, "x1", "224");
		builder.AddAttribute(42, "y1", "336");
		builder.AddAttribute(43, "x2", "288");
		builder.AddAttribute(44, "y2", "336");
		builder.CloseElement();
		builder.CloseElement();
    }
}
