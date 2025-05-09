// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMacroOff : ComponentBase
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
		builder.AddAttribute(25, "d", "M4.2,13.08c-0.64-0.09-1.21,0.48-1.12,1.12C3.67,18.6,7.44,22,12,22C12,17.44,8.6,13.67,4.2,13.08z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,5.5c1.38,0,2.5,1.12,2.5,2.5c0,0.99-0.58,1.84-1.42,2.25l2.48,2.48c0.11,0.02,0.23,0.03,0.35,0.03 c1.38,0,2.5-1.12,2.5-2.5c0-1-0.59-1.85-1.43-2.25c0.84-0.4,1.43-1.25,1.43-2.25c0-1.38-1.12-2.5-2.5-2.5 c-0.53,0-1.01,0.16-1.42,0.44L14.5,3.5C14.5,2.12,13.38,1,12,1S9.5,2.12,9.5,3.5l0.02,0.19C9.12,3.41,8.63,3.25,8.1,3.25 c-0.57,0-1.09,0.2-1.51,0.52l3.16,3.16C10.16,6.08,11.01,5.5,12,5.5z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M19.98,17.15c0.47-0.91,0.8-1.9,0.94-2.95c0.09-0.64-0.48-1.21-1.12-1.12c-1.05,0.14-2.05,0.47-2.95,0.94L19.98,17.15z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M2.1,3.51L2.1,3.51c-0.39,0.39-0.39,1.02,0,1.41l3.93,3.93c-0.35,0.52-0.53,1.17-0.38,1.89c0.22,1.13,1.26,1.98,2.41,2 c0.54,0.01,1.02-0.15,1.44-0.43l0.02,0.02L9.5,12.5c0,1.38,1.12,2.5,2.5,2.5c0.05,0,0.1-0.01,0.16-0.02l1.64,1.64 C12.67,18.12,12,19.98,12,22c2.02,0,3.88-0.67,5.38-1.79l1.69,1.69c0.39,0.39,1.02,0.39,1.41,0l0,0c0.39-0.39,0.39-1.02,0-1.41 L3.51,3.51C3.12,3.12,2.49,3.12,2.1,3.51z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
