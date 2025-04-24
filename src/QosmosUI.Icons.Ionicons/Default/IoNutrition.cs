// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoNutrition : ComponentBase
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
		builder.AddAttribute(14, "d", "M439,166.29c-18.67-32.57-47.46-50.81-85.57-54.23-20.18-1.8-39,3.37-57.23,8.38C282.05,124.33,268.68,128,256,128s-26-3.68-40.06-7.57c-18.28-5-37.18-10.26-57.43-8.36C122.12,115.48,93,134.18,74.2,166.15,56.82,195.76,48,236.76,48,288c0,40.4,15,90.49,40,134,12.82,22.25,47,74,87.16,74,30.77,0,47.15-9.44,59.11-16.33,8.3-4.78,13.31-7.67,21.69-7.67s13.39,2.89,21.69,7.67C289.65,486.56,306,496,336.8,496c40.17,0,74.34-51.76,87.16-74,25.07-43.5,40-93.59,40-134C464,235.43,455.82,195.62,439,166.29ZM216,352c-13.25,0-24-21.49-24-48s10.75-48,24-48,24,21.49,24,48S229.25,352,216,352Zm80,0c-13.25,0-24-21.49-24-48s10.75-48,24-48,24,21.49,24,48S309.25,352,296,352Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M265.1,111.93c13.16-1.75,37.86-7.83,58.83-28.79a98,98,0,0,0,28-58.2A8,8,0,0,0,343.38,16c-12.71.95-36.76,5.87-58.73,27.85A97.6,97.6,0,0,0,256,103.2,8,8,0,0,0,265.1,111.93Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
