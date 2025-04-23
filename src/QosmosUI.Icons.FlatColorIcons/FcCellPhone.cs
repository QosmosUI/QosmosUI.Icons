// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcCellPhone : ComponentBase
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
		builder.AddAttribute(14, "fill", "#546E7A");
		builder.AddAttribute(15, "d", "M12,40V10h20c2.2,0,4,1.8,4,4v26c0,2.2-1.8,4-4,4H16C13.8,44,12,42.2,12,40z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#4FC3F7");
		builder.AddAttribute(18, "d", "M32,13H16c-0.6,0-1,0.4-1,1v8c0,0.6,0.4,1,1,1h16c0.6,0,1-0.4,1-1v-8C33,13.4,32.6,13,32,13z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#B3E5FC");
		builder.AddAttribute(21, "d", "M19,30h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C20,29.6,19.6,30,19,30z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#B3E5FC");
		builder.AddAttribute(24, "d", "M25,30h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C26,29.6,25.6,30,25,30z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#B3E5FC");
		builder.AddAttribute(27, "d", "M31,30h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C32,29.6,31.6,30,31,30z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#B3E5FC");
		builder.AddAttribute(30, "d", "M19,35h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C20,34.6,19.6,35,19,35z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "fill", "#B3E5FC");
		builder.AddAttribute(33, "d", "M25,35h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C26,34.6,25.6,35,25,35z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "fill", "#B3E5FC");
		builder.AddAttribute(36, "d", "M31,35h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C32,34.6,31.6,35,31,35z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#B3E5FC");
		builder.AddAttribute(39, "d", "M19,40h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C20,39.6,19.6,40,19,40z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "fill", "#B3E5FC");
		builder.AddAttribute(42, "d", "M25,40h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C26,39.6,25.6,40,25,40z");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "fill", "#B3E5FC");
		builder.AddAttribute(45, "d", "M31,40h-2c-0.6,0-1-0.4-1-1v-1c0-0.6,0.4-1,1-1h2c0.6,0,1,0.4,1,1v1C32,39.6,31.6,40,31,40z");
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "fill", "#37474F");
		builder.AddAttribute(48, "d", "M16,10h-4V4c0-1.1,0.9-2,2-2h0c1.1,0,2,0.9,2,2V10z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
