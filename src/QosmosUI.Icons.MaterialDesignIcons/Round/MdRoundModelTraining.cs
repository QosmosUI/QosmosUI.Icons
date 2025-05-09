// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundModelTraining : ComponentBase
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
		builder.AddAttribute(19, "d", "M15.5,13.5c0,2-2.5,3.5-2.5,5h-2c0-1.5-2.5-3-2.5-5c0-1.93,1.57-3.5,3.5-3.5h0C13.93,10,15.5,11.57,15.5,13.5z M13,19.5h-2 V20c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V19.5z M19,13c0,1.39-0.41,2.69-1.12,3.78c-0.25,0.39-0.19,0.91,0.14,1.24l0,0 c0.44,0.44,1.2,0.38,1.54-0.15C20.47,16.47,21,14.8,21,13c0-2.36-0.91-4.51-2.4-6.12c-0.39-0.42-1.05-0.43-1.45-0.03l0,0 c-0.38,0.38-0.38,0.99-0.02,1.39C18.29,9.49,19,11.16,19,13z M15.65,4.65l-2.79-2.79C12.54,1.54,12,1.76,12,2.21V4l0,0 c-4.97,0-9,4.03-9,9c0,1.8,0.53,3.47,1.44,4.88c0.34,0.53,1.1,0.59,1.54,0.15l0,0c0.33-0.33,0.39-0.84,0.14-1.23 C4.73,14.65,4.48,11.7,6.25,8.8C7.45,6.85,9.71,5.81,12,6l0,0v1.79c0,0.45,0.54,0.67,0.85,0.35l2.79-2.79 C15.84,5.16,15.84,4.84,15.65,4.65z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
