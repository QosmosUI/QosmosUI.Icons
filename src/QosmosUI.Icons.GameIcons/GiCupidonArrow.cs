// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCupidonArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M18.188 22.906v26.72l55.374 54.03c4.672-5.725 9.81-10.895 15.313-15.47L22 22.907h-3.813zm323.03 57.875c-33.02.364-67.89 19.083-88.468 59.032L244.406 156l-8.28-16.22c-26.002-50.874-67.868-64.366-104.157-53.874C95.68 96.4 64.62 131.9 63.874 185.97c-.792 57.587 33.99 92.34 73.313 130.686 34.784 33.92 72.897 70.298 85.812 125.313 25.558-33.53 54.225-61.36 81.72-86.658l-77.564-75.406h-.03v-.03c-6.18-6.055-8.758-14.43-7.69-21.72 1.07-7.29 4.987-13.397 10-18.03 5.016-4.635 11.31-7.964 18.408-8.876 1.774-.228 3.61-.282 5.47-.125 5.57.47 11.283 2.727 15.75 7.094.005.005.024-.007.03 0l77.812 75.655.063.063.03.03c.452.453.897.87 1.344 1.313.984-.926 1.995-1.855 2.97-2.78 43.534-41.35 74.882-79.595 75.655-133.78.826-57.986-30.668-89.133-68.22-96.376-4.694-.906-9.494-1.41-14.344-1.53-1.06-.028-2.122-.044-3.187-.033zm-90.124 168.907c-.28.018-.565.054-.875.094-2.48.32-5.677 1.83-8.095 4.064-2.418 2.234-3.896 5.01-4.188 7-.29 1.978-.197 3.274 2.22 5.656l.03.03 77.844 75.658.033.03c27.01 26.466 41.222 44.93 40.906 64.157-.16 9.614-4.967 18.253-12.033 24.844-3.662 3.415-7.95 6.473-12.78 9.374C377.94 466.61 439.006 489.682 491.25 495c-1.076-50.902-26.66-107.724-55.156-150.97-1.19 2.483-2.446 4.96-3.906 7.314-4.697 7.568-11.49 14.616-21.22 17.25-9.727 2.633-20.91.464-33.28-6.188-12.35-6.638-26.502-17.825-43.813-35.125l-.094-.092-77.75-75.594H256c-1.606-1.574-2.94-2.032-4.906-1.906z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
