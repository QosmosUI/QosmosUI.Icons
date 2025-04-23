// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMicExternalOff : ComponentBase
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
		builder.AddAttribute(21, "d", "M14,6c0-1.24,1.14-2.22,2.42-1.96C17.36,4.24,18,5.13,18,6.09v9.08l2,2V6.16c0-2.08-1.68-4.03-3.76-4.15 C13.92,1.87,12,3.71,12,6v3.17l2,2V6z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M10,5c0-1.66-1.34-3-3-3C6.38,2,5.81,2.19,5.33,2.5l4.15,4.15C9.8,6.18,10,5.61,10,5z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M1.39,2.81L1.39,2.81C1,3.2,1,3.83,1.39,4.22L5.17,8H5.1c-0.59,0-1.05,0.51-1,1.1l0.85,8.45C4.98,17.81,5.2,18,5.45,18H6 c0,2.34,2.01,4.21,4.39,3.98c2.08-0.2,3.61-2.06,3.61-4.15l0-1l5.78,5.78c0.39,0.39,1.02,0.39,1.41,0l0,0 c0.39-0.39,0.39-1.02,0-1.41L2.81,2.81C2.42,2.42,1.78,2.42,1.39,2.81z M12,17.91c0,0.96-0.64,1.86-1.58,2.05 C9.14,20.22,8,19.24,8,18h0.55c0.26,0,0.47-0.19,0.5-0.45l0.52-5.16L12,14.83V17.91z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
