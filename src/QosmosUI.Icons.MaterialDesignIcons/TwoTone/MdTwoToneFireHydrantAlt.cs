// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFireHydrantAlt : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,4c-1.47,0-2.75,0.81-3.44,2h6.89C14.75,4.81,13.47,4,12,4z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "circle");
		builder.AddAttribute(24, "cx", "12");
		builder.AddAttribute(25, "cy", "14");
		builder.AddAttribute(26, "opacity", ".3");
		builder.AddAttribute(27, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M16,8H8v5H5v2h3v5h8v-5h3v-2h-3V8z M12,17.5c-1.93,0-3.5-1.57-3.5-3.5s1.57-3.5,3.5-3.5s3.5,1.57,3.5,3.5 S13.93,17.5,12,17.5z");
		builder.AddAttribute(30, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M12,10.5c-1.93,0-3.5,1.57-3.5,3.5s1.57,3.5,3.5,3.5s3.5-1.57,3.5-3.5S13.93,10.5,12,10.5z M12,15.5 c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S12.83,15.5,12,15.5z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M19,11h-1V8h2V6h-2.35C16.83,3.67,14.61,2,12,2S7.17,3.67,6.35,6H4v2h2v3H5c-1.1,0-2,0.9-2,2v2c0,1.1,0.9,2,2,2h1v3H4v2 h16v-2h-2v-3h1c1.1,0,2-0.9,2-2v-2C21,11.9,20.1,11,19,11z M12,4c1.47,0,2.75,0.81,3.44,2H8.56C9.25,4.81,10.53,4,12,4z M19,15h-3 v5H8v-5H5v-2h3V8h8v5h3V15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
