// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFestival : ComponentBase
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
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M23,11v-0.61c0-0.8-0.48-1.54-1.23-1.84c-3.65-1.48-6.81-3.93-8.48-5.37c-0.74-0.64-1.84-0.64-2.58,0 C9.03,4.62,5.88,7.06,2.23,8.55C1.48,8.85,1,9.58,1,10.39V11c0,1.49,0.93,2.75,2.24,3.26c-0.03,1.68-0.16,3.55-0.52,5.29 C2.46,20.81,3.38,22,4.67,22h14.67c1.29,0,2.21-1.19,1.95-2.45c-0.36-1.75-0.5-3.62-0.52-5.29C22.07,13.75,23,12.49,23,11z M12,4.71c1.33,1.14,3.49,2.84,6.11,4.29H5.89C8.51,7.55,10.67,5.85,12,4.71z M13,11h3c0,0.83-0.67,1.5-1.5,1.5S13,11.83,13,11z M9.5,12.5C8.67,12.5,8,11.83,8,11h3C11,11.83,10.33,12.5,9.5,12.5z M6,11c0,0.83-0.67,1.5-1.5,1.5S3,11.83,3,11H6z M4.66,20 c0.39-1.86,0.54-3.82,0.57-5.58c0.68-0.15,1.29-0.49,1.76-0.98c0.25,0.25,0.54,0.45,0.85,0.62c-0.1,1.87-0.26,4-0.52,5.93H4.66z M9.35,20c0.24-1.83,0.39-3.78,0.48-5.53c0.84-0.08,1.61-0.45,2.17-1.02c0.56,0.57,1.32,0.94,2.17,1.02 c0.1,1.75,0.24,3.7,0.48,5.53H9.35z M16.67,20c-0.27-1.94-0.43-4.07-0.52-5.93c0.31-0.17,0.61-0.37,0.85-0.62 c0.47,0.48,1.08,0.83,1.76,0.98c0.03,1.76,0.18,3.72,0.57,5.58H16.67z M19.5,12.5c-0.83,0-1.5-0.67-1.5-1.5h3 C21,11.83,20.33,12.5,19.5,12.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
