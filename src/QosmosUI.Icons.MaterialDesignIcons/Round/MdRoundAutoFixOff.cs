// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAutoFixOff : ComponentBase
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
		builder.AddAttribute(18, "x", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M22,3.55l-1.06-0.49L20.45,2c-0.18-0.39-0.73-0.39-0.91,0l-0.49,1.06L18,3.55c-0.39,0.18-0.39,0.73,0,0.91l1.06,0.49 L19.55,6c0.18,0.39,0.73,0.39,0.91,0l0.49-1.06L22,4.45C22.39,4.28,22.39,3.72,22,3.55z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M14.17,8.42l1.41,1.41l-1.46,1.46l1.41,1.41l2.17-2.17c0.39-0.39,0.39-1.02,0-1.41l-2.83-2.83 c-0.39-0.39-1.02-0.39-1.41,0l-2.17,2.17l1.41,1.41L14.17,8.42z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M2.1,4.93l6.36,6.36l-6.17,6.17c-0.39,0.39-0.39,1.02,0,1.41l2.83,2.83c0.39,0.39,1.02,0.39,1.41,0l6.17-6.17l6.36,6.36 c0.39,0.39,1.02,0.39,1.41,0h0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0l0,0 C1.71,3.91,1.71,4.54,2.1,4.93z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
