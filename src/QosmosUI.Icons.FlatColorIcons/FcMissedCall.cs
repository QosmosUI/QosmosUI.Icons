// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcMissedCall : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#F44336");
		builder.OpenElement(15, "polygon");
		builder.AddAttribute(16, "points", "30.3,12.9 24,19.2 15.7,10.9 12.9,13.7 24,24.8 33.1,15.7");
		builder.CloseElement();
		builder.OpenElement(17, "polygon");
		builder.AddAttribute(18, "points", "36,19 27,10 36,10");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#009688");
		builder.AddAttribute(21, "d", "M44.5,30.8l-2.4-2.4c-8.5-8.3-28.9-7.1-36.2,0l-2.4,2.4c-0.7,0.7-0.7,1.7,0,2.4l4.8,4.7 c0.7,0.7,1.7,0.7,2.4,0l5.3-5.1l-0.4-5.6c1.7-1.7,15.1-1.7,16.8,0L32.1,33l5.1,4.9c0.7,0.7,1.7,0.7,2.4,0l4.8-4.7 C45.2,32.5,45.2,31.4,44.5,30.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
