// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundQueryStats : ComponentBase
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
		builder.AddAttribute(19, "d", "M19.88,18.47c0.48-0.77,0.75-1.67,0.69-2.66c-0.13-2.15-1.84-3.97-3.97-4.2c-2.72-0.3-5.02,1.81-5.02,4.47 c0,2.49,2.01,4.5,4.49,4.5c0.88,0,1.7-0.26,2.39-0.7l2.41,2.41c0.39,0.39,1.03,0.39,1.42,0v0c0.39-0.39,0.39-1.03,0-1.42 L19.88,18.47z M16.08,18.58c-1.38,0-2.5-1.12-2.5-2.5c0-1.38,1.12-2.5,2.5-2.5s2.5,1.12,2.5,2.5 C18.58,17.46,17.46,18.58,16.08,18.58z M15.72,10.08c-0.74,0.02-1.45,0.18-2.1,0.45l-0.55-0.83l-3.08,5.01 c-0.36,0.58-1.17,0.64-1.61,0.13l-2.12-2.47l-3.06,4.9c-0.31,0.49-0.97,0.62-1.44,0.28l0,0c-0.42-0.31-0.54-0.89-0.26-1.34 l3.78-6.05c0.36-0.57,1.17-0.63,1.61-0.12L9,12.5l3.18-5.17c0.38-0.62,1.28-0.64,1.68-0.03L15.72,10.08z M18.31,10.58 c-0.64-0.28-1.33-0.45-2.05-0.49L20.8,2.9c0.31-0.49,0.97-0.61,1.43-0.27l0,0c0.43,0.31,0.54,0.9,0.26,1.34L18.31,10.58z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
