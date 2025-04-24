// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoGameControllerOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M467.51,248.83c-18.4-83.18-45.69-136.24-89.43-149.17A91.5,91.5,0,0,0,352,96c-26.89,0-48.11,16-96,16s-69.15-16-96-16a99.09,99.09,0,0,0-27.2,3.66C89,112.59,61.94,165.7,43.33,248.83c-19,84.91-15.56,152,21.58,164.88,26,9,49.25-9.61,71.27-37,25-31.2,55.79-40.8,119.82-40.8s93.62,9.6,118.66,40.8c22,27.41,46.11,45.79,71.42,37.16C487.1,399.86,486.52,334.74,467.51,248.83Z");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-miterlimit", "10");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "292");
		builder.AddAttribute(20, "cy", "224");
		builder.AddAttribute(21, "r", "20");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M336,288a20,20,0,1,1,20-19.95A20,20,0,0,1,336,288Z");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "336");
		builder.AddAttribute(26, "cy", "180");
		builder.AddAttribute(27, "r", "20");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "380");
		builder.AddAttribute(30, "cy", "224");
		builder.AddAttribute(31, "r", "20");
		builder.CloseElement();
		builder.OpenElement(32, "line");
		builder.AddAttribute(33, "x1", "160");
		builder.AddAttribute(34, "y1", "176");
		builder.AddAttribute(35, "x2", "160");
		builder.AddAttribute(36, "y2", "272");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(41, "line");
		builder.AddAttribute(42, "x1", "208");
		builder.AddAttribute(43, "y1", "224");
		builder.AddAttribute(44, "x2", "112");
		builder.AddAttribute(45, "y2", "224");
		builder.AddAttribute(46, "fill", "none");
		builder.AddAttribute(47, "stroke-linecap", "round");
		builder.AddAttribute(48, "stroke-linejoin", "round");
		builder.AddAttribute(49, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
