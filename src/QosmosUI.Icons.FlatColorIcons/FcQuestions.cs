// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcQuestions : ComponentBase
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
		builder.AddAttribute(14, "fill", "#42A5F5");
		builder.AddAttribute(15, "points", "36,44 8,44 8,8 28,8 36,16");
		builder.CloseElement();
		builder.OpenElement(16, "polygon");
		builder.AddAttribute(17, "fill", "#90CAF9");
		builder.AddAttribute(18, "points", "40,40 12,40 12,4 32,4 40,12");
		builder.CloseElement();
		builder.OpenElement(19, "polygon");
		builder.AddAttribute(20, "fill", "#E1F5FE");
		builder.AddAttribute(21, "points", "38.5,13 31,13 31,5.5");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#1976D2");
		builder.AddAttribute(24, "d", "M24.5,28.3c0-4.7,3.6-4.4,3.6-7.2c0-0.7-0.2-2.1-2-2.1c-2,0-2.1,1.6-2.1,2h-2.7c0-0.7,0.3-4.2,4.8-4.2 c4.6,0,4.7,3.6,4.7,4.3c0,3.5-3.8,4-3.8,7.3H24.5z M24.3,31.8c0-0.2,0-1.5,1.5-1.5c1.4,0,1.5,1.3,1.5,1.5c0,0.4-0.2,1.4-1.5,1.4 C24.5,33.2,24.3,32.2,24.3,31.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
