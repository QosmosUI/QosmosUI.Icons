// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoEar : ComponentBase
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
		builder.AddAttribute(14, "d", "M256,16C159,16,80,95,80,192V398.57a97.59,97.59,0,0,0,28,68.49A94.51,94.51,0,0,0,176,496c36.86,0,67.18-15.62,90.12-46.42,4.48-6,9.55-14.74,15.42-24.85,15.32-26.37,36.29-62.47,63.17-80.74,25.77-17.51,47.23-39.54,62-63.72C423.51,252.94,432,223.24,432,192,432,95,353.05,16,256,16Zm96,184a16,16,0,0,1-16-16c0-39.7-35.89-72-80-72s-80,32.3-80,72v30.42c27.19-7.84,58.4-6.72,64.28-6.42a48,48,0,0,1,38.6,75.9c-.3.41-.61.81-.95,1.2-16.55,19-36,45.48-38.46,55a16,16,0,0,1-30.94-8.14c5.51-20.94,36.93-58.2,44.66-67.15A16,16,0,0,0,239.82,240l-.88,0c-16.6-.89-45.89.8-62.94,8.31V304a16,16,0,0,1-32,0V184c0-57.35,50.24-104,112-104s112,46.65,112,104A16,16,0,0,1,352,200Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
