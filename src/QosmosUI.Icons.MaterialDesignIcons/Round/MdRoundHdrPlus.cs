// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHdrPlus : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "height", "1");
		builder.AddAttribute(22, "width", "2");
		builder.AddAttribute(23, "x", "8.5");
		builder.AddAttribute(24, "y", "14.5");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "3");
		builder.AddAttribute(27, "width", "1.5");
		builder.AddAttribute(28, "x", "14.5");
		builder.AddAttribute(29, "y", "7.5");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M12,2C6.48,2,2,6.48,2,12s4.48,10,10,10s10-4.48,10-10S17.52,2,12,2z M12,15.5c0,0.6-0.4,1.1-0.9,1.4l0.49,1.13 c0.2,0.46-0.14,0.97-0.64,0.97h0c-0.27,0-0.52-0.16-0.63-0.41L9.6,17H8.5v1.31C8.5,18.69,8.19,19,7.81,19H7.69 C7.31,19,7,18.69,7,18.31V14c0-0.55,0.45-1,1-1h2.5c0.82,0,1.5,0.68,1.5,1.5V15.5z M11.25,12L11.25,12 c-0.41,0-0.75-0.34-0.75-0.75V9.5h-2v1.75C8.5,11.66,8.16,12,7.75,12h0C7.34,12,7,11.66,7,11.25v-4.5C7,6.34,7.34,6,7.75,6h0 C8.16,6,8.5,6.34,8.5,6.75V8h2V6.75C10.5,6.34,10.84,6,11.25,6h0C11.66,6,12,6.34,12,6.75v4.5C12,11.66,11.66,12,11.25,12z M16.75,16H16v0.75c0,0.41-0.34,0.75-0.75,0.75h0c-0.41,0-0.75-0.34-0.75-0.75V16h-0.75C13.34,16,13,15.66,13,15.25v0 c0-0.41,0.34-0.75,0.75-0.75h0.75v-0.75c0-0.41,0.34-0.75,0.75-0.75h0c0.41,0,0.75,0.34,0.75,0.75v0.74h0.75 c0.41,0,0.75,0.34,0.75,0.75v0.01C17.5,15.66,17.16,16,16.75,16z M17.5,10.5c0,0.82-0.67,1.5-1.5,1.5h-2.5 c-0.28,0-0.5-0.22-0.5-0.5v-5C13,6.22,13.22,6,13.5,6H16c0.83,0,1.5,0.68,1.5,1.5V10.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
