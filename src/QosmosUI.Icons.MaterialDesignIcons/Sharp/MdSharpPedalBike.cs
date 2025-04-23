// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpPedalBike : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M18.18,10L16,4h-4v2h2.6l1.46,4h-4.81l-0.36-1H12V7H7v2h1.75l1.82,5H9.9c-0.44-2.23-2.31-3.88-4.65-3.99 C2.45,9.87,0,12.2,0,15c0,2.8,2.2,5,5,5c2.46,0,4.45-1.69,4.9-4h4.2c0.44,2.23,2.31,3.88,4.65,3.99c2.8,0.13,5.25-2.19,5.25-5 c0-2.8-2.2-5-5-5H18.18z M7.82,16c-0.4,1.17-1.49,2-2.82,2c-1.68,0-3-1.32-3-3s1.32-3,3-3c1.33,0,2.42,0.83,2.82,2H5v2H7.82z M14.1,14h-1.4l-0.73-2H15C14.56,12.58,14.24,13.25,14.1,14z M19,18c-1.68,0-3-1.32-3-3c0-0.93,0.41-1.73,1.05-2.28l0.96,2.64 l1.88-0.68l-0.97-2.67c0.03,0,0.06-0.01,0.09-0.01c1.68,0,3,1.32,3,3S20.68,18,19,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
