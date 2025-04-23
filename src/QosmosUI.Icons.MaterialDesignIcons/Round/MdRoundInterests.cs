// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundInterests : ComponentBase
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
		builder.AddAttribute(18, "d", "M7.02,13c-2.21,0-4,1.79-4,4s1.79,4,4,4s4-1.79,4-4S9.23,13,7.02,13z M13,14v6c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1v-6 c0-0.55-0.45-1-1-1h-6C13.45,13,13,13.45,13,14z M6.13,3.57l-3.3,5.94C2.46,10.18,2.94,11,3.7,11h6.6c0.76,0,1.24-0.82,0.87-1.49 l-3.3-5.94C7.49,2.89,6.51,2.89,6.13,3.57z M19.25,2.5c-1.06,0-1.81,0.56-2.25,1.17c-0.44-0.61-1.19-1.17-2.25-1.17 C13.19,2.5,12,3.78,12,5.25c0,1.83,2.03,3.17,4.35,5.18c0.37,0.32,0.92,0.32,1.3,0C19.97,8.42,22,7.08,22,5.25 C22,3.78,20.81,2.5,19.25,2.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
