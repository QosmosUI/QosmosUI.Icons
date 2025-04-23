// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneLiquor : ComponentBase
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
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "height", "1");
		builder.AddAttribute(23, "opacity", ".3");
		builder.AddAttribute(24, "width", "1");
		builder.AddAttribute(25, "x", "16");
		builder.AddAttribute(26, "y", "4");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M6,15c0.55,0,1-0.45,1-1v-1H5v1C5,14.55,5.45,15,6,15z");
		builder.AddAttribute(29, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "2");
		builder.AddAttribute(32, "opacity", ".3");
		builder.AddAttribute(33, "width", "7");
		builder.AddAttribute(34, "x", "13");
		builder.AddAttribute(35, "y", "14");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M3,14c0,1.3,0.84,2.4,2,2.82V20H3v2h6v-2H7v-3.18C8.16,16.4,9,15.3,9,14V6H3V14z M5,8h2v3H5V8z M5,13h2v1 c0,0.55-0.45,1-1,1s-1-0.45-1-1V13z");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M20.64,8.54l-0.96-0.32C19.27,8.08,19,7.7,19,7.27V3c0-0.55-0.45-1-1-1h-3c-0.55,0-1,0.45-1,1v4.28 c0,0.43-0.27,0.81-0.68,0.95l-0.96,0.32C11.55,8.83,11,9.59,11,10.45V20c0,1.1,0.9,2,2,2h7c1.1,0,2-0.9,2-2v-9.56 C22,9.58,21.45,8.82,20.64,8.54z M16,4h1v1h-1V4z M20,20h-7v-2h7V20z M20,16h-7v-2h7V16z M20,12h-7v-1.56l0.95-0.32 C15.18,9.72,16,8.57,16,7.28V7h1v0.28c0,1.29,0.82,2.44,2.05,2.85L20,10.44V12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
