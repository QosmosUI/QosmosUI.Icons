// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaTruckLoadingSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 17 5 L 17 21.074219 L 2.7324219 25.035156 L 3.2675781 26.962891 L 20.015625 22.314453 C 20.179437 24.924586 22.349292 27 25 27 C 27.757 27 30 24.757 30 22 C 30 19.243 27.757 17 25 17 C 22.901506 17 21.107665 18.302147 20.367188 20.138672 L 19 20.517578 L 19 7 L 30 7 L 30 5 L 17 5 z M 12.460938 9.7636719 L 1.9160156 12.787109 L 4.6914062 22.470703 L 15.236328 19.445312 L 12.460938 9.7636719 z M 11.089844 12.236328 L 12.763672 18.074219 L 6.0644531 19.994141 L 4.390625 14.158203 L 11.089844 12.236328 z M 25 19 C 26.654 19 28 20.346 28 22 C 28 23.654 26.654 25 25 25 C 23.346 25 22 23.654 22 22 C 22 20.346 23.346 19 25 19 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
