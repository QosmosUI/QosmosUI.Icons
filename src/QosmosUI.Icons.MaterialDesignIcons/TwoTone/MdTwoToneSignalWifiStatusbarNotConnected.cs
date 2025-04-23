// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSignalWifiStatusbarNotConnected : ComponentBase
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
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M18.52,15.16c0.41-0.73,1.18-1.16,1.63-1.8c0.48-0.68,0.21-1.94-1.14-1.94c-0.88,0-1.32,0.67-1.5,1.23l-1.37-0.57 c0.37-1.12,1.38-2.08,2.86-2.08c1.23,0,2.08,0.56,2.51,1.26c0.37,0.6,0.58,1.73,0.01,2.57c-0.63,0.93-1.23,1.21-1.56,1.81 c-0.13,0.24-0.18,0.4-0.18,1.18h-1.52C18.26,16.41,18.19,15.74,18.52,15.16z M17.95,18.95c0-0.59,0.47-1.04,1.05-1.04 c0.59,0,1.04,0.45,1.04,1.04c0,0.58-0.44,1.05-1.04,1.05C18.42,20,17.95,19.53,17.95,18.95z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M14,13c0-2.76,2.24-5,5-5c1.63,0,3.07,0.79,3.98,2L24,8.98C20.93,5.9,16.69,4,12,4 C7.31,4,3.07,5.9,0,8.98L12,21l4.01-4.02C14.8,16.07,14,14.63,14,13z");
		builder.AddAttribute(25, "fill-opacity", ".3");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
