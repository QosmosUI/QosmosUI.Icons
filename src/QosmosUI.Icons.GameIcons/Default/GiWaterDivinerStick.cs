// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiWaterDivinerStick : ComponentBase
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
		builder.AddAttribute(14, "d", "M273.7 21.16c-11.7-.12-24.4 6.27-21.8 17.57 14 59.46 42.9 185.87 62.6 249.67-57-65.7-187.4-138.8-258.56-179.1-24.32-13.81-35.48 23.9-13.84 33.2 82.2 35.3 201.7 120.7 268.4 182 64.4 62.1 65.9 82.2 115.8 146 .9-8.3 4.5-16.4 10.6-22.9 9-9.6 21.8-13.8 33.7-11.9-57-61.6-76.9-69.6-121.9-135.8-20.1-72.2-55.3-194.9-57.2-265.89-.2-8.73-8.7-12.76-17.8-12.85zM465.4 453.2c-5.4-.2-11 2-15.4 6.7-7.9 8.4-7.7 20.1-.9 26.6 6.9 6.4 18.6 5.9 26.5-2.4 7.8-8.3 7.6-20 .8-26.5-3-2.8-6.9-4.3-11-4.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
