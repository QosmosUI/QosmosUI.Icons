// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundBikeScooter : ComponentBase
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
		builder.AddAttribute(25, "d", "M10,14h0.74L8.82,5.56C8.61,4.65,7.8,4,6.87,4H4C3.45,4,3,4.45,3,5v0c0,0.55,0.45,1,1,1h2.87l1.42,6.25c0,0-0.01,0-0.01,0 C6.12,12.9,4.47,14.73,4.09,17H0v2h6v-1C6,15.79,7.79,14,10,14z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M18.75,8l-0.56,0l-1.35-3.69C16.55,3.52,15.8,3,14.96,3H12c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h2.96l1.1,3H10.4 l0.46,2H15c-0.43,0.58-0.75,1.25-0.9,2h-2.79l0.46,2h2.33c0.44,2.23,2.31,3.88,4.65,3.99c3.16,0.15,5.88-2.83,5.12-6.1 C23.34,9.57,21.13,8,18.75,8z M18.88,16c-1.54-0.06-2.84-1.37-2.88-2.92c-0.02-0.96,0.39-1.8,1.05-2.36l0.62,1.7 c0.19,0.52,0.76,0.79,1.28,0.6l0,0c0.52-0.19,0.79-0.76,0.6-1.28l-0.63-1.73c0,0,0,0,0.01-0.01C20.64,9.96,22,11.29,22,13 C22,14.72,20.62,16.06,18.88,16z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M10,15c-1.66,0-3,1.34-3,3s1.34,3,3,3s3-1.34,3-3S11.66,15,10,15z M10,19c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1 S10.55,19,10,19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
