// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCharging : ComponentBase
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
		builder.AddAttribute(14, "d", "M322 25l-10 30h103l-10-30h-83zM66.5 32v55h-23v18h128V87h-23V32h-18v55h-46V32h-18zm210 41v302h174V73h-174zm-208 48v51.3L95.23 199h24.57l26.7-26.7V121h-78zm222 62h146v50h-146v-50zm-192 34v167c0 31.4 18.6 55.7 44.5 70.8 25.8 15.1 59.2 22.2 92.5 22.2s66.7-7.1 92.5-22.2c23.4-13.6 40.8-34.7 44-61.8h-18.1c-2.9 20-15.6 34.9-34.9 46.2-22.2 12.9-52.8 19.8-83.5 19.8-30.7 0-61.3-6.9-83.5-19.8-22.1-12.9-35.5-30.6-35.5-55.2V217h-18zm192 30h146v50h-146v-50zm0 64h146v50h-146v-50z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
