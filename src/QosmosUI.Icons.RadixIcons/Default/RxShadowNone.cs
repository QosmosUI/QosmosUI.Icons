// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxShadowNone : ComponentBase
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
		builder.AddAttribute(17, "d", "M6.78296 13.376C8.73904 9.95284 8.73904 5.04719 6.78296 1.62405L7.21708 1.37598C9.261 4.95283 9.261 10.0472 7.21708 13.624L6.78296 13.376Z");
		builder.AddAttribute(18, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "opacity", ".1");
		builder.AddAttribute(21, "fill-rule", "evenodd");
		builder.AddAttribute(22, "clip-rule", "evenodd");
		builder.AddAttribute(23, "d", "M7.28204 13.4775C9.23929 9.99523 9.23929 5.00475 7.28204 1.52248L7.71791 1.2775C9.76067 4.9119 9.76067 10.0881 7.71791 13.7225L7.28204 13.4775Z");
		builder.AddAttribute(24, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "opacity", ".15");
		builder.AddAttribute(27, "fill-rule", "evenodd");
		builder.AddAttribute(28, "clip-rule", "evenodd");
		builder.AddAttribute(29, "d", "M7.82098 13.5064C9.72502 9.99523 9.72636 5.01411 7.82492 1.50084L8.26465 1.26285C10.2465 4.92466 10.2451 10.085 8.26052 13.7448L7.82098 13.5064Z");
		builder.AddAttribute(30, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "opacity", ".2");
		builder.AddAttribute(33, "fill-rule", "evenodd");
		builder.AddAttribute(34, "clip-rule", "evenodd");
		builder.AddAttribute(35, "d", "M8.41284 13.429C10.1952 9.92842 10.1957 5.07537 8.41435 1.57402L8.85999 1.34729C10.7139 4.99113 10.7133 10.0128 8.85841 13.6559L8.41284 13.429Z");
		builder.AddAttribute(36, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "opacity", ".25");
		builder.AddAttribute(39, "fill-rule", "evenodd");
		builder.AddAttribute(40, "clip-rule", "evenodd");
		builder.AddAttribute(41, "d", "M9.02441 13.2956C10.6567 9.8379 10.6586 5.17715 9.03005 1.71656L9.48245 1.50366C11.1745 5.09919 11.1726 9.91629 9.47657 13.5091L9.02441 13.2956Z");
		builder.AddAttribute(42, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "opacity", ".3");
		builder.AddAttribute(45, "fill-rule", "evenodd");
		builder.AddAttribute(46, "clip-rule", "evenodd");
		builder.AddAttribute(47, "d", "M9.66809 13.0655C11.1097 9.69572 11.1107 5.3121 9.67088 1.94095L10.1307 1.74457C11.6241 5.24121 11.6231 9.76683 10.1278 13.2622L9.66809 13.0655Z");
		builder.AddAttribute(48, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "opacity", ".35");
		builder.AddAttribute(51, "fill-rule", "evenodd");
		builder.AddAttribute(52, "clip-rule", "evenodd");
		builder.AddAttribute(53, "d", "M10.331 12.7456C11.5551 9.52073 11.5564 5.49103 10.3347 2.26444L10.8024 2.0874C12.0672 5.42815 12.0659 9.58394 10.7985 12.9231L10.331 12.7456Z");
		builder.AddAttribute(54, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(55, "path");
		builder.AddAttribute(56, "opacity", ".4");
		builder.AddAttribute(57, "fill-rule", "evenodd");
		builder.AddAttribute(58, "clip-rule", "evenodd");
		builder.AddAttribute(59, "d", "M11.0155 12.2986C11.9938 9.29744 11.9948 5.71296 11.0184 2.71067L11.4939 2.55603C12.503 5.6589 12.502 9.35178 11.4909 12.4535L11.0155 12.2986Z");
		builder.AddAttribute(60, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(61, "path");
		builder.AddAttribute(62, "opacity", ".45");
		builder.AddAttribute(63, "fill-rule", "evenodd");
		builder.AddAttribute(64, "clip-rule", "evenodd");
		builder.AddAttribute(65, "d", "M11.7214 11.668C12.4254 9.01303 12.4262 5.99691 11.7237 3.34116L12.2071 3.21329C12.9318 5.95292 12.931 9.05728 12.2047 11.7961L11.7214 11.668Z");
		builder.AddAttribute(66, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(67, "path");
		builder.AddAttribute(68, "opacity", ".5");
		builder.AddAttribute(69, "fill-rule", "evenodd");
		builder.AddAttribute(70, "clip-rule", "evenodd");
		builder.AddAttribute(71, "d", "M12.4432 10.752C12.8524 8.63762 12.8523 6.36089 12.4429 4.2466L12.9338 4.15155C13.3553 6.32861 13.3554 8.66985 12.9341 10.847L12.4432 10.752Z");
		builder.AddAttribute(72, "fill", "currentColor");
		builder.CloseElement();
		builder.OpenElement(73, "path");
		builder.AddAttribute(74, "fill-rule", "evenodd");
		builder.AddAttribute(75, "clip-rule", "evenodd");
		builder.AddAttribute(76, "d", "M7.49991 0.877045C3.84222 0.877045 0.877075 3.84219 0.877075 7.49988C0.877075 9.1488 1.47969 10.657 2.4767 11.8162L1.64647 12.6464C1.45121 12.8417 1.45121 13.1583 1.64647 13.3535C1.84173 13.5488 2.15832 13.5488 2.35358 13.3535L3.18383 12.5233C4.34302 13.5202 5.8511 14.1227 7.49991 14.1227C11.1576 14.1227 14.1227 11.1575 14.1227 7.49988C14.1227 5.85107 13.5202 4.34298 12.5233 3.1838L13.3536 2.35355C13.5488 2.15829 13.5488 1.8417 13.3536 1.64644C13.1583 1.45118 12.8417 1.45118 12.6465 1.64644L11.8162 2.47667C10.657 1.47966 9.14883 0.877045 7.49991 0.877045ZM11.1423 3.15065C10.1568 2.32449 8.88644 1.82704 7.49991 1.82704C4.36689 1.82704 1.82708 4.36686 1.82708 7.49988C1.82708 8.88641 2.32452 10.1568 3.15069 11.1422L11.1423 3.15065ZM3.85781 11.8493C4.84322 12.6753 6.11348 13.1727 7.49991 13.1727C10.6329 13.1727 13.1727 10.6329 13.1727 7.49988C13.1727 6.11345 12.6754 4.84319 11.8493 3.85778L3.85781 11.8493Z");
		builder.AddAttribute(77, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
