// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAirplaneTicket : ComponentBase
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
		builder.AddAttribute(20, "d", "M4.01,8.54C5.2,9.23,6,10.52,6,12c0,1.47-0.81,2.77-2,3.46V18h16V6H4L4.01,8.54z M8.14,12.53l1.26,0.99 l2.39-0.64l-2.4-4.16l1.4-0.38l4.01,3.74l2.44-0.65c0.51-0.14,1.04,0.17,1.18,0.68c0.13,0.51-0.17,1.04-0.69,1.19l-8.86,2.36 l-1.66-2.88L8.14,12.53z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M20.19,4H4C2.9,4,2.01,4.9,2.01,6v4C3.11,10,4,10.9,4,12s-0.89,2-2,2v4c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6 C22,4.9,21.19,4,20.19,4z M20,18H4v-2.54c1.19-0.69,2-1.99,2-3.46c0-1.48-0.8-2.77-1.99-3.46L4,6h16V18z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M17.73,13.3c0.52-0.15,0.82-0.68,0.69-1.19c-0.14-0.51-0.67-0.82-1.18-0.68l-2.44,0.65l-4.01-3.74l-1.4,0.38l2.4,4.16 L9.4,13.52l-1.26-0.99l-0.93,0.25l1.66,2.88L17.73,13.3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
