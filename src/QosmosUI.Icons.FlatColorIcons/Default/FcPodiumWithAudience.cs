// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcPodiumWithAudience : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#B0BEC5");
		builder.AddAttribute(15, "points", "41,12 7,12 6,16 11,19 9,16 39,16 37,19 42,16");
		builder.CloseElement();
		builder.OpenElement(16, "polygon");
		builder.AddAttribute(17, "fill", "#78909C");
		builder.AddAttribute(18, "points", "9,16 39,16 35,28 13,28");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#FFB74D");
		builder.AddAttribute(21, "cx", "24");
		builder.AddAttribute(22, "cy", "28");
		builder.AddAttribute(23, "r", "4");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "fill", "#FFB74D");
		builder.AddAttribute(26, "cx", "36");
		builder.AddAttribute(27, "cy", "28");
		builder.AddAttribute(28, "r", "4");
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "fill", "#FFB74D");
		builder.AddAttribute(31, "cx", "12");
		builder.AddAttribute(32, "cy", "28");
		builder.AddAttribute(33, "r", "4");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "fill", "#FFB74D");
		builder.AddAttribute(36, "cx", "18");
		builder.AddAttribute(37, "cy", "37");
		builder.AddAttribute(38, "r", "5");
		builder.CloseElement();
		builder.OpenElement(39, "circle");
		builder.AddAttribute(40, "fill", "#FFB74D");
		builder.AddAttribute(41, "cx", "30");
		builder.AddAttribute(42, "cy", "37");
		builder.AddAttribute(43, "r", "5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
