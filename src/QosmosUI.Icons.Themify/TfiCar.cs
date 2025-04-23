// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiCar : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M17 9.984l-1.958 0.002-2.051-3.986h-7.949l-2.968 3.999-2.074 0.001v4.977h2.002c0 0.008-0.002 0.015-0.002 0.023 0 1.103 0.897 2 2 2s2-0.897 2-2c0-0.008-0.002-0.015-0.002-0.023h5.005c-0.001 0.008-0.003 0.015-0.003 0.023 0 1.103 0.897 2 2 2s2-0.897 2-2c0-0.008-0.002-0.015-0.002-0.023h2.002v-4.993zM13.918 9.987l-3.897 0.004v-2.991h2.36l1.537 2.987zM5.544 7h3.477v2.992l-5.701 0.005 2.224-2.997zM4 16c-0.551 0-1-0.449-1-1s0.449-1 1-1 1 0.449 1 1-0.449 1-1 1zM13 16c-0.551 0-1-0.449-1-1s0.449-1 1-1 1 0.449 1 1-0.449 1-1 1zM16 13.977h-1.291c-0.35-0.582-0.981-0.977-1.709-0.977s-1.359 0.395-1.709 0.977h-5.582c-0.35-0.582-0.981-0.977-1.709-0.977s-1.359 0.395-1.709 0.977h-1.291v-2.977l15-0.015v2.992z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
