// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBackupTable : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "height", "5");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "width", "5");
		builder.AddAttribute(24, "x", "11");
		builder.AddAttribute(25, "y", "11");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "5");
		builder.AddAttribute(28, "opacity", ".3");
		builder.AddAttribute(29, "width", "5");
		builder.AddAttribute(30, "x", "4");
		builder.AddAttribute(31, "y", "11");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "5");
		builder.AddAttribute(34, "opacity", ".3");
		builder.AddAttribute(35, "width", "12");
		builder.AddAttribute(36, "x", "4");
		builder.AddAttribute(37, "y", "4");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M20,6v14H6v2h14c1.1,0,2-0.9,2-2V6H20z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M18,16V4c0-1.1-0.9-2-2-2H4C2.9,2,2,2.9,2,4v12c0,1.1,0.9,2,2,2h12C17.1,18,18,17.1,18,16z M4,4h12v5H4V4z M9,16H4v-5h5 V16z M11,11h5v5h-5V11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
