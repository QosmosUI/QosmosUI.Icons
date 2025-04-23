// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSupport : ComponentBase
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
		builder.AddAttribute(21, "d", "M10.3,7.32L9.13,4.54C7.02,5.35,5.35,7.02,4.54,9.13l2.78,1.15C7.83,8.9,8.92,7.82,10.3,7.32z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M7.32,13.72l-2.78,1.15c0.81,2.1,2.48,3.78,4.59,4.59l1.17-2.78C8.91,16.18,7.83,15.09,7.32,13.72z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M16.67,10.27l2.78-1.15c-0.81-2.1-2.48-3.77-4.58-4.58l-1.15,2.78C15.09,7.83,16.17,8.9,16.67,10.27z");
		builder.AddAttribute(28, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M16.68,13.71c-0.5,1.37-1.58,2.46-2.95,2.97l1.15,2.78c2.1-0.81,3.77-2.48,4.58-4.58L16.68,13.71z");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M12,2C6.48,2,2,6.48,2,12c0,5.52,4.48,10,10,10s10-4.48,10-10C22,6.48,17.52,2,12,2z M14.87,4.54 c2.1,0.81,3.77,2.48,4.58,4.58l-2.78,1.15c-0.51-1.36-1.58-2.44-2.95-2.94L14.87,4.54z M9.13,4.54l1.17,2.78 c-1.38,0.5-2.47,1.59-2.98,2.97L4.54,9.13C5.35,7.02,7.02,5.35,9.13,4.54z M9.13,19.46c-2.1-0.81-3.78-2.48-4.59-4.59l2.78-1.15 c0.51,1.38,1.59,2.46,2.97,2.96L9.13,19.46z M9,12c0-1.66,1.34-3,3-3s3,1.34,3,3s-1.34,3-3,3S9,13.66,9,12z M14.88,19.46 l-1.15-2.78c1.37-0.51,2.45-1.59,2.95-2.97l2.78,1.17C18.65,16.98,16.98,18.65,14.88,19.46z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
