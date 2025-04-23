// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHdrAutoSelect : ComponentBase
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
		builder.AddAttribute(20, "d", "M10,16H7.25c-0.41,0-0.75,0.34-0.75,0.75v4.5C6.5,21.66,6.84,22,7.25,22H10c0.83,0,1.5-0.67,1.5-1.5v-3 C11.5,16.67,10.83,16,10,16z M10,20.5H8v-3h2V20.5z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M4.25,16c-0.41,0-0.75,0.34-0.75,0.75V18h-2v-1.25C1.5,16.34,1.16,16,0.75,16S0,16.34,0,16.75v4.5 C0,21.66,0.34,22,0.75,22s0.75-0.34,0.75-0.75V19.5h2v1.75C3.5,21.66,3.84,22,4.25,22S5,21.66,5,21.25v-4.5 C5,16.34,4.66,16,4.25,16z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M23.25,18.5H22v-1.25c0-0.41-0.34-0.75-0.75-0.75s-0.75,0.34-0.75,0.75v1.25h-1.25c-0.41,0-0.75,0.34-0.75,0.75 S18.84,20,19.25,20h1.25v1.25c0,0.41,0.34,0.75,0.75,0.75S22,21.66,22,21.25V20h1.25c0.41,0,0.75-0.34,0.75-0.75 S23.66,18.5,23.25,18.5z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M16.5,16h-2.75C13.34,16,13,16.34,13,16.75v4.56c0,0.38,0.31,0.69,0.69,0.69h0.11c0.38,0,0.69-0.31,0.69-0.69V20h1.1 l0.72,1.59c0.11,0.25,0.36,0.41,0.63,0.41c0.5,0,0.83-0.51,0.64-0.97L17.1,19.9c0.5-0.3,0.9-0.8,0.9-1.4v-1 C18,16.67,17.33,16,16.5,16z M16.5,18.5h-2v-1h2V18.5z");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "points", "11.97,5.3 10.95,8.19 13.05,8.19 12.03,5.3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M12,2C8.69,2,6,4.69,6,8s2.69,6,6,6s6-2.69,6-6S15.31,2,12,2z M14.44,11c-0.24,0-0.45-0.15-0.53-0.38l-0.49-1.41h-2.83 l-0.5,1.41C10.01,10.85,9.8,11,9.56,11c-0.39,0-0.67-0.39-0.53-0.76l2.12-5.65C11.29,4.23,11.62,4,12,4s0.71,0.23,0.85,0.59 l2.12,5.65C15.11,10.61,14.84,11,14.44,11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
