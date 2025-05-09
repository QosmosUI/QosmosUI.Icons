// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpMiscellaneousServices : ComponentBase
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
		builder.AddAttribute(21, "d", "M14.02,13.97l1.7-2.94c0,0-0.09-0.08-0.23-0.18l-1.47-1.16l-0.01,0.02c0.03-0.24,0.05-0.47,0.05-0.71S14.04,8.53,14,8.31 l0.01,0.01l1.71-1.34l-1.7-2.95l-2.01,0.81v0.01c-0.37-0.28-0.77-0.52-1.2-0.7h0.01L10.52,2H7.11L6.8,4.15h0.01 c-0.43,0.18-0.83,0.42-1.2,0.7V4.84L3.6,4.03L1.9,6.98l1.7,1.34l0.01-0.01C3.58,8.53,3.56,8.76,3.56,9s0.02,0.47,0.05,0.71 L3.6,9.69l-1.47,1.16C2,10.95,1.9,11.03,1.9,11.03l1.7,2.94l2.02-0.8L5.6,13.14c0.37,0.29,0.77,0.53,1.21,0.71H6.8L7.11,16h3.4 c0,0,0.02-0.13,0.04-0.3l0.27-1.85h-0.01c0.44-0.18,0.84-0.42,1.21-0.71L12,13.17L14.02,13.97z M8.81,11c-1.1,0-2-0.9-2-2 s0.9-2,2-2s2,0.9,2,2S9.91,11,8.81,11z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M20.98,17.94l-0.01,0.01C20.99,17.8,21,17.65,21,17.5c0-0.15-0.01-0.3-0.04-0.44l0.01,0.01l1.1-0.86l-1.09-1.9l-1.29,0.52 v0.01c-0.24-0.18-0.49-0.33-0.77-0.45h0.01L18.73,13h-2.19l-0.2,1.38h0.01c-0.28,0.12-0.53,0.27-0.77,0.45v-0.01l-1.29-0.52 l-1.09,1.9l1.09,0.86l0.01-0.01c-0.02,0.14-0.03,0.29-0.03,0.44c0,0.15,0.01,0.3,0.03,0.46l-0.01-0.01l-0.94,0.75 c-0.08,0.06-0.15,0.12-0.15,0.12l1.09,1.89l1.3-0.51l-0.01-0.02c0.24,0.19,0.5,0.34,0.78,0.46h-0.01l0.2,1.38h2.19 c0,0,0.01-0.08,0.03-0.19l0.17-1.19h-0.01c0.28-0.12,0.54-0.27,0.78-0.46l-0.01,0.02l1.3,0.51l1.09-1.89c0,0-0.06-0.05-0.15-0.12 L20.98,17.94z M17.63,18.79c-0.71,0-1.29-0.58-1.29-1.29s0.58-1.29,1.29-1.29s1.29,0.58,1.29,1.29S18.34,18.79,17.63,18.79z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
