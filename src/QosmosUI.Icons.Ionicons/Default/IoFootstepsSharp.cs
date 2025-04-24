// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFootstepsSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M130.54,358.31c-12.83,1.88-33.95,5.38-48-10.56S56.34,293.32,51,258.92c-7.88-50.7-.06-93.43,22-120.31,13-15.83,30.06-25,49.34-26.46,16.51-1.27,41.18,5.19,65,43.19,14.92,23.81,26.27,55.44,31.14,86.77h0c5.88,37.82,11.61,78.18-8.44,92.65-11.31,8.17-19.43,11-38.62,15.57C155.64,354.08,143.38,356.42,130.54,358.31Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M107.72,390.84l108.89-22.46c9.2-1.9,16.58,3.16,20,18.32,11.22,49.76-4.86,109.3-55.22,109.3-47.69,0-79.47-54.36-84.66-83.58C94.36,399.17,97.74,392.89,107.72,390.84Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M340.59,254.34c-19.19-4.55-27.31-7.4-38.62-15.57-20.05-14.47-14.32-54.83-8.44-92.65h0c4.87-31.33,16.22-63,31.14-86.77,23.8-38,48.47-44.46,65-43.19C408.93,17.63,426,26.78,439,42.61c22.08,26.88,29.9,69.61,22,120.31-5.35,34.4-17.46,72.76-31.59,88.83s-35.13,12.44-48,10.56S356.36,258.08,340.59,254.34Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M404.28,294.84,295.39,272.38c-9.2-1.9-16.58,3.16-20,18.32C264.18,340.46,280.26,400,330.62,400c47.69,0,79.47-54.36,84.66-83.58C417.64,303.17,414.26,296.89,404.28,294.84Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
