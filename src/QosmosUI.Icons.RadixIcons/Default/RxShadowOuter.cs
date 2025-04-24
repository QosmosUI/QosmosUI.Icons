// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxShadowOuter : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "opacity", ".05");
		builder.AddAttribute(15, "fill-rule", "evenodd");
		builder.AddAttribute(16, "clip-rule", "evenodd");
		builder.AddAttribute(17, "d", "M12.1398 3.88617C13.8553 4.94159 15 6.83701 15 9.00001C15 12.3137 12.3137 15 9.00002 15C6.84351 15 4.95296 13.8621 3.89569 12.1552L4.32076 11.8919C5.29069 13.4578 7.02376 14.5 9.00002 14.5C12.0376 14.5 14.5 12.0375 14.5 9.00001C14.5 7.01781 13.4516 5.28027 11.8778 4.31203L12.1398 3.88617Z");
		builder.AddAttribute(18, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "opacity", ".2");
		builder.AddAttribute(21, "fill-rule", "evenodd");
		builder.AddAttribute(22, "clip-rule", "evenodd");
		builder.AddAttribute(23, "d", "M12.851 5.07321C13.8684 6.07106 14.5 7.46199 14.5 9C14.5 12.0375 12.0376 14.5 9.00004 14.5C7.46215 14.5 6.07132 13.8685 5.07349 12.8513L5.43043 12.5011C6.3381 13.4264 7.60186 14 9.00004 14C11.7614 14 14 11.7614 14 9C14 7.60171 13.4264 6.33786 12.5009 5.43017L12.851 5.07321Z");
		builder.AddAttribute(24, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "opacity", ".35");
		builder.AddAttribute(27, "fill-rule", "evenodd");
		builder.AddAttribute(28, "clip-rule", "evenodd");
		builder.AddAttribute(29, "d", "M13.3022 6.45071C13.7455 7.19737 14 8.06935 14 9.00001C14 11.7614 11.7614 14 9.00002 14C8.04868 14 7.15868 13.7341 6.40118 13.2724L6.66142 12.8454C7.34275 13.2607 8.14306 13.5 9.00002 13.5C11.4853 13.5 13.5 11.4853 13.5 9.00001C13.5 8.16165 13.271 7.37754 12.8722 6.70599L13.3022 6.45071Z");
		builder.AddAttribute(30, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "opacity", ".5");
		builder.AddAttribute(33, "fill-rule", "evenodd");
		builder.AddAttribute(34, "clip-rule", "evenodd");
		builder.AddAttribute(35, "d", "M13.3745 7.94022C13.4566 8.28031 13.5 8.63525 13.5 9.00001C13.5 11.4853 11.4853 13.5 9.00003 13.5C8.61104 13.5 8.23323 13.4506 7.87268 13.3576L7.99759 12.8734C8.31768 12.956 8.65353 13 9.00003 13C11.2091 13 13 11.2091 13 9.00001C13 8.67509 12.9613 8.35953 12.8884 8.05757L13.3745 7.94022Z");
		builder.AddAttribute(36, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "opacity", ".65");
		builder.AddAttribute(39, "fill-rule", "evenodd");
		builder.AddAttribute(40, "clip-rule", "evenodd");
		builder.AddAttribute(41, "d", "M12.9155 9.82133C12.5898 11.3813 11.3562 12.6072 9.79205 12.9215L9.69354 12.4313C11.0613 12.1565 12.1413 11.0834 12.4261 9.71915L12.9155 9.82133Z");
		builder.AddAttribute(42, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "fill-rule", "evenodd");
		builder.AddAttribute(45, "clip-rule", "evenodd");
		builder.AddAttribute(46, "d", "M1.2771 7.50253C1.2771 4.06456 4.06413 1.27753 7.5021 1.27753C10.94 1.27753 13.7271 4.06456 13.7271 7.50253C13.7271 10.9405 10.94 13.7275 7.5021 13.7275C4.06413 13.7275 1.2771 10.9405 1.2771 7.50253ZM7.5021 2.22753C4.5888 2.22753 2.2271 4.58923 2.2271 7.50253C2.2271 10.4158 4.5888 12.7775 7.5021 12.7775C10.4154 12.7775 12.7771 10.4158 12.7771 7.50253C12.7771 4.58923 10.4154 2.22753 7.5021 2.22753Z");
		builder.AddAttribute(47, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
