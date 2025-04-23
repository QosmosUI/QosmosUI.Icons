// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcReuse : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#455A64");
		builder.AddAttribute(15, "points", "12.1,42 17.2,42 16.5,18.2 10.9,20.2");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "fill", "#FFB74D");
		builder.AddAttribute(18, "cx", "36.5");
		builder.AddAttribute(19, "cy", "10");
		builder.AddAttribute(20, "r", "5");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "fill", "#607D8B");
		builder.AddAttribute(23, "points", "11,42 6,42 7.8,18.6 14.2,20.9");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "fill", "#607D8B");
		builder.AddAttribute(26, "d", "M31.7,15.9c-0.6-2-1.3-4-2.5-5.8c-1.3-1.6-3.2-3.1-6.1-2c-3.1,1.3-9.2,3.6-11.2,4.5 c-2.3,1.1-4.1,2.7-4.1,5.9c0,3.4,4.3,5.3,4.3,5.3l14.7-6.1l1.7,4.5l5.3,0.1C33.8,22.4,32.3,17.9,31.7,15.9z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "fill", "#B39DDB");
		builder.AddAttribute(29, "d", "M37.9,42h-7.9c-1,0-1.8-0.7-2-1.7l-2.6-17.1h17l-2.6,17.1C39.8,41.3,38.9,42,37.9,42z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "fill", "#7E57C2");
		builder.AddAttribute(32, "d", "M42,24H26c-0.6,0-1-0.4-1-1v0c0-0.6,0.4-1,1-1h16c0.6,0,1,0.4,1,1v0C43,23.6,42.6,24,42,24z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
