// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFlood : ComponentBase
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
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M18.67,19c-1.95,0-2.09,1-3.33,1c-1.19,0-1.42-1-3.33-1c-1.95,0-2.1,1-3.34,1c-1.24,0-1.38-1-3.33-1 c-1.54,0-1.96,0.62-2.67,0.88C2.27,20.03,2,20.4,2,20.83v0c0,0.71,0.72,1.19,1.38,0.94C4.15,21.48,4.49,21,5.34,21 c1.24,0,1.38,1,3.33,1c1.95,0,2.1-1,3.34-1c1.22,0,1.4,1,3.33,1c1.93,0,2.1-1,3.33-1c0.84,0,1.18,0.47,1.95,0.77 c0.66,0.26,1.38-0.23,1.38-0.94v-0.01c0-0.42-0.27-0.8-0.67-0.94C20.62,19.62,20.21,19,18.67,19z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M8.68,17.5c1.95,0,2.09-1,3.33-1c1.19,0,1.42,1,3.33,1c1.95,0,2.09-1,3.33-1c0.82,0,1.17,0.46,1.93,0.76 c0.66,0.26,1.38-0.23,1.38-0.94v0c0-0.42-0.26-0.79-0.65-0.94c-0.29-0.11-0.54-0.27-0.83-0.43l-2.02-7.53l1.17,0.47 c0.51,0.21,1.09-0.04,1.29-0.55v0c0.21-0.51-0.05-1.1-0.57-1.29l-9.24-3.54c-0.81-0.31-1.72-0.06-2.27,0.61l-6.23,7.7 c-0.35,0.43-0.28,1.06,0.16,1.4l0,0c0.43,0.34,1.06,0.26,1.39-0.17l0.78-1l0.93,3.48c-0.18-0.02-0.35-0.05-0.56-0.05 c-1.54,0-1.95,0.62-2.66,0.88C2.27,15.53,2,15.91,2,16.33v0c0,0.7,0.69,1.19,1.35,0.95c0.8-0.29,1.18-0.78,2-0.78 C6.54,16.5,6.77,17.5,8.68,17.5z M14.04,10.18l1.42,5.31c-1.34,0.09-1.47-0.99-3.47-0.99c-0.36,0-0.65,0.04-0.91,0.1l-0.91-3.39 L14.04,10.18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
