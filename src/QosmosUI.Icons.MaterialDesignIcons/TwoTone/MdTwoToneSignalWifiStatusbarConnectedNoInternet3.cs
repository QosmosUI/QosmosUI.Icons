// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSignalWifiStatusbarConnectedNoInternet3 : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M17,9V8h5.92C19.97,5.51,16.16,4,12,4C7.31,4,3.07,5.9,0,8.98l2.82,2.82C5.17,9.45,8.41,8,12,8 C13.77,8,15.46,8.36,17,9z");
		builder.AddAttribute(20, "fill-opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M2.82,11.8L12,21l5-5.01V9c-1.54-0.64-3.23-1-5-1C8.41,8,5.17,9.45,2.82,11.8z");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "2");
		builder.AddAttribute(26, "width", "2");
		builder.AddAttribute(27, "x", "19");
		builder.AddAttribute(28, "y", "18");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "height", "6");
		builder.AddAttribute(31, "width", "2");
		builder.AddAttribute(32, "x", "19");
		builder.AddAttribute(33, "y", "10");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
