// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDirectionsBus : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M17.37 17l.29-.27c.13-.11.34-.36.34-.73v-4H6v4c0 .37.21.62.34.73l.29.27h10.74zM8.5 16c-.83 0-1.5-.67-1.5-1.5S7.67 13 8.5 13s1.5.67 1.5 1.5S9.33 16 8.5 16zm5.5-1.5c0-.83.67-1.5 1.5-1.5s1.5.67 1.5 1.5-.67 1.5-1.5 1.5-1.5-.67-1.5-1.5zM12 4c-3.69 0-5.11.46-5.66.99h11.31C17.11 4.46 15.69 4 12 4z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M17 21h1c.55 0 1-.45 1-1v-1.78c.61-.55 1-1.34 1-2.22V6c0-3.5-3.58-4-8-4s-8 .5-8 4v10c0 .88.39 1.67 1 2.22V20c0 .55.45 1 1 1h1c.55 0 1-.45 1-1v-1h8v1c0 .55.45 1 1 1zM12 4c3.69 0 5.11.46 5.66.99H6.34C6.89 4.46 8.31 4 12 4zM6 6.99h12V10H6V6.99zM8 17H6.63l-.29-.27C6.21 16.62 6 16.37 6 16v-4h12v4c0 .37-.21.62-.34.73l-.29.27H8z");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "8.5");
		builder.AddAttribute(23, "cy", "14.5");
		builder.AddAttribute(24, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "15.5");
		builder.AddAttribute(27, "cy", "14.5");
		builder.AddAttribute(28, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
