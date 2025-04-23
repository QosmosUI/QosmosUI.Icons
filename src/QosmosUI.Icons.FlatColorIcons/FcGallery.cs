// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcGallery : ComponentBase
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
		builder.AddAttribute(14, "fill", "#E65100");
		builder.AddAttribute(15, "d", "M41,42H13c-2.2,0-4-1.8-4-4V18c0-2.2,1.8-4,4-4h28c2.2,0,4,1.8,4,4v20C45,40.2,43.2,42,41,42z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#F57C00");
		builder.AddAttribute(18, "d", "M35,36H7c-2.2,0-4-1.8-4-4V12c0-2.2,1.8-4,4-4h28c2.2,0,4,1.8,4,4v20C39,34.2,37.2,36,35,36z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#FFF9C4");
		builder.AddAttribute(21, "cx", "30");
		builder.AddAttribute(22, "cy", "16");
		builder.AddAttribute(23, "r", "3");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "fill", "#942A09");
		builder.AddAttribute(26, "points", "17,17.9 8,31 26,31");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "fill", "#BF360C");
		builder.AddAttribute(29, "points", "28,23.5 22,31 34,31");
		builder.CloseElement();
		builder.CloseElement();
    }
}
