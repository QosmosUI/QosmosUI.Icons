// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFort : ComponentBase
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
		builder.AddAttribute(25, "d", "M21,4v1h-2V4c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v1h-2V4c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v2.17 c0,0.53,0.21,1.04,0.59,1.41L15,9v1H9V9l1.41-1.41C10.79,7.21,11,6.7,11,6.17V4c0-0.55-0.45-1-1-1h0C9.45,3,9,3.45,9,4v1H7V4 c0-0.55-0.45-1-1-1h0C5.45,3,5,3.45,5,4v1H3V4c0-0.55-0.45-1-1-1h0C1.45,3,1,3.45,1,4v2.17C1,6.7,1.21,7.21,1.59,7.59L3,9v6 l-1.41,1.41C1.21,16.79,1,17.3,1,17.83V19c0,1.1,0.9,2,2,2h7l0-2.89c0-1,0.68-1.92,1.66-2.08C12.92,15.82,14,16.79,14,18v3h7 c1.1,0,2-0.9,2-2v-1.17c0-0.53-0.21-1.04-0.59-1.41L21,15V9l1.41-1.41C22.79,7.21,23,6.7,23,6.17V4c0-0.55-0.45-1-1-1h0 C21.45,3,21,3.45,21,4z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
