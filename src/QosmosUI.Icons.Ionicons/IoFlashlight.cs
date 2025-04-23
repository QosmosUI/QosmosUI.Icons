// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoFlashlight : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M462,216c9.35-9.35,15.14-19.09,17.19-28.95,2.7-12.95-1.29-25.55-11.22-35.48L360.43,44.05C346.29,29.92,322,24.07,296,50l-2,2a8,8,0,0,0,0,11.32L448.64,218A8,8,0,0,0,460,218Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M250.14,153.08l-.16,2.34c-.53,7.18-6.88,19.15-13.88,26.14L47.27,370.36c-11.12,11.11-16.46,25.57-15.05,40.7C33.49,424.58,40.16,438,51,448.83L63.17,461c12.61,12.6,27.78,19,42.49,19a50.4,50.4,0,0,0,36-15.24l188.84-188.8c7.07-7.07,18.84-13.3,26.17-13.87,17.48-1.32,43.57-3.28,67.79-15.65a4,4,0,0,0,1-6.37L271.69,86.31a4,4,0,0,0-6.39,1C253.18,110.3,251.48,134.22,250.14,153.08Zm-9.95,146.83a20,20,0,1,1,0-25.25A20,20,0,0,1,240.19,299.91Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
