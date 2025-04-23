// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiEvilComet : ComponentBase
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
		builder.AddAttribute(14, "d", "M121.492 19.12l162.91 176.312c-42.268-65.6-80.666-115.532-100.847-176.31h-62.063zM87 19.124L213.88 174.73 54.726 26.24l269.736 298.49L19.15 40.047v30.2L182.45 225.472 19.15 107.678v31.662l.307.172.002 52.222 116.828 30.87-45.582-39.872c15.55 10.18 32.436 21.74 49.535 34.338 31.358 23.106 62.634 49.186 86.094 75.96 23.46 26.776 39.88 54.455 38.123 82.163-3.912 61.673 50.497 112.38 112.984 112.38 30.236 0 57.638-11.83 77.888-31.102l-76.873 14.216 9.44-37.762-68.327 16.18 10.495-46.3-43.383 7.036.36-2.635 26.802-58.226-5.235 38.372 45.803-7.428-9.994 44.092 69.06-16.356-9.84 39.363 69.897-12.923c5.605-9.05 9.968-18.954 12.85-29.477L450.7 402.21l39.68-25.544c.01-.687.024-1.374.024-2.064 0-62.474-50.544-106.992-113.85-113.012-27.784-2.643-56.96-20.122-86.38-43.826-29.42-23.704-58.906-54.048-85.293-84.03-47.496-53.967-83.31-104.564-90.33-114.61H87zM383.002 284.25l14.076 42.254 20.87-18.567 10.308 85.934-24.11-43.116-20.666 13.13-25.26-53.587 18.186 11.892 6.596-37.94z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
