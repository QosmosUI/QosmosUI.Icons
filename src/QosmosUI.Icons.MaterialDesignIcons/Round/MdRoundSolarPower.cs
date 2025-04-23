// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSolarPower : ComponentBase
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
		builder.AddAttribute(25, "d", "M3.33,16H11v-3H5.6c-0.94,0-1.75,0.65-1.95,1.57L3.33,16z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M13,16h7.67l-0.32-1.43C20.14,13.65,19.33,13,18.4,13H13V16z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M21.11,18H13v4h6.51c1.28,0,2.23-1.18,1.95-2.43L21.11,18z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M4.49,22H11v-4H2.89l-0.35,1.57C2.26,20.82,3.21,22,4.49,22z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M12,8L12,8c-0.55,0-1,0.45-1,1v1c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V9C13,8.45,12.55,8,12,8z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M18.59,8.62L18.59,8.62c0.39-0.39,0.39-1.02,0-1.41L17.88,6.5c-0.39-0.39-1.02-0.39-1.41,0v0c-0.39,0.39-0.39,1.02,0,1.41 l0.71,0.71C17.57,9.01,18.2,9.01,18.59,8.62z");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M6.82,8.62l0.71-0.71c0.39-0.39,0.39-1.02,0-1.41l0,0c-0.39-0.39-1.02-0.39-1.41,0L5.41,7.2c-0.39,0.39-0.39,1.02,0,1.41 l0,0C5.8,9.01,6.43,9.01,6.82,8.62z");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M5,2H4C3.45,2,3,2.45,3,3v0c0,0.55,0.45,1,1,1h1c0.55,0,1-0.45,1-1v0C6,2.45,5.55,2,5,2z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M20,2h-1c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h1c0.55,0,1-0.45,1-1v0C21,2.45,20.55,2,20,2z");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M12,7c2.76,0,5-2.24,5-5H7C7,4.76,9.24,7,12,7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
