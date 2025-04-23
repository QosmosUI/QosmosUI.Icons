// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCancelScheduleSend : ComponentBase
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
		builder.AddAttribute(25, "d", "M16.5,9c-0.42,0-0.83,0.04-1.24,0.11L2.4,3.6C1.74,3.31,1.01,3.8,1.01,4.51L1,9.2c0,0.47,0.33,0.88,0.78,0.98L10,12 l-8.22,1.83C1.33,13.93,1,14.33,1,14.8l0.01,4.68c0,0.72,0.73,1.2,1.39,0.92l6.68-2.86C9.59,21.19,12.71,24,16.5,24 c4.14,0,7.5-3.36,7.5-7.5S20.64,9,16.5,9z M16.5,22c-3.03,0-5.5-2.47-5.5-5.5s2.47-5.5,5.5-5.5s5.5,2.47,5.5,5.5S19.53,22,16.5,22 z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M18.62,14.38c-0.2-0.2-0.51-0.2-0.71,0l-1.41,1.41l-1.41-1.41c-0.2-0.2-0.51-0.2-0.71,0s-0.2,0.51,0,0.71l1.41,1.41 l-1.41,1.41c-0.2,0.2-0.2,0.51,0,0.71c0.2,0.2,0.51,0.2,0.71,0l1.41-1.41l1.41,1.41c0.2,0.2,0.51,0.2,0.71,0 c0.2-0.2,0.2-0.51,0-0.71l-1.41-1.41l1.41-1.41C18.82,14.89,18.82,14.57,18.62,14.38z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
