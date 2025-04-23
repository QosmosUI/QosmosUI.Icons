// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMediaBluetoothOff : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M9,6.17V5c0-1.1,0.9-2,2-2h2c1.1,0,2,0.9,2,2v0c0,1.1-0.9,2-2,2h-2v1.17L9,6.17z M19.42,15l2.18,2.17 c0.22,0.22,0.22,0.58,0,0.8l0,0c-0.22,0.22-0.58,0.22-0.8,0l-5.98-5.98c-0.22-0.22-0.22-0.58,0-0.8l0,0c0.22-0.22,0.58-0.22,0.8,0 l2.35,2.35V9.61c0-0.45,0.54-0.67,0.85-0.35l2.82,2.82c0.2,0.2,0.2,0.51,0,0.71L19.42,15z M19.17,13.55l1.13-1.13l-1.13-1.13 V13.55z M20.49,20.49c0.39,0.39,0.39,1.02,0,1.41l0,0c-0.39,0.39-1.02,0.39-1.41,0l-3.28-3.28l-0.16,0.16 c-0.23,0.23-0.62,0.23-0.85,0l0,0c-0.23-0.23-0.23-0.62,0-0.85l0.16-0.16L11,13.83l0,3.02c0,2.07-1.68,4.01-3.74,4.14 C4.94,21.13,3,19.29,3,17c0-2.21,1.79-4,4.01-4c0.73,0,1.41,0.21,2,0.55v-1.72L2.1,4.92c-0.39-0.39-0.39-1.02,0-1.41l0,0 c0.39-0.39,1.02-0.39,1.41,0L20.49,20.49z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
