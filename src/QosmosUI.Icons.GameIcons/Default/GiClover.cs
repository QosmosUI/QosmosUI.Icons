// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiClover : ComponentBase
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
		builder.AddAttribute(14, "d", "M105.186 26.426c-38.314.06-62.13 26.334-31.37 72.994C6.192 97.785-9.36 188.75 62.29 218.39c54.838 22.684 82.008-6.012 142.985 15.008-64.015-7.88-119.143 21.696-153.814 66.6-38.507 49.87-24.104 120.148 40.41 100.332-9.024 67.12 62.385 100.137 103.907 47.166 35.793-45.66 15.51-103.756 41.842-182.885 7.1 61.706-5.617 108.762 11.573 166.478 21.393 71.83 103.075 75.605 118.537 6.34 55.84 51.31 95.82-9.41 75.754-76.643-17.993-60.285-90.76-98.2-167.65-118.703 72.808-3.032 108.846 44.51 167.78 30.084 72.446-17.734 64.365-108.426-10.823-128.922 45.767-54.918-19.446-110.047-87.18-93.117-57.113 14.275-90.85 71.977-101.928 143.33-5.55-65.618-28.823-120.138-81.03-150.316-19.64-11.353-40.05-16.74-57.466-16.714z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
