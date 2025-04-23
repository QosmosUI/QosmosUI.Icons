// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdHub : ComponentBase
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
		builder.AddAttribute(18, "d", "M8.4,18.2C8.78,18.7,9,19.32,9,20c0,1.66-1.34,3-3,3s-3-1.34-3-3s1.34-3,3-3c0.44,0,0.85,0.09,1.23,0.26l1.41-1.77 c-0.92-1.03-1.29-2.39-1.09-3.69l-2.03-0.68C4.98,11.95,4.06,12.5,3,12.5c-1.66,0-3-1.34-3-3s1.34-3,3-3s3,1.34,3,3 c0,0.07,0,0.14-0.01,0.21l2.03,0.68c0.64-1.21,1.82-2.09,3.22-2.32l0-2.16C9.96,5.57,9,4.4,9,3c0-1.66,1.34-3,3-3s3,1.34,3,3 c0,1.4-0.96,2.57-2.25,2.91v2.16c1.4,0.23,2.58,1.11,3.22,2.32l2.03-0.68C18,9.64,18,9.57,18,9.5c0-1.66,1.34-3,3-3s3,1.34,3,3 s-1.34,3-3,3c-1.06,0-1.98-0.55-2.52-1.37l-2.03,0.68c0.2,1.29-0.16,2.65-1.09,3.69l1.41,1.77C17.15,17.09,17.56,17,18,17 c1.66,0,3,1.34,3,3s-1.34,3-3,3s-3-1.34-3-3c0-0.68,0.22-1.3,0.6-1.8l-1.41-1.77c-1.35,0.75-3.01,0.76-4.37,0L8.4,18.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
