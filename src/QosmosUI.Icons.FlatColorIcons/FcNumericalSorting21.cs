// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcNumericalSorting21 : ComponentBase
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
		builder.AddAttribute(14, "fill", "#546E7A");
		builder.AddAttribute(15, "points", "38,33 38,5 34,5 34,33 28,33 36,43 44,33");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#2196F3");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M19.2,20H9v-2l4.8-5.1c0.4-0.4,0.7-0.8,0.9-1.1c0.2-0.3,0.5-0.6,0.6-0.9c0.2-0.3,0.3-0.5,0.3-0.8 c0.1-0.2,0.1-0.5,0.1-0.7c0-0.7-0.2-1.2-0.5-1.6c-0.3-0.4-0.8-0.6-1.4-0.6c-0.3,0-0.7,0.1-0.9,0.2c-0.3,0.1-0.5,0.3-0.7,0.5 c-0.2,0.2-0.3,0.5-0.4,0.8s-0.1,0.6-0.1,1h-3c0-0.7,0.1-1.3,0.4-1.9c0.2-0.6,0.6-1.1,1-1.6c0.5-0.4,1-0.8,1.6-1.1 c0.6-0.3,1.4-0.4,2.2-0.4c0.8,0,1.5,0.1,2.1,0.3c0.6,0.2,1.1,0.5,1.5,0.8s0.7,0.8,0.9,1.3c0.2,0.5,0.3,1.1,0.3,1.8 c0,0.5-0.1,1-0.2,1.4s-0.4,0.9-0.7,1.4s-0.6,0.9-1,1.4c-0.4,0.5-0.9,1-1.4,1.5l-2.6,2.8h6.4V20z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M16.2,43h-3V31.6l-3.5,1.1v-2.4l6.2-2.2h0.3V43z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
