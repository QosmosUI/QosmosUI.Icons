// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCopyleft : ComponentBase
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
		builder.AddAttribute(20, "d", "M19.3,28.1c0.3,1.3,0.2,4.1,4.6,4.1c0.9,0,4.8,0.2,4.7-7.2v-1.6c0-6.7-3.2-7.2-4.8-7.2 c-2.3,0-4.2,0.6-4.5,4.3h-4.8c0.1-1.2,0.8-8.2,9.3-8.2c4.2,0,9.7,2.5,9.7,11.2V25c0,9.6-6.5,11.2-9.6,11.2c-3.7,0-8.7-1.6-9.3-8.1 H19.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
