// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpMacroOff : ComponentBase
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
		builder.AddAttribute(21, "d", "M19.98,17.15C20.63,15.91,21,14.5,21,13c-1.5,0-2.91,0.37-4.15,1.02L19.98,17.15z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M3,13c0,4.97,4.03,9,9,9C12,17.03,7.97,13,3,13z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,5.5c1.38,0,2.5,1.12,2.5,2.5c0,0.99-0.58,1.84-1.42,2.25l2.48,2.48c0.11,0.02,0.23,0.03,0.35,0.03 c1.38,0,2.5-1.12,2.5-2.5c0-1-0.59-1.85-1.43-2.25c0.84-0.4,1.43-1.25,1.43-2.25c0-1.38-1.12-2.5-2.5-2.5 c-0.53,0-1.01,0.16-1.42,0.44L14.5,3.5C14.5,2.12,13.38,1,12,1S9.5,2.12,9.5,3.5l0.02,0.19C9.12,3.41,8.63,3.25,8.1,3.25 c-0.57,0-1.09,0.2-1.51,0.52l3.16,3.16C10.16,6.08,11.01,5.5,12,5.5z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M2.81,2.81L1.39,4.22l4.64,4.64C5.76,9.26,5.6,9.73,5.6,10.25c0,1.38,1.12,2.5,2.5,2.5c0.52,0,0.99-0.16,1.4-0.43 l0.02,0.02L9.5,12.5c0,1.38,1.12,2.5,2.5,2.5c0.05,0,0.1-0.01,0.16-0.02l1.64,1.64C12.67,18.12,12,19.98,12,22 c2.02,0,3.88-0.67,5.38-1.8l2.4,2.4l1.41-1.41L2.81,2.81z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
