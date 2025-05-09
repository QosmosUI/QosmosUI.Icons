// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundOnlinePrediction : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M15.5,11.5c0,2-2.5,3.5-2.5,5h-2c0-1.5-2.5-3-2.5-5C8.5,9.57,10.07,8,12,8S15.5,9.57,15.5,11.5z M13,17.5h-2V18 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V17.5z M22,12c0-2.46-0.89-4.71-2.36-6.45c-0.29-0.34-0.8-0.38-1.12-0.06l0,0 c-0.27,0.27-0.3,0.71-0.06,1C19.73,7.97,20.5,9.9,20.5,12c0,2.1-0.77,4.03-2.04,5.52c-0.25,0.29-0.21,0.73,0.06,1l0,0 c0.32,0.32,0.83,0.28,1.12-0.06C21.11,16.71,22,14.46,22,12z M3.5,12c0-2.1,0.77-4.03,2.04-5.52c0.25-0.29,0.21-0.73-0.06-1l0,0 C5.17,5.17,4.65,5.2,4.36,5.54C2.89,7.29,2,9.54,2,12c0,2.46,0.89,4.71,2.36,6.46c0.29,0.34,0.8,0.38,1.12,0.06l0,0 c0.27-0.27,0.3-0.71,0.06-1C4.27,16.03,3.5,14.1,3.5,12z M17.5,12c0,1.28-0.44,2.47-1.18,3.41c-0.23,0.29-0.2,0.71,0.07,0.98l0,0 c0.32,0.32,0.85,0.29,1.13-0.07C18.44,15.13,19,13.63,19,12c0-1.63-0.56-3.13-1.49-4.31c-0.28-0.36-0.81-0.39-1.13-0.07l0,0 c-0.26,0.26-0.3,0.68-0.07,0.98C17.06,9.53,17.5,10.72,17.5,12z M7.62,16.38L7.62,16.38c0.26-0.26,0.3-0.68,0.07-0.98 C6.94,14.47,6.5,13.28,6.5,12c0-1.28,0.44-2.47,1.18-3.41c0.23-0.29,0.2-0.71-0.07-0.98l0,0C7.3,7.3,6.77,7.33,6.49,7.68 C5.56,8.87,5,10.37,5,12c0,1.63,0.56,3.13,1.49,4.32C6.77,16.67,7.3,16.7,7.62,16.38z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
