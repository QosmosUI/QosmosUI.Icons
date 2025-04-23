// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcShipped : ComponentBase
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
		builder.AddAttribute(14, "fill", "#8BC34A");
		builder.AddAttribute(15, "d", "M43,36H29V14h10.6c0.9,0,1.6,0.6,1.9,1.4L45,26v8C45,35.1,44.1,36,43,36z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#388E3C");
		builder.AddAttribute(18, "d", "M29,36H5c-1.1,0-2-0.9-2-2V9c0-1.1,0.9-2,2-2h22c1.1,0,2,0.9,2,2V36z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#37474F");
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "37");
		builder.AddAttribute(23, "cy", "36");
		builder.AddAttribute(24, "r", "5");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "13");
		builder.AddAttribute(27, "cy", "36");
		builder.AddAttribute(28, "r", "5");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(29, "g");
		builder.AddAttribute(30, "fill", "#78909C");
		builder.OpenElement(31, "circle");
		builder.AddAttribute(32, "cx", "37");
		builder.AddAttribute(33, "cy", "36");
		builder.AddAttribute(34, "r", "2");
		builder.CloseElement();
		builder.OpenElement(35, "circle");
		builder.AddAttribute(36, "cx", "13");
		builder.AddAttribute(37, "cy", "36");
		builder.AddAttribute(38, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "fill", "#37474F");
		builder.AddAttribute(41, "d", "M41,25h-7c-0.6,0-1-0.4-1-1v-7c0-0.6,0.4-1,1-1h5.3c0.4,0,0.8,0.3,0.9,0.7l1.7,5.2c0,0.1,0.1,0.2,0.1,0.3V24 C42,24.6,41.6,25,41,25z");
		builder.CloseElement();
		builder.OpenElement(42, "polygon");
		builder.AddAttribute(43, "fill", "#DCEDC8");
		builder.AddAttribute(44, "points", "21.8,13.8 13.9,21.7 10.2,17.9 8,20.1 13.9,26 24,15.9");
		builder.CloseElement();
		builder.CloseElement();
    }
}
