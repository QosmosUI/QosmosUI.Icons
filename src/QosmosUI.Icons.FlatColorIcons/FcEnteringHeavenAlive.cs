// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcEnteringHeavenAlive : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "17");
		builder.AddAttribute(15, "y", "29");
		builder.AddAttribute(16, "fill", "#039BE5");
		builder.AddAttribute(17, "width", "14");
		builder.AddAttribute(18, "height", "2");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "13");
		builder.AddAttribute(21, "y", "33");
		builder.AddAttribute(22, "fill", "#039BE5");
		builder.AddAttribute(23, "width", "22");
		builder.AddAttribute(24, "height", "2");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "9");
		builder.AddAttribute(27, "y", "37");
		builder.AddAttribute(28, "fill", "#039BE5");
		builder.AddAttribute(29, "width", "30");
		builder.AddAttribute(30, "height", "2");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "5");
		builder.AddAttribute(33, "y", "41");
		builder.AddAttribute(34, "fill", "#039BE5");
		builder.AddAttribute(35, "width", "38");
		builder.AddAttribute(36, "height", "2");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#81D4FA");
		builder.AddAttribute(39, "d", "M35,13c-0.4,0-0.8,0-1.2,0.1C32.9,8.5,28.9,5,24,5c-4.1,0-7.6,2.5-9.2,6c-0.3,0-0.5,0-0.8,0 c-4.4,0-8,3.6-8,8s3.6,8,8,8c2.4,0,18.5,0,21,0c3.9,0,7-3.1,7-7C42,16.1,38.9,13,35,13z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "fill", "#039BE5");
		builder.AddAttribute(42, "d", "M28,21c0-2.2-1.8-4-4-4s-4,1.8-4,4c0,0.5,0,6,0,6h8C28,27,28,21.5,28,21z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
