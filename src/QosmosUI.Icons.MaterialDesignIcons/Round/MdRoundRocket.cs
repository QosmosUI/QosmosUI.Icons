// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRocket : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M11.41,2.87c0.35-0.26,0.82-0.26,1.18,0C13.81,3.75,16.5,6.46,16.5,13c0,2.16-0.78,4.76-1.36,6.35 C15,19.74,14.63,20,14.21,20l-4.41,0c-0.42,0-0.8-0.26-0.94-0.65C8.28,17.76,7.5,15.16,7.5,13C7.5,6.46,10.19,3.75,11.41,2.87z M14,11c0-1.1-0.9-2-2-2s-2,0.9-2,2s0.9,2,2,2S14,12.1,14,11z M7.69,20.52c-0.48-1.23-1.52-4.17-1.67-6.87l-1.13,0.75 C4.33,14.78,4,15.4,4,16.07v4.45c0,0.71,0.71,1.19,1.37,0.93L7.69,20.52z M20,20.52v-4.45c0-0.67-0.33-1.29-0.89-1.66l-1.13-0.75 c-0.15,2.69-1.2,5.64-1.67,6.87l2.32,0.93C19.29,21.71,20,21.23,20,20.52z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
