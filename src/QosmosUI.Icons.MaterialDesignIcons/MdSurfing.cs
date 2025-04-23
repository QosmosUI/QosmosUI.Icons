// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdSurfing : ComponentBase
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
		builder.AddAttribute(18, "d", "M21,23c-1.03,0-2.06-0.25-3-0.75h0c-1.89,1-4.11,1-6,0c-1.89,1-4.11,1-6,0C5.05,22.75,4.03,23,3,23H2l0-2h1 c1.04,0,2.08-0.35,3-1c1.83,1.3,4.17,1.3,6,0c1.83,1.3,4.17,1.3,6,0c0.91,0.65,1.96,1,3,1h1v2H21z M17,1.5c-1.1,0-2,0.9-2,2 s0.9,2,2,2s2-0.9,2-2S18.1,1.5,17,1.5z M14.43,8.48L12.18,10L16,13v3.84c0.53,0.38,1.03,0.78,1.49,1.17C16.81,18.59,15.94,19,15,19 c-1.2,0-2.27-0.66-3-1.5c-0.73,0.84-1.8,1.5-3,1.5c-0.33,0-0.65-0.05-0.96-0.14C5.19,16.9,3,14.72,3,13.28C3,12.25,4.01,12,4.85,12 c0.98,0,2.28,0.31,3.7,0.83l-0.53-3.1C7.91,9.06,8.2,8.35,8.8,7.94l2.15-1.45l-2-0.37L6.13,8.05L5,6.4L8.5,4l5.55,1.03 c0.45,0.09,0.93,0.37,1.22,0.89l0.88,1.55C17.01,8.98,18.64,10,20.5,10v2C17.91,12,15.64,10.58,14.43,8.48z M10.3,11.1l0.44,2.65 c0.92,0.42,2.48,1.27,3.26,1.75V14L10.3,11.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
