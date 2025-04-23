// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCarRental : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M8,7c1.3,0,2.41-0.84,2.83-2H16v1c0,0.55,0.45,1,1,1s1-0.45,1-1V5h0c0.55,0,1-0.45,1-1s-0.45-1-1-1h-7.17 C10.35,1.65,8.95,0.76,7.4,1.06C6.23,1.29,5.28,2.25,5.05,3.42C4.7,5.32,6.15,7,8,7z M8,3c0.55,0,1,0.45,1,1S8.55,5,8,5S7,4.55,7,4 S7.45,3,8,3z M16.39,9H7.61C7.18,9,6.8,9.28,6.66,9.68L5,14.69V21c0,0.55,0.45,1,1,1s1-0.45,1-1v-1h10v1c0,0.55,0.45,1,1,1 s1-0.45,1-1v-6.31l-1.66-5.01C17.2,9.28,16.82,9,16.39,9z M9,17.5c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S9.55,17.5,9,17.5z M15,17.5c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S15.55,17.5,15,17.5z M7.67,13l0.66-2h7.34l0.66,2H7.67z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
