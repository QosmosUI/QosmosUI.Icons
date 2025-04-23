// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundEventRepeat : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M21,12V6c0-1.1-0.9-2-2-2h-1V3c0-0.55-0.45-1-1-1s-1,0.45-1,1v1H8V3c0-0.55-0.45-1-1-1S6,2.45,6,3v1H5C3.9,4,3,4.9,3,6v14 c0,1.1,0.9,2,2,2h7v-2H5V10h14v2H21z M15.13,20c-0.55,0-0.91,0.56-0.68,1.06C15.23,22.79,16.97,24,19,24c2.76,0,5-2.24,5-5 s-2.24-5-5-5c-1.36,0-2.6,0.55-3.5,1.43l0-0.68c0-0.41-0.34-0.75-0.75-0.75h0C14.34,14,14,14.34,14,14.75V17c0,0.55,0.45,1,1,1 h2.25c0.41,0,0.75-0.34,0.75-0.75v0c0-0.41-0.34-0.75-0.75-0.75l-0.7,0c0.63-0.62,1.5-1,2.45-1c1.93,0,3.5,1.57,3.5,3.5 s-1.57,3.5-3.5,3.5c-1.42,0-2.64-0.85-3.19-2.06C15.69,20.17,15.42,20,15.13,20z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
