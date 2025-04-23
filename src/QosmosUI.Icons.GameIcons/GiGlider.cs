// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiGlider : ComponentBase
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
		builder.AddAttribute(14, "d", "M247.989 307.923l.88.88-118.47 118.42c-22.74 22.79-76.09 54.47-76.09 54.47a17.21 17.21 0 0 1-22.18-26.16l181.72-181.71zm231.86-275.77a17.21 17.21 0 0 0-24.33 0l-181.72 181.72 34.1 34.1.88.88 118.42-118.43c22.74-22.74 54.47-76.09 54.47-76.09a17.21 17.21 0 0 0-1.82-22.18zm-52.44 319.24a32.78 32.78 0 0 0-23.25 9.62l-43.17 43.17a32.89 32.89 0 0 0 0 46.51l6 6 89.69-89.68-6-6a32.78 32.78 0 0 0-23.27-9.62zm-46.8 10.55l-18.69 18.69c-40.87-40.64-64.22-62-102.66-84l-39.27-39.32c-64-64-65.14-86.41-57.12-94.44 1.91-1.91 4.76-3.29 9-3.29 12.64 0 37.47 12.43 85.46 60.41l39.29 39.29c21.95 38.47 43.37 61.8 83.99 102.66zm-156.89-162.82c-34.3-29.84-49.85-33.11-53.79-29.17-2.7 2.7-1.91 8.38 2.33 16.9 4.91 9.84 13.88 22.21 26.79 36.94z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
