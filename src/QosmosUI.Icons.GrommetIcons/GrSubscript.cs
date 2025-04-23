// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrSubscript : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M18.74,3.63l.19,4.07h-.49a4.92,4.92,0,0,0-.38-1.54A2.58,2.58,0,0,0,17,5.07a3.68,3.68,0,0,0-1.73-.35H12.83V18a3.54,3.54,0,0,0,.35,2,1.92,1.92,0,0,0,1.5.54h.6V21H7.92V20.5h.61a1.76,1.76,0,0,0,1.56-.67A3.88,3.88,0,0,0,10.38,18V4.72H8.29a5.79,5.79,0,0,0-1.73.18,2.37,2.37,0,0,0-1.14.93A3.78,3.78,0,0,0,4.86,7.7H4.38l.21-4.07Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M22.48,16.68h.33v5.59a1.13,1.13,0,0,0,.06.4.41.41,0,0,0,.17.21.63.63,0,0,0,.28.08h.4v.27H20.76V23l.45,0a.62.62,0,0,0,.29-.1.38.38,0,0,0,.15-.22,1.4,1.4,0,0,0,0-.37V18.42a4.45,4.45,0,0,0,0-.64c0-.15-.1-.23-.24-.23a.82.82,0,0,0-.28,0l-.3.13-.18-.25Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
