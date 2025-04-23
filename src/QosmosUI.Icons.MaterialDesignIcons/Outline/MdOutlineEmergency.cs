// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineEmergency : ComponentBase
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
		builder.AddAttribute(18, "d", "M21.29,13.9L18,12l3.29-1.9c0.48-0.28,0.64-0.89,0.37-1.37l-2-3.46c-0.28-0.48-0.89-0.64-1.37-0.37L15,6.8V3 c0-0.55-0.45-1-1-1h-4C9.45,2,9,2.45,9,3v3.8L5.71,4.9C5.23,4.63,4.62,4.79,4.34,5.27l-2,3.46C2.06,9.21,2.23,9.82,2.71,10.1L6,12 l-3.29,1.9c-0.48,0.28-0.64,0.89-0.37,1.37l2,3.46c0.28,0.48,0.89,0.64,1.37,0.37L9,17.2V21c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1 v-3.8l3.29,1.9c0.48,0.28,1.09,0.11,1.37-0.37l2-3.46C21.94,14.79,21.77,14.18,21.29,13.9z M18.43,16.87l-4.68-2.7 C13.42,13.97,13,14.21,13,14.6V20h-2v-5.4c0-0.38-0.42-0.63-0.75-0.43l-4.68,2.7l-1-1.73l4.68-2.7c0.33-0.19,0.33-0.67,0-0.87 l-4.68-2.7l1-1.73l4.68,2.7C10.58,10.03,11,9.79,11,9.4V4h2v5.4c0,0.38,0.42,0.63,0.75,0.43l4.68-2.7l1,1.73l-4.68,2.7 c-0.33,0.19-0.33,0.67,0,0.87l4.68,2.7L18.43,16.87z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
