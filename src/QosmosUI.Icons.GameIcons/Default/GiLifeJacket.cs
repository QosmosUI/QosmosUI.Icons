// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLifeJacket : ComponentBase
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
		builder.AddAttribute(14, "d", "M141 35c-13 0-26.9.98-38.6 2.88-8.3 1.36-15.6 3.39-20.5 5.33 3.4 24.58 4.8 57.69 0 90.09-4.9 33.5-16.3 66.4-40.9 85.3V294h142v-25h64V139.2c-16-9.8-27.4-25.9-36.9-42.8-10.4-18.72-18.4-38.91-26.2-54.37l-.7-1.53c-1.4-.74-4.4-1.84-8.4-2.7-8.4-1.78-20.7-2.8-33.8-2.8zm230 0c-13.1 0-25.4 1.02-33.8 2.8-4 .86-7 1.96-8.4 2.7l-.7 1.53c-7.8 15.46-15.8 35.65-26.2 54.37-9.5 16.9-20.9 33-36.9 42.8V269h64v25h142v-75.4c-24.6-18.9-36-51.8-40.9-85.3-4.8-32.4-3.4-65.51 0-90.09-4.9-1.94-12.1-3.97-20.5-5.33C397.9 35.98 384 35 371 35zM201 287v62h110v-62zm23 14h64v18h-64zM41 344v62c0 1.3.3 3.8.8 7h204.6c.4-2.5.6-4.8.6-7v-39h-64v-23zm288 0v23h-64v39c0 2.2.2 4.5.6 7h204.6c.5-3.2.8-5.7.8-7v-62zM45.4 431c1.5 6 3.2 12.3 5.1 18.2 2.9 8.6 6.3 16.6 9.5 21.9 1.5 2.7 3.1 4.6 4.1 5.4.4.4.4.5.5.5H208c-.5 0 3.6-1.2 8-5.5 4.5-4.3 9.7-10.8 14.4-18.3 4.3-6.8 8.1-14.6 11-22.2zm225.2 0c2.9 7.6 6.7 15.4 11 22.2 4.7 7.5 9.9 14 14.4 18.3 4.4 4.3 8.5 5.5 8 5.5h143.4l.5-.5c1-.8 2.5-2.7 4.1-5.4 3.2-5.3 6.6-13.3 9.5-21.9 1.9-5.9 3.7-12.2 5.1-18.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
