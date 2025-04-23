// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFreeCancellation : ComponentBase
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
		builder.AddAttribute(18, "d", "M10.79,20H5V10h14v2.96c0,0.89,1.08,1.34,1.71,0.71l0,0c0.19-0.19,0.29-0.44,0.29-0.71V6c0-1.1-0.9-2-2-2h-1V3 c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v1H8V3c0-0.55-0.45-1-1-1h0C6.45,2,6,2.45,6,3v1H5C3.89,4,3.01,4.9,3.01,6L3,20 c0,1.1,0.89,2,2,2h5.79c0.89,0,1.34-1.08,0.71-1.71l0,0C11.31,20.11,11.06,20,10.79,20z M13.71,18.26c0.39-0.39,1.02-0.39,1.41,0 l1.41,1.41l3.54-3.54c0.39-0.39,1.02-0.39,1.41,0c0.39,0.39,0.39,1.02,0,1.41l-4.24,4.24c-0.39,0.39-1.02,0.39-1.41,0l-2.12-2.12 C13.32,19.28,13.32,18.65,13.71,18.26z M11.29,16.29c-0.39,0.39-1.02,0.39-1.41,0L9,15.41l-0.88,0.88c-0.39,0.39-1.02,0.39-1.41,0 s-0.39-1.02,0-1.41L7.59,14l-0.88-0.88c-0.39-0.39-0.39-1.02,0-1.41s1.02-0.39,1.41,0L9,12.59l0.88-0.88c0.39-0.39,1.02-0.39,1.41,0 s0.39,1.02,0,1.41L10.41,14l0.88,0.88C11.68,15.27,11.68,15.9,11.29,16.29z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
