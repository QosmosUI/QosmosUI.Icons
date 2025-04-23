// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcMultipleInputs : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#90A4AE");
		builder.AddAttribute(15, "d", "M40,35v5H8v-5H4v5c0,2.2,1.8,4,4,4h32c2.2,0,4-1.8,4-4v-5H40z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#1565C0");
		builder.OpenElement(18, "polygon");
		builder.AddAttribute(19, "points", "24,23.4 17,15 31,15");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "22");
		builder.AddAttribute(22, "y", "4");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "height", "14");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M31.5,26.9L30.8,28l3.5,1.9l0.6-1.2c1.6-3,2.6-4.7,3.5-5.2C39.3,23,41,23,44,23v-4 C36.3,19,35.6,19.4,31.5,26.9z");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "points", "38.4,31 29.4,35 28,25");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M16.5,26.9l0.6,1.2L13.6,30L13,28.8c-1.6-3-2.6-4.7-3.5-5.2C8.7,23,7,23,4,23v-4 C11.7,19,12.4,19.4,16.5,26.9z");
		builder.CloseElement();
		builder.OpenElement(31, "polygon");
		builder.AddAttribute(32, "points", "20,25 18.6,35 9.6,31");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
