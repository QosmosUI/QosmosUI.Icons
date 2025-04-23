// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdFitbit : ComponentBase
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
		builder.AddAttribute(18, "d", "M19.89,13.89c1.04,0,1.89-0.85,1.89-1.89s-0.85-1.89-1.89-1.89C18.85,10.11,18,10.96,18,12S18.85,13.89,19.89,13.89z M15.65,13.68c0.93,0,1.68-0.75,1.68-1.68s-0.75-1.68-1.68-1.68c-0.93,0-1.68,0.75-1.68,1.68S14.72,13.68,15.65,13.68z M15.65,9.42 c0.93,0,1.68-0.75,1.68-1.68c0-0.93-0.75-1.68-1.68-1.68c-0.93,0-1.68,0.75-1.68,1.68C13.97,8.67,14.72,9.42,15.65,9.42z M15.65,17.93c0.93,0,1.68-0.75,1.68-1.68c0-0.93-0.75-1.68-1.68-1.68c-0.93,0-1.68,0.75-1.68,1.68 C13.97,17.17,14.72,17.93,15.65,17.93z M11.41,13.47c0.81,0,1.47-0.66,1.47-1.47s-0.66-1.47-1.47-1.47c-0.81,0-1.47,0.66-1.47,1.47 S10.59,13.47,11.41,13.47z M11.41,9.21c0.81,0,1.47-0.66,1.47-1.47s-0.66-1.47-1.47-1.47c-0.81,0-1.47,0.66-1.47,1.47 S10.59,9.21,11.41,9.21z M11.41,17.73c0.81,0,1.47-0.66,1.47-1.47c0-0.81-0.66-1.47-1.47-1.47c-0.81,0-1.47,0.66-1.47,1.47 C9.93,17.07,10.59,17.73,11.41,17.73z M11.41,22c0.81,0,1.47-0.66,1.47-1.47c0-0.81-0.66-1.47-1.47-1.47 c-0.81,0-1.47,0.66-1.47,1.47C9.93,21.34,10.59,22,11.41,22z M11.41,4.94c0.81,0,1.47-0.66,1.47-1.47S12.22,2,11.41,2 c-0.81,0-1.47,0.66-1.47,1.47S10.59,4.94,11.41,4.94z M7.16,13.26c0.7,0,1.26-0.57,1.26-1.26s-0.57-1.26-1.26-1.26 c-0.7,0-1.26,0.57-1.26,1.26S6.46,13.26,7.16,13.26z M7.16,17.51c0.7,0,1.26-0.57,1.26-1.26c0-0.7-0.57-1.26-1.26-1.26 c-0.7,0-1.26,0.57-1.26,1.26C5.9,16.94,6.46,17.51,7.16,17.51z M7.16,9.02c0.7,0,1.26-0.57,1.26-1.26c0-0.7-0.57-1.26-1.26-1.26 c-0.7,0-1.26,0.57-1.26,1.26C5.9,8.45,6.46,9.02,7.16,9.02z M3.29,13.05c0.58,0,1.05-0.47,1.05-1.05s-0.47-1.05-1.05-1.05 c-0.58,0-1.05,0.47-1.05,1.05S2.71,13.05,3.29,13.05z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
