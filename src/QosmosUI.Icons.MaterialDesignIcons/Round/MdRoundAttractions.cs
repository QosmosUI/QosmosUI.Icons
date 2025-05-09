// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAttractions : ComponentBase
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
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M10.44,18.75c0.37-0.46,0.94-0.75,1.57-0.75s1.19,0.29,1.56,0.75c0.39-0.09,0.76-0.21,1.12-0.36l-1.42-3.18 c-0.39,0.15-0.82,0.23-1.26,0.23c-0.46,0-0.9-0.09-1.3-0.25l-1.43,3.19C9.65,18.54,10.03,18.67,10.44,18.75z M5.16,10 C5,10.59,4.91,11.21,4.91,11.85c0,0.75,0.12,1.47,0.33,2.15c0.63,0.05,1.22,0.4,1.56,0.99c0.33,0.57,0.35,1.23,0.11,1.79 c0.27,0.27,0.56,0.53,0.87,0.76l1.52-3.39l0,0c-0.47-0.58-0.75-1.32-0.75-2.13c0-1.89,1.55-3.41,3.46-3.41s3.46,1.53,3.46,3.41 c0,0.82-0.29,1.57-0.78,2.16l1.5,3.35c0.32-0.24,0.62-0.5,0.9-0.79c-0.22-0.55-0.2-1.2,0.12-1.75c0.33-0.57,0.9-0.92,1.52-0.99 c0.22-0.68,0.34-1.41,0.34-2.16c0-0.64-0.09-1.27-0.25-1.86c-0.64-0.04-1.26-0.39-1.6-1c-0.36-0.62-0.35-1.36-0.03-1.95 c-0.91-0.98-2.1-1.71-3.44-2.05C13.4,5.6,12.74,6,12.01,6s-1.39-0.41-1.74-1.01C8.93,5.33,7.74,6.04,6.83,7.02 C7.16,7.62,7.18,8.37,6.81,9C6.45,9.62,5.82,9.97,5.16,10z M3.86,9.58C3.08,8.98,2.84,7.88,3.35,7s1.58-1.23,2.49-0.85 c1.11-1.17,2.56-2.03,4.18-2.42C10.15,2.75,10.99,2,12.01,2s1.85,0.75,1.98,1.73c1.63,0.39,3.07,1.24,4.18,2.42 c0.91-0.38,1.99-0.03,2.49,0.85c0.51,0.88,0.27,1.98-0.51,2.58c0.23,0.77,0.35,1.58,0.35,2.42s-0.12,1.65-0.35,2.42 c0.78,0.6,1.02,1.7,0.51,2.58s-1.58,1.23-2.49,0.85c-0.4,0.43-0.85,0.81-1.34,1.15l0.81,1.8c0.25,0.56-0.16,1.2-0.78,1.2h0 c-0.33,0-0.64-0.2-0.78-0.5l-0.75-1.67c-0.43,0.18-0.88,0.33-1.34,0.44C13.86,21.25,13.02,22,12.01,22s-1.85-0.75-1.98-1.73 C9.55,20.15,9.09,20,8.65,19.81L7.89,21.5C7.75,21.8,7.45,22,7.11,22H7.1c-0.62,0-1.03-0.64-0.77-1.2l0.82-1.83 c-0.47-0.33-0.91-0.71-1.3-1.12c-0.92,0.38-1.99,0.03-2.5-0.85s-0.27-1.98,0.51-2.58C3.62,13.65,3.51,12.84,3.51,12 S3.62,10.35,3.86,9.58z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
