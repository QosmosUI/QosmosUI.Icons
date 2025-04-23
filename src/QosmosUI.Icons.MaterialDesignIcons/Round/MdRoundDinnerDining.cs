// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDinnerDining : ComponentBase
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
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M2.85,19.85l1,1C3.95,20.95,4.07,21,4.21,21h15.59c0.13,0,0.26-0.05,0.35-0.15l1-1c0.31-0.31,0.09-0.85-0.35-0.85H3.21 C2.76,19,2.54,19.54,2.85,19.85z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M3,18l16.97,0c0,0,0,0,0,0c0.29-3.26-2.28-6-5.48-6c-2.35,0-4.35,1.48-5.14,3.55C8.94,15.32,8.48,15.17,8,15.08V9h1.75 C10.99,9,12,7.99,12,6.75v0h8.25C20.66,6.75,21,6.41,21,6s-0.34-0.75-0.75-0.75H12v0C12,4.01,10.99,3,9.75,3h-6 C3.34,3,3,3.34,3,3.75S3.34,4.5,3.75,4.5H4v0.75H3.75C3.34,5.25,3,5.59,3,6s0.34,0.75,0.75,0.75H4V7.5H3.75 C3.34,7.5,3,7.84,3,8.25S3.34,9,3.75,9H4v7.39C3.56,16.85,3.22,17.39,3,18z M8,4.5h2v0.75H8V4.5z M8,6.75h2V7.5H8V6.75z M5.5,4.5 h1v0.75h-1V4.5z M5.5,6.75h1V7.5h-1V6.75z M5.5,9h1v6.06c-0.35,0.06-0.68,0.17-1,0.3V9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
