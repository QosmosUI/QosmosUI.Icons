// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcRegisteredTrademark : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "fill", "#9C27B0");
		builder.AddAttribute(15, "cx", "24");
		builder.AddAttribute(16, "cy", "24");
		builder.AddAttribute(17, "r", "21");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "fill", "#E1BEE7");
		builder.AddAttribute(20, "d", "M25,26.8h-4.5v9h-4V12.5h8.2c1.3,0,2.5,0.2,3.6,0.5c1,0.3,1.9,0.8,2.6,1.3c0.7,0.6,1.3,1.3,1.6,2.2 s0.6,1.9,0.6,3c0,1.6-0.4,2.9-1.1,3.9c-0.8,1-1.8,1.9-3.1,2.4l5.2,9.7v0.2h-4.3L25,26.8z M20.5,23.6h4.2c0.7,0,1.4-0.1,1.9-0.3 c0.5-0.2,1-0.5,1.4-0.8c0.4-0.3,0.6-0.7,0.8-1.2c0.2-0.5,0.3-1,0.3-1.6c0-0.6-0.1-1.1-0.3-1.6c-0.2-0.5-0.4-0.9-0.8-1.2 c-0.4-0.3-0.8-0.6-1.4-0.8c-0.5-0.2-1.2-0.3-2-0.3h-4.1V23.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
