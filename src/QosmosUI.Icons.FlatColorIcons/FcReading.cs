// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcReading : ComponentBase
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
		builder.AddAttribute(14, "fill", "#5C6BC0");
		builder.AddAttribute(15, "d", "M40,40c-6.9,0-16,4-16,4V22c0,0,9-4,18-4L40,40z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#7986CB");
		builder.AddAttribute(18, "d", "M8,40c6.9,0,16,4,16,4V22c0,0-9-4-18-4L8,40z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#FFB74D");
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "24");
		builder.AddAttribute(23, "cy", "12");
		builder.AddAttribute(24, "r", "8");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M41,32h1c0.6,0,1-0.4,1-1v-4c0-0.6-0.4-1-1-1h-1c-1.7,0-3,1.3-3,3v0C38,30.7,39.3,32,41,32z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M7,26H6c-0.6,0-1,0.4-1,1v4c0,0.6,0.4,1,1,1h1c1.7,0,3-1.3,3-3v0C10,27.3,8.7,26,7,26z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
