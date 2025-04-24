// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcPanorama : ComponentBase
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
		builder.AddAttribute(14, "fill", "#F57C00");
		builder.AddAttribute(15, "d", "M4,9v32c0,0,8.4-3,20-3s20,3,20,3V9c0,0-6.7,3-20,3S4,9,4,9z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#942A09");
		builder.AddAttribute(18, "d", "M24,34c0.1,0,0.3,0,0.4,0L15,19L6.9,36.2C10.3,35.3,16.5,34,24,34z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#BF360C");
		builder.AddAttribute(21, "d", "M24,34c3.3,0,6.3,0.2,9,0.6l-8-11.8l-7.8,11.5C19.3,34.1,21.6,34,24,34z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#E65100");
		builder.AddAttribute(24, "d", "M40.7,36L35,26.5l-5,7.8C34.5,34.7,38.2,35.4,40.7,36z");
		builder.CloseElement();
		builder.OpenElement(25, "ellipse");
		builder.AddAttribute(26, "fill", "#FFF9C4");
		builder.AddAttribute(27, "cx", "36");
		builder.AddAttribute(28, "cy", "19.5");
		builder.AddAttribute(29, "rx", "2");
		builder.AddAttribute(30, "ry", "2.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
