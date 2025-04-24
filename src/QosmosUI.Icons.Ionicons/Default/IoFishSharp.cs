// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFishSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M335.45,256a214.83,214.83,0,0,1,29.08-108l7.62-13.26a280.69,280.69,0,0,0-48.64-7.15c-21.94-16.9-54.64-36.95-92.34-43.33L208,80l13.37,61.86C179.7,156,142.94,184.72,118.61,204.48q-7.06-5.91-14.78-11.55c-39.71-29-82.6-31.8-84.4-31.9L0,160l2.67,19.31c.29,2,6.79,44.73,31.65,76.52C9.46,287.63,3,330.33,2.67,332.36L0,352l19.43-1.36c1.8-.1,44.69-2.89,84.4-31.9q7.58-5.53,14.56-11.37c24.37,19.83,61.14,48.6,102.86,62.74L208,432l23.17-4.22c37.49-6.34,70.08-26.4,92-43.32a284.27,284.27,0,0,0,49.32-7.23l-7.91-13.18A214.92,214.92,0,0,1,335.45,256Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M499.59,221.75c-5.85-9.88-16.54-24.9-34.19-40.28a209.82,209.82,0,0,0-62-37L392.23,164a183.22,183.22,0,0,0-.09,183.87l11.75,19.57a209.26,209.26,0,0,0,61.42-36.49C497.05,303.47,512,269,512,256,512,243.69,504,229.26,499.59,221.75ZM416,256a16,16,0,1,1,16-16A16,16,0,0,1,416,256Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
