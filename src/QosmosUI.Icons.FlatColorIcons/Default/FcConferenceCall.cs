// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcConferenceCall : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "fill", "#FFA726");
		builder.AddAttribute(15, "cx", "12");
		builder.AddAttribute(16, "cy", "21");
		builder.AddAttribute(17, "r", "5");
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.AddAttribute(19, "fill", "#455A64");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M2,34.7c0,0,2.8-6.3,10-6.3s10,6.3,10,6.3V38H2V34.7z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M46,34.7c0,0-2.8-6.3-10-6.3s-10,6.3-10,6.3V38h20V34.7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "fill", "#FFB74D");
		builder.AddAttribute(26, "cx", "24");
		builder.AddAttribute(27, "cy", "17");
		builder.AddAttribute(28, "r", "6");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "fill", "#607D8B");
		builder.AddAttribute(31, "d", "M36,34.1c0,0-3.3-7.5-12-7.5s-12,7.5-12,7.5V38h24V34.1z");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "fill", "#FFA726");
		builder.AddAttribute(34, "cx", "36");
		builder.AddAttribute(35, "cy", "21");
		builder.AddAttribute(36, "r", "5");
		builder.CloseElement();
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "fill", "#FFA726");
		builder.AddAttribute(39, "cx", "12");
		builder.AddAttribute(40, "cy", "21");
		builder.AddAttribute(41, "r", "5");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "fill", "#FFA726");
		builder.AddAttribute(44, "cx", "36");
		builder.AddAttribute(45, "cy", "21");
		builder.AddAttribute(46, "r", "5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
