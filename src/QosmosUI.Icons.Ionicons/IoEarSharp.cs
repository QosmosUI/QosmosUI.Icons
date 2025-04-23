// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoEarSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M380.48,68.09C347.09,34.5,302.88,16,256,16,159,16,80,95,80,192V398.57a97.59,97.59,0,0,0,28,68.49A94.49,94.49,0,0,0,176,496c19.93,0,41.06-7.69,62.8-22.87a181.46,181.46,0,0,0,25.88-21.86C327.37,390.16,432,288.06,432,192,432,145.51,413.71,101.51,380.48,68.09ZM368,200H336V184c0-39.7-35.89-72-80-72s-80,32.3-80,72v30.41c27.5-7.84,59.89-6.62,64.26-6.41a48,48,0,0,1,38.62,75.9c-.3.41-.61.81-.95,1.2-16.55,19-36,45.49-38.46,55l-4.07,15.47-30.94-8.14,4.07-15.47c5.51-20.94,36.93-58.2,44.66-67.15A16,16,0,0,0,239.82,240l-.88,0c-10.67-.58-42.66-.25-62.12,8l-.82.35V320H144V184c0-57.35,50.24-104,112-104s112,46.65,112,104Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
