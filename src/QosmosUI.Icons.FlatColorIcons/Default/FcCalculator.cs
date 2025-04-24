// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcCalculator : ComponentBase
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
		builder.AddAttribute(14, "fill", "#616161");
		builder.AddAttribute(15, "d", "M40,16H8v24c0,2.2,1.8,4,4,4h24c2.2,0,4-1.8,4-4V16z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#424242");
		builder.AddAttribute(18, "d", "M36,4H12C9.8,4,8,5.8,8,8v9h32V8C40,5.8,38.2,4,36,4z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#9CCC65");
		builder.AddAttribute(21, "d", "M36,14H12c-0.6,0-1-0.4-1-1V8c0-0.6,0.4-1,1-1h24c0.6,0,1,0.4,1,1v5C37,13.6,36.6,14,36,14z");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#33691E");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "33");
		builder.AddAttribute(26, "y", "10");
		builder.AddAttribute(27, "width", "2");
		builder.AddAttribute(28, "height", "2");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "29");
		builder.AddAttribute(31, "y", "10");
		builder.AddAttribute(32, "width", "2");
		builder.AddAttribute(33, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "fill", "#FF5252");
		builder.AddAttribute(36, "d", "M36,23h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C37,22.6,36.6,23,36,23z");
		builder.CloseElement();
		builder.OpenElement(37, "g");
		builder.AddAttribute(38, "fill", "#E0E0E0");
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M15,23h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C16,22.6,15.6,23,15,23z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M22,23h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C23,22.6,22.6,23,22,23z");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M29,23h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C30,22.6,29.6,23,29,23z");
		builder.CloseElement();
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M15,29h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C16,28.6,15.6,29,15,29z");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M22,29h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C23,28.6,22.6,29,22,29z");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "d", "M29,29h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C30,28.6,29.6,29,29,29z");
		builder.CloseElement();
		builder.OpenElement(51, "path");
		builder.AddAttribute(52, "d", "M15,35h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C16,34.6,15.6,35,15,35z");
		builder.CloseElement();
		builder.OpenElement(53, "path");
		builder.AddAttribute(54, "d", "M22,35h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C23,34.6,22.6,35,22,35z");
		builder.CloseElement();
		builder.OpenElement(55, "path");
		builder.AddAttribute(56, "d", "M29,35h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C30,34.6,29.6,35,29,35z");
		builder.CloseElement();
		builder.OpenElement(57, "path");
		builder.AddAttribute(58, "d", "M15,41h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C16,40.6,15.6,41,15,41z");
		builder.CloseElement();
		builder.OpenElement(59, "path");
		builder.AddAttribute(60, "d", "M22,41h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C23,40.6,22.6,41,22,41z");
		builder.CloseElement();
		builder.OpenElement(61, "path");
		builder.AddAttribute(62, "d", "M29,41h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C30,40.6,29.6,41,29,41z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(63, "g");
		builder.AddAttribute(64, "fill", "#BDBDBD");
		builder.OpenElement(65, "path");
		builder.AddAttribute(66, "d", "M36,29h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C37,28.6,36.6,29,36,29z");
		builder.CloseElement();
		builder.OpenElement(67, "path");
		builder.AddAttribute(68, "d", "M36,35h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C37,34.6,36.6,35,36,35z");
		builder.CloseElement();
		builder.OpenElement(69, "path");
		builder.AddAttribute(70, "d", "M36,41h-3c-0.6,0-1-0.4-1-1v-2c0-0.6,0.4-1,1-1h3c0.6,0,1,0.4,1,1v2C37,40.6,36.6,41,36,41z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
