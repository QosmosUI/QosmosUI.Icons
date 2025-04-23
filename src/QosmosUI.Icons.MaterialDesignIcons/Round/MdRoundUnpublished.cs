// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundUnpublished : ComponentBase
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
		builder.AddAttribute(18, "d", "M20.49,20.49L3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0l0,0c-0.39,0.39-0.39,1.02,0,1.41l1.56,1.56 c-1.25,1.88-1.88,4.21-1.59,6.7c0.53,4.54,4.21,8.22,8.74,8.74c2.49,0.29,4.81-0.34,6.7-1.59l1.56,1.56c0.39,0.39,1.02,0.39,1.41,0 l0,0C20.88,21.51,20.88,20.88,20.49,20.49z M9.88,15.89l-2.83-2.83c-0.39-0.39-0.39-1.02,0-1.41l0,0c0.39-0.39,1.02-0.39,1.41,0 l2.12,2.12l0.18-0.18l1.41,1.41l-0.88,0.88C10.9,16.28,10.27,16.28,9.88,15.89z M13.59,10.76l-7.1-7.1c1.88-1.25,4.21-1.88,6.7-1.59 c4.54,0.53,8.22,4.21,8.74,8.74c0.29,2.49-0.34,4.82-1.59,6.7l-5.34-5.34l1.94-1.94c0.39-0.39,0.39-1.02,0-1.41v0 c-0.39-0.39-1.02-0.39-1.41,0L13.59,10.76z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
