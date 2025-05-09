// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundEuro : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M15,18.5c-2.51,0-4.68-1.42-5.76-3.5h5.14c0.38,0,0.73-0.21,0.89-0.55l0,0c0.33-0.66-0.15-1.45-0.89-1.45h-5.8 c-0.05-0.33-0.08-0.66-0.08-1s0.03-0.67,0.08-1h5.8c0.38,0,0.73-0.21,0.89-0.55l0,0C15.61,9.78,15.13,9,14.38,9H9.24 C10.32,6.92,12.5,5.5,15,5.5c1.25,0,2.42,0.36,3.42,0.97c0.5,0.31,1.15,0.26,1.57-0.16l0,0c0.58-0.58,0.45-1.53-0.25-1.96 C18.36,3.5,16.73,3,15,3c-3.92,0-7.24,2.51-8.48,6h-2.9C3.24,9,2.89,9.21,2.72,9.55l0,0C2.39,10.22,2.87,11,3.62,11h2.44 C6.02,11.33,6,11.66,6,12s0.02,0.67,0.06,1H3.62c-0.38,0-0.73,0.21-0.89,0.55l0,0C2.39,14.22,2.87,15,3.62,15h2.9 c1.24,3.49,4.56,6,8.48,6c1.74,0,3.36-0.49,4.74-1.35c0.69-0.43,0.82-1.39,0.24-1.97l0,0c-0.42-0.42-1.07-0.47-1.57-0.15 C17.42,18.15,16.26,18.5,15,18.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
