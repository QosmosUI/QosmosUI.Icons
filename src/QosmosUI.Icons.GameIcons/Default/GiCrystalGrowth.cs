// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCrystalGrowth : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M253.8 15.56l-79.9 84.11 2.3 58.83 50.6 36.2 31.9 182 10.8-26.9 11.8-235.4 18.7 1-9.1 181 28.3-70.8 8.2-108 .9-17.93zm139 50.57l-46.6 50.77-3.9 51.1 10.6-26.2 30.4-13.7c3.2-20.6 6.3-41.3 9.5-61.97zm60.3 51.17l-85.7 38.4-102.6 255.9 14.6 83.3h7.8l147.6-293.1 16.7 8.4-143.4 284.7h24.4l146.6-291.8zm-340.2 18.9l-54.11 99.1 69.11 259.6h93.6l-51.1-274.8 18.3-3.4 51.8 278.2h19.9l-50.7-289.4zm358.3 260.4l-65.8-5.2-49.8 99.2 69.8-36.7zm-435.96-28l42.47 126.7h30.99L80.6 389.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
