// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxShadowInner : ComponentBase
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
		builder.AddAttribute(17, "d", "M12.1619 3.85182C8.35817 4.88918 4.88936 8.358 3.85199 12.1617L3.3696 12.0301C4.45356 8.05564 8.05581 4.45339 12.0303 3.36943L12.1619 3.85182Z");
		builder.AddAttribute(18, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "opacity", ".1");
		builder.AddAttribute(21, "fill-rule", "evenodd");
		builder.AddAttribute(22, "clip-rule", "evenodd");
		builder.AddAttribute(23, "d", "M11.8807 3.42707C8.03441 4.50542 4.50561 8.03422 3.42726 11.8805L2.94582 11.7456C4.07129 7.73121 7.7314 4.0711 11.7458 2.94563L11.8807 3.42707Z");
		builder.AddAttribute(24, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "opacity", ".15");
		builder.AddAttribute(27, "fill-rule", "evenodd");
		builder.AddAttribute(28, "clip-rule", "evenodd");
		builder.AddAttribute(29, "d", "M11.5201 3.02556C7.69092 4.16199 4.16779 7.68323 3.02805 11.512L2.54883 11.3694C3.73676 7.37869 7.38659 3.73076 11.3778 2.54623L11.5201 3.02556Z");
		builder.AddAttribute(30, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "opacity", ".2");
		builder.AddAttribute(33, "fill-rule", "evenodd");
		builder.AddAttribute(34, "clip-rule", "evenodd");
		builder.AddAttribute(35, "d", "M11.0468 2.66169C7.31117 3.87664 3.87918 7.3079 2.66298 11.0434L2.18754 10.8886C3.45324 7.00109 7.00445 3.45062 10.8921 2.18621L11.0468 2.66169Z");
		builder.AddAttribute(36, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "opacity", ".25");
		builder.AddAttribute(39, "fill-rule", "evenodd");
		builder.AddAttribute(40, "clip-rule", "evenodd");
		builder.AddAttribute(41, "d", "M10.5201 2.32365C6.92091 3.61447 3.62391 6.90876 2.32845 10.5073L1.858 10.338C3.20398 6.59909 6.61155 3.19424 10.3513 1.85301L10.5201 2.32365Z");
		builder.AddAttribute(42, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "opacity", ".3");
		builder.AddAttribute(45, "fill-rule", "evenodd");
		builder.AddAttribute(46, "clip-rule", "evenodd");
		builder.AddAttribute(47, "d", "M9.90222 2.03122C6.50003 3.39465 3.39968 6.49367 2.03399 9.89551L1.56998 9.70924C2.98651 6.18076 6.18728 2.98133 9.71622 1.5671L9.90222 2.03122Z");
		builder.AddAttribute(48, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "opacity", ".35");
		builder.AddAttribute(51, "fill-rule", "evenodd");
		builder.AddAttribute(52, "clip-rule", "evenodd");
		builder.AddAttribute(53, "d", "M9.20727 1.78873C6.06136 3.20349 3.21103 6.05203 1.79331 9.19738L1.33747 8.99192C2.80536 5.73528 5.74485 2.7976 9.0022 1.33272L9.20727 1.78873Z");
		builder.AddAttribute(54, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(55, "path");
		builder.AddAttribute(56, "opacity", ".4");
		builder.AddAttribute(57, "fill-rule", "evenodd");
		builder.AddAttribute(58, "clip-rule", "evenodd");
		builder.AddAttribute(59, "d", "M8.40713 1.62085C5.59323 3.05117 3.05794 5.58509 1.62544 8.39847L1.17987 8.1716C2.66036 5.26397 5.27232 2.6534 8.18057 1.17513L8.40713 1.62085Z");
		builder.AddAttribute(60, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(61, "path");
		builder.AddAttribute(62, "opacity", ".45");
		builder.AddAttribute(63, "fill-rule", "evenodd");
		builder.AddAttribute(64, "clip-rule", "evenodd");
		builder.AddAttribute(65, "d", "M7.46207 1.56747C5.08689 2.94695 2.95362 5.07912 1.57249 7.45379L1.14028 7.20241C2.56503 4.75273 4.7607 2.55818 7.21096 1.1351L7.46207 1.56747Z");
		builder.AddAttribute(66, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(67, "path");
		builder.AddAttribute(68, "opacity", ".5");
		builder.AddAttribute(69, "fill-rule", "evenodd");
		builder.AddAttribute(70, "clip-rule", "evenodd");
		builder.AddAttribute(71, "d", "M6.30407 1.70487C4.51964 2.91063 2.90983 4.52061 1.7043 6.30513L1.28998 6.02524C2.5313 4.18773 4.18673 2.53214 6.02413 1.29059L6.30407 1.70487Z");
		builder.AddAttribute(72, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(73, "path");
		builder.AddAttribute(74, "fill-rule", "evenodd");
		builder.AddAttribute(75, "clip-rule", "evenodd");
		builder.AddAttribute(76, "d", "M0.877075 7.49988C0.877075 3.84219 3.84222 0.877045 7.49991 0.877045C11.1576 0.877045 14.1227 3.84219 14.1227 7.49988C14.1227 11.1575 11.1576 14.1227 7.49991 14.1227C3.84222 14.1227 0.877075 11.1575 0.877075 7.49988ZM7.49991 1.82704C4.36689 1.82704 1.82708 4.36686 1.82708 7.49988C1.82708 10.6329 4.36689 13.1727 7.49991 13.1727C10.6329 13.1727 13.1727 10.6329 13.1727 7.49988C13.1727 4.36686 10.6329 1.82704 7.49991 1.82704Z");
		builder.AddAttribute(77, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
