// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFireExtinguisher : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M7,19h10v1c0,1.1-0.9,2-2,2H9c-1.1,0-2-0.9-2-2V19z M7,18h10v-5H7V18z M17,4.23v3.54c0,0.63-0.58,1.11-1.21,0.98 l-1.94-0.41c0,0.02,0,0.01-0.01,0.03c1.54,0.62,2.71,1.98,3.06,3.63H7.1c0.34-1.66,1.52-3.02,3.07-3.64 c-0.33-0.26-0.6-0.58-0.8-0.95L5.49,6.6C5.2,6.54,5,6.29,5,6v0c0-0.29,0.2-0.54,0.49-0.6l3.88-0.81C9.87,3.65,10.86,3,12,3 c0.7,0,1.34,0.25,1.85,0.66l1.94-0.41C16.42,3.12,17,3.6,17,4.23z M13,6c-0.03-0.59-0.45-1-1-1s-1,0.45-1,1s0.45,1,1,1 S13,6.55,13,6z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
