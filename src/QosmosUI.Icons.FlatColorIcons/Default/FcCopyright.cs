// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcCopyright : ComponentBase
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
		builder.AddAttribute(20, "d", "M33.5,28.1c-0.6,6.4-5.6,8.1-9.3,8.1c-3.1,0-9.6-1.6-9.6-11.2v-1.5c0-8.7,5.5-11.2,9.7-11.2 c8.5,0,9.2,7,9.3,8.2h-4.8c-0.3-3.6-2.2-4.3-4.5-4.3c-1.6,0-4.8,0.5-4.8,7.2V25c-0.1,7.5,3.8,7.2,4.7,7.2c4.3,0,4.3-2.9,4.6-4.1 H33.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
