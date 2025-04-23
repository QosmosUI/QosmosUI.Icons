// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneVerified : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M18.49,9.88l0.08-0.85l0.18-1.95l-1.9-0.43l-0.84-0.19l-0.44-0.74l-0.99-1.68L12.79,4.8L12,5.14L11.21,4.8 L9.42,4.03L8.43,5.71L7.99,6.45L7.15,6.64l-1.9,0.43l0.18,1.94l0.08,0.85l-0.56,0.65l-1.29,1.48l1.29,1.47l0.56,0.65l-0.08,0.85 l-0.18,1.96l1.9,0.43l0.84,0.19l0.44,0.74l0.99,1.67l1.78-0.77L12,18.85l0.79,0.34l1.78,0.77l0.99-1.68l0.44-0.74l0.84-0.19 l1.9-0.43l-0.18-1.95l-0.08-0.85l0.56-0.65l1.29-1.47l-1.29-1.47L18.49,9.88z M10.09,16.72l-3.8-3.81l1.48-1.48l2.32,2.33 l5.85-5.87l1.48,1.48L10.09,16.72z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M23,11.99l-2.44-2.79l0.34-3.69l-3.61-0.82L15.4,1.5L12,2.96L8.6,1.5L6.71,4.69L3.1,5.5L3.44,9.2L1,11.99l2.44,2.79 l-0.34,3.7l3.61,0.82L8.6,22.5l3.4-1.47l3.4,1.46l1.89-3.19l3.61-0.82l-0.34-3.69L23,11.99z M19.05,13.47l-0.56,0.65l0.08,0.85 l0.18,1.95l-1.9,0.43l-0.84,0.19l-0.44,0.74l-0.99,1.68l-1.78-0.77L12,18.85l-0.79,0.34l-1.78,0.77l-0.99-1.67l-0.44-0.74 l-0.84-0.19l-1.9-0.43l0.18-1.96l0.08-0.85l-0.56-0.65l-1.29-1.47l1.29-1.48l0.56-0.65L5.43,9.01L5.25,7.07l1.9-0.43l0.84-0.19 l0.44-0.74l0.99-1.68l1.78,0.77L12,5.14l0.79-0.34l1.78-0.77l0.99,1.68l0.44,0.74l0.84,0.19l1.9,0.43l-0.18,1.95l-0.08,0.85 l0.56,0.65l1.29,1.47L19.05,13.47z");
		builder.CloseElement();
		builder.OpenElement(25, "polygon");
		builder.AddAttribute(26, "points", "10.09,13.75 7.77,11.42 6.29,12.91 10.09,16.72 17.43,9.36 15.95,7.87");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
