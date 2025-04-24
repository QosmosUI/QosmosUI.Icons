// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcEditImage : ComponentBase
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
		builder.AddAttribute(14, "fill", "#8CBCD6");
		builder.AddAttribute(15, "d", "M31,41H8c-2.2,0-4-1.8-4-4V11c0-2.2,1.8-4,4-4h32c2.2,0,4,1.8,4,4v17C44,35.2,38.2,41,31,41z");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "fill", "#B3DDF5");
		builder.AddAttribute(18, "cx", "35");
		builder.AddAttribute(19, "cy", "16");
		builder.AddAttribute(20, "r", "3");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "fill", "#9AC9E3");
		builder.AddAttribute(23, "points", "20,16 9,32 31,32");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "fill", "#B3DDF5");
		builder.AddAttribute(26, "points", "31,22 23,32 39,32");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "fill", "#E57373");
		builder.AddAttribute(29, "d", "M47.7,29.1l-2.8-2.8c-0.4-0.4-1.1-0.4-1.6,0L42,27.6l4.4,4.4l1.3-1.3C48.1,30.3,48.1,29.6,47.7,29.1z");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "x", "27.1");
		builder.AddAttribute(32, "y", "35.1");
		builder.AddAttribute(33, "transform", "matrix(.707 -.707 .707 .707 -16.508 36.511)");
		builder.AddAttribute(34, "fill", "#FF9800");
		builder.AddAttribute(35, "width", "17.4");
		builder.AddAttribute(36, "height", "6.2");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "41.5");
		builder.AddAttribute(39, "y", "27.8");
		builder.AddAttribute(40, "transform", "matrix(-.707 .707 -.707 -.707 95.395 22.352)");
		builder.AddAttribute(41, "fill", "#B0BEC5");
		builder.AddAttribute(42, "width", "3.1");
		builder.AddAttribute(43, "height", "6.2");
		builder.CloseElement();
		builder.OpenElement(44, "polygon");
		builder.AddAttribute(45, "fill", "#FFC107");
		builder.AddAttribute(46, "points", "27.5,42.2 26,48 31.8,46.5");
		builder.CloseElement();
		builder.OpenElement(47, "polygon");
		builder.AddAttribute(48, "fill", "#37474F");
		builder.AddAttribute(49, "points", "26.7,45 26,48 29,47.3");
		builder.CloseElement();
		builder.CloseElement();
    }
}
