// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.WeatherIcons.Default;

public class WiDirectionUpLeft : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 30 30";

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
		builder.AddAttribute(14, "d", "M10.03,14.31V9.84c0-0.3,0.1-0.55,0.3-0.75s0.45-0.3,0.74-0.3h4.48c0.29,0,0.54,0.1,0.74,0.3s0.3,0.45,0.3,0.75	c0,0.29-0.1,0.53-0.3,0.73s-0.45,0.29-0.74,0.29h-1.95l6.06,6.06c0.18,0.21,0.26,0.46,0.26,0.78c0,0.29-0.09,0.53-0.26,0.72	c-0.2,0.19-0.46,0.28-0.79,0.28c-0.3,0-0.55-0.09-0.73-0.28l-6.02-6.05v1.95c0,0.3-0.1,0.55-0.3,0.75c-0.2,0.2-0.45,0.3-0.75,0.3	c-0.29,0-0.54-0.1-0.74-0.31S10.03,14.6,10.03,14.31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
