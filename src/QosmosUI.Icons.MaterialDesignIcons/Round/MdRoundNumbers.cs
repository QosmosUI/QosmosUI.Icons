// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundNumbers : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M20.68,9.27l0.01-0.06C20.85,8.59,20.39,8,19.76,8H17l0.7-2.79C17.85,4.59,17.39,4,16.76,4h0c-0.45,0-0.83,0.3-0.94,0.73 L15,8h-4l0.7-2.79C11.85,4.59,11.39,4,10.76,4h0c-0.45,0-0.83,0.3-0.94,0.73L9,8H5.76C5.31,8,4.92,8.3,4.82,8.73L4.8,8.79 C4.65,9.41,5.11,10,5.74,10H8.5l-1,4H4.26c-0.45,0-0.83,0.3-0.94,0.73L3.3,14.79C3.15,15.41,3.61,16,4.24,16H7l-0.7,2.79 C6.15,19.41,6.61,20,7.24,20h0c0.45,0,0.83-0.3,0.94-0.73L9,16h4l-0.7,2.79C12.15,19.41,12.61,20,13.24,20h0 c0.45,0,0.83-0.3,0.94-0.73L15,16h3.24c0.45,0,0.83-0.3,0.94-0.73l0.01-0.06c0.15-0.61-0.31-1.21-0.94-1.21H15.5l1-4h3.24 C20.19,10,20.58,9.7,20.68,9.27z M13.5,14h-4l1-4h4L13.5,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
