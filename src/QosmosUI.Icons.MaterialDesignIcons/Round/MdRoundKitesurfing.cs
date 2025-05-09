// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundKitesurfing : ComponentBase
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
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M6,3c0-1.1,0.9-2,2-2s2,0.9,2,2c0,1.1-0.9,2-2,2S6,4.1,6,3z M16.03,3.97c0.29,0.29,0.77,0.29,1.06,0L20.06,1h-2.12 l-1.91,1.91C15.74,3.2,15.74,3.68,16.03,3.97z M19.15,12c-1.29,0-3.11,0.53-5.06,1.38L13,12.16c-0.38-0.42-0.92-0.66-1.49-0.66H9.6 l0-3.5H11c1.52,0,2.94-0.49,4.09-1.32c0.49-0.35,0.52-1.07,0.09-1.5c-0.35-0.35-0.9-0.38-1.3-0.09C13.06,5.66,12.07,6,11,6H8 C6.9,6,6,6.9,6,8v4.04c0,0.64,0.15,1.27,0.45,1.83L8,16.84c-0.53,0.38-1.03,0.78-1.49,1.17C7.19,18.59,8.06,19,9,19 c1.2,0,2.27-0.66,3-1.5c0.73,0.84,1.8,1.5,3,1.5c0.33,0,0.65-0.05,0.96-0.14C18.81,16.9,21,14.72,21,13.28 C21,12.25,19.99,12,19.15,12z M9.83,15.61L9,13.6l2.5-0.1l0.7,0.77C11.64,14.55,10.42,15.23,9.83,15.61z M22,22c0-0.55-0.45-1-1-1 h0c-0.87,0-1.73-0.24-2.53-0.7c-0.29-0.16-0.65-0.17-0.94,0c-1.59,0.9-3.47,0.9-5.06,0c-0.29-0.16-0.65-0.16-0.94,0 c-1.59,0.9-3.47,0.9-5.06,0c-0.29-0.16-0.65-0.16-0.94,0C4.73,20.76,3.87,21,3,21h0c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1h0 c1.15,0,2.3-0.31,3.33-0.94c1.66,1.11,3.78,1.01,5.58,0.14c1.91,1.05,4.17,1.07,6.09,0.05h0c0.95,0.5,1.97,0.75,3,0.75h0 C21.55,23,22,22.55,22,22z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
