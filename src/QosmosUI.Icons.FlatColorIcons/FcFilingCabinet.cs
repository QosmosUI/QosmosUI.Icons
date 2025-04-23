// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcFilingCabinet : ComponentBase
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
		builder.AddAttribute(14, "x", "12");
		builder.AddAttribute(15, "y", "44");
		builder.AddAttribute(16, "fill", "#263238");
		builder.AddAttribute(17, "width", "4");
		builder.AddAttribute(18, "height", "2");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "32");
		builder.AddAttribute(21, "y", "44");
		builder.AddAttribute(22, "fill", "#263238");
		builder.AddAttribute(23, "width", "4");
		builder.AddAttribute(24, "height", "2");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#607D8B");
		builder.AddAttribute(27, "d", "M8,41V7c0-2.2,1.8-4,4-4h24c2.2,0,4,1.8,4,4v34c0,2.2-1.8,4-4,4H12C9.8,45,8,43.2,8,41z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#B0BEC5");
		builder.AddAttribute(30, "d", "M12,17V8c0-0.6,0.4-1,1-1h22c0.6,0,1,0.4,1,1v9H12z");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "12");
		builder.AddAttribute(33, "y", "19");
		builder.AddAttribute(34, "fill", "#B0BEC5");
		builder.AddAttribute(35, "width", "24");
		builder.AddAttribute(36, "height", "10");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#B0BEC5");
		builder.AddAttribute(39, "d", "M12,40v-9h24v9c0,0.6-0.4,1-1,1H13C12.4,41,12,40.6,12,40z");
		builder.CloseElement();
		builder.OpenElement(40, "rect");
		builder.AddAttribute(41, "x", "20");
		builder.AddAttribute(42, "y", "11");
		builder.AddAttribute(43, "fill", "#546E7A");
		builder.AddAttribute(44, "width", "8");
		builder.AddAttribute(45, "height", "2");
		builder.CloseElement();
		builder.OpenElement(46, "rect");
		builder.AddAttribute(47, "x", "20");
		builder.AddAttribute(48, "y", "23");
		builder.AddAttribute(49, "fill", "#546E7A");
		builder.AddAttribute(50, "width", "8");
		builder.AddAttribute(51, "height", "2");
		builder.CloseElement();
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "x", "20");
		builder.AddAttribute(54, "y", "35");
		builder.AddAttribute(55, "fill", "#546E7A");
		builder.AddAttribute(56, "width", "8");
		builder.AddAttribute(57, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
