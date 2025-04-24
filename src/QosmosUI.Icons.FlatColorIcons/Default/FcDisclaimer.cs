// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcDisclaimer : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#FFCC80");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M13,22H8v-8.5c0-1.4,1.1-2.5,2.5-2.5h0c1.4,0,2.5,1.1,2.5,2.5V22z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20,22h-5V7.5C15,6.1,16.1,5,17.5,5h0C18.9,5,20,6.1,20,7.5V22z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M27,22h-5V5.5C22,4.1,23.1,3,24.5,3h0C25.9,3,27,4.1,27,5.5V22z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M34,22h-5V8.5C29,7.1,30.1,6,31.5,6h0C32.9,6,34,7.1,34,8.5V22z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M32.1,43L27.1,38l10-10c1.4-1.4,3.6-1.4,4.9,0l0,0c1.4,1.4,1.4,3.6,0,4.9L32.1,43z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M29,21c0,0.6-0.4,1-1,1s-1-0.4-1-1h-5c0,0.6-0.4,1-1,1s-1-0.4-1-1h-5c0,0.6-0.4,1-1,1s-1-0.4-1-1H8v16 c0,4.4,3.6,8,8,8h11.2c3.7,0,6.8-3,6.8-6.8V21H29z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.AddAttribute(28, "fill", "#F44336");
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "20.2");
		builder.AddAttribute(31, "y", "25.5");
		builder.AddAttribute(32, "transform", "matrix(.707 -.707 .707 .707 -16.897 25.224)");
		builder.AddAttribute(33, "width", "3.5");
		builder.AddAttribute(34, "height", "15");
		builder.CloseElement();
		builder.OpenElement(35, "rect");
		builder.AddAttribute(36, "x", "20.2");
		builder.AddAttribute(37, "y", "25.6");
		builder.AddAttribute(38, "transform", "matrix(.707 .707 -.707 .707 29.811 -5.877)");
		builder.AddAttribute(39, "width", "3.5");
		builder.AddAttribute(40, "height", "15");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
