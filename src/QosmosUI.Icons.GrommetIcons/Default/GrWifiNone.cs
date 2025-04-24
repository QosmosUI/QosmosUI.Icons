// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrWifiNone : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "fill", "none");
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "12");
		builder.AddAttribute(17, "cy", "18");
		builder.AddAttribute(18, "r", "2");
		builder.AddAttribute(19, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "stroke-opacity", ".2");
		builder.AddAttribute(22, "stroke-width", "2");
		builder.AddAttribute(23, "d", "M7.75735931,13.7573593 C10.1005051,11.4142136 13.8994949,11.4142136 16.2426407,13.7573593 M4.92893219,10.9289322 C8.83417511,7.02368927 15.1658249,7.02368927 19.0710678,10.9289322 M2.10050506,8.10050506 C7.56784515,2.63316498 16.4321549,2.63316498 21.8994949,8.10050506");
		builder.AddAttribute(24, "opacity", ".8");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
