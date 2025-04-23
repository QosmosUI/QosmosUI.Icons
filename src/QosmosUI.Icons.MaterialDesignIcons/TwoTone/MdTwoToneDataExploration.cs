// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDataExploration : ComponentBase
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
		builder.AddAttribute(18, "d", "M12,20c-2.89,0-5.43-1.54-6.83-3.84l2.95-2.95L11.41,16L16,11.42V13h2V8h-5v2h1.58l-3.28,3.28L8,10.5 l-3.69,3.7C4.11,13.5,4,12.76,4,12c0-4.41,3.59-8,8-8s8,3.59,8,8S16.41,20,12,20z M19.5,20.5c-0.55,0-1-0.45-1-1s0.45-1,1-1 s1,0.45,1,1S20.05,20.5,19.5,20.5z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,2C6.48,2,2,6.48,2,12s4.48,10,10,10h8c1.1,0,2-0.9,2-2v-8C22,6.48,17.52,2,12,2z M12,20c-2.89,0-5.43-1.54-6.83-3.84 l2.95-2.95L11.41,16L16,11.42V13h2V8h-5v2h1.58l-3.28,3.28L8,10.5l-3.69,3.7C4.11,13.5,4,12.76,4,12c0-4.41,3.59-8,8-8s8,3.59,8,8 S16.41,20,12,20z M19.5,20.5c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S20.05,20.5,19.5,20.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
