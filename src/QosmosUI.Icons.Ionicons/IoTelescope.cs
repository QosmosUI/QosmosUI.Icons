// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoTelescope : ComponentBase
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
		builder.AddAttribute(14, "d", "M107.56,250a16,16,0,0,0-21.85-5.86L36,272.81A39.71,39.71,0,0,0,17.2,297.72a40.9,40.9,0,0,0,4.55,30.35l4.36,7.54a40,40,0,0,0,54.62,14.62L130.4,321.6a16,16,0,0,0,5.87-21.86Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M382.84,440.8,288.72,254a2,2,0,0,1,.79-2.63l8.3-4.79a16,16,0,0,0,5.86-21.86l-47.53-82.33a16,16,0,0,0-21.86-5.87l-86.38,49.8a39.73,39.73,0,0,0-18.65,24.28,34.82,34.82,0,0,0-1.37,9.76c.06,7.6,9.2,22.7,18.12,38.28,9.59,16.75,19.24,33.88,26.34,38.15,4.52,2.72,12.5,4.9,19.21,4.9l.84,0L113.07,473.29a16,16,0,1,0,29.05,13.42L235.8,284.06a7.94,7.94,0,0,1,3.26-3.57l19.21-11.08a2,2,0,0,1,2.78.84l93.21,185a16,16,0,0,0,28.58-14.4Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M490.21,115.74,444.09,36a40.08,40.08,0,0,0-54.63-14.62L296.12,75.16a39.69,39.69,0,0,0-18.65,24.28,32.76,32.76,0,0,0-1.27,13.25c1.74,12.62,13,30.4,26.41,53.89,13.58,23.73,28.91,50.48,36.93,56.27a40.18,40.18,0,0,0,23.18,7.37,39.77,39.77,0,0,0,19.92-5.34L476,171.07a39.72,39.72,0,0,0,18.79-24.84A41,41,0,0,0,490.21,115.74Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
