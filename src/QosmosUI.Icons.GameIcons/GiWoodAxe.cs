// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWoodAxe : ComponentBase
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
		builder.AddAttribute(14, "d", "M215.344 22.813L205.03 37.906l71.782 46.375 8.938-12.81c-15.62-23.633-44.153-40.97-70.406-48.657zm-38.47 18.843c-28.32 35.34-79.16 105.16-105.718 145.313 61.96 26.364 113.013 69.562 133.22 119.593 5.064 12.54 8.125 25.566 8.78 38.75 36.873-9.75 80.34-36.93 117.25-70.5 30.105-27.38 55.912-59.115 71.406-87.75L176.875 41.655zm240.657 155.53c-16.836 31.038-43.713 63.084-74.717 91.283-40.21 36.57-87.238 66.474-130.47 76.03-1.09 8.278-3.153 16.543-6.343 24.72-8.91 22.832-26.23 44.633-52.656 64.592 64.678 10.955 135.135-13.105 195.844-53.687 64.21-42.923 116.84-104.112 139.28-157.063l-70.937-45.875zM84.814 213.782L16.5 313.72v143.717l135.875-194.812c-18.23-18.513-41.412-35.295-67.563-48.844z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
