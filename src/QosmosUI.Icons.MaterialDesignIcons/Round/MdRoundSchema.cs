// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSchema : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M14,10.5V11h-3v-0.5C11,9.67,10.33,9,9.5,9h-1V7h1C10.33,7,11,6.33,11,5.5v-3C11,1.67,10.33,1,9.5,1h-4C4.67,1,4,1.67,4,2.5 v3C4,6.33,4.67,7,5.5,7h1v2h-1C4.67,9,4,9.67,4,10.5v3C4,14.33,4.67,15,5.5,15h1v2h-1C4.67,17,4,17.67,4,18.5v3 C4,22.33,4.67,23,5.5,23h4c0.83,0,1.5-0.67,1.5-1.5v-3c0-0.83-0.67-1.5-1.5-1.5h-1v-2h1c0.83,0,1.5-0.67,1.5-1.5V13h3v0.5 c0,0.83,0.67,1.5,1.5,1.5h4c0.83,0,1.5-0.67,1.5-1.5v-3C21,9.67,20.33,9,19.5,9h-4C14.67,9,14,9.67,14,10.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
