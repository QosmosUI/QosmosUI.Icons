// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundVapeFree : ComponentBase
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
		builder.AddAttribute(24, "d", "M20.49,21.9c-0.39,0.39-1.02,0.39-1.41,0l-2.9-2.9H8v-3h5.17L2.1,4.93c-0.39-0.39-0.39-1.02,0-1.41s1.02-0.39,1.41,0 l16.97,16.97C20.88,20.88,20.88,21.51,20.49,21.9z M18.83,16h1.67c0.83,0,1.5,0.67,1.5,1.5c0,0.46-0.21,0.87-0.53,1.14L18.83,16z M10.5,17c-0.28,0-0.5,0.22-0.5,0.5s0.22,0.5,0.5,0.5s0.5-0.22,0.5-0.5S10.78,17,10.5,17z M18.85,7.73c0.62-0.61,1-1.45,1-2.38 c0-1.51-1-2.79-2.38-3.21C16.99,2,16.5,2.36,16.5,2.86c0,0.33,0.21,0.62,0.52,0.71c0.77,0.23,1.33,0.94,1.33,1.78 c0,0.82-0.53,1.51-1.27,1.76C16.75,7.22,16.5,7.5,16.5,7.85V8c0,0.37,0.27,0.69,0.64,0.75c1.93,0.31,3.36,2,3.36,4.02v1.48 c0,0.41,0.34,0.75,0.75,0.75S22,14.66,22,14.25v-1.49C22,10.54,20.72,8.62,18.85,7.73z M14.48,11.65c0.04,0,0.09,0,0.13,0h1.42 c1.05,0,1.97,0.74,1.97,2.05v0.55c0,0.41,0.34,0.75,0.76,0.75c0.41,0,0.75-0.33,0.75-0.75v-0.89c-0.01-1.81-1.61-3.16-3.48-3.16 h-1.3c-1.02,0-1.94-0.73-2.07-1.75c-0.12-0.95,0.46-1.7,1.3-1.93c0.32-0.09,0.54-0.38,0.54-0.72c0-0.49-0.46-0.86-0.93-0.72 c-1.41,0.41-2.43,1.71-2.42,3.24L14.48,11.65z M3,18.5c1.33,0,2.71,0.18,4,0.5v-3c-1.29,0.32-2.67,0.5-4,0.5c-0.55,0-1,0.45-1,1 S2.45,18.5,3,18.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
