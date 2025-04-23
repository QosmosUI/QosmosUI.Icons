// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSwanBreeze : ComponentBase
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
		builder.AddAttribute(14, "d", "M117.848 64.37c-4.216-.027-8.49.18-12.8.634-55.17 5.8-95.806 49.862-90.71 98.35.106 1.01.203 2.193.334 3.183.927-1.65 1.642-3.144 2.717-4.79 25.247-38.602 83.043-59.15 129.063-45.745 46.02 13.403 62.854 55.91 37.608 94.516-2.82 4.32-6.102 8.118-9.68 11.962 26.987-18.47 43.175-48.472 39.847-80.138-4.7-44.703-46.632-77.64-96.38-77.97zm375.004 33.525c-42.71 89.996-101.97 173.25-167.03 230.687-44.41 39.21-113.416 70.452-164.107 39.715-30.767-18.66-42.313-70.813-15.77-116.22-53.058 22.698-93.682 100.59-64.242 161.773 45.65 94.867 165.072 93.635 286.17 42.048 55.41-23.603 89.392-40.718 124.98-65.41v-33.066c-61.925 43.79-116.094 73.34-196.953 96.22 78.083-36.174 130.285-70.63 196.952-124.476V274.81c-67.75 72.44-145.933 116.294-223.89 154.854 80.25-47.795 155.855-110.53 223.89-186.113v-44.224c-42.886 57.34-97.62 102.83-150.82 149.85 54.818-60.357 107.696-122.268 150.82-191.983V97.895z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
