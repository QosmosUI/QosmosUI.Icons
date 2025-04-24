// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoPizza : ComponentBase
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
		builder.AddAttribute(14, "d", "M441.82,67.83l0,0C383.44,44.73,317.3,32,255.56,32,192,32,125.76,44.53,69,67.26,48.7,75.49,45.21,90,48.71,100.82L52.78,111a16,16,0,0,0,21.31,8.69c10.8-4.76,23.93-10.54,27-11.78C145.1,89.64,198.71,80,256,80c57.47,0,108.09,9.24,154.76,28.25h0c4.42,1.8,14.88,6.42,26.17,11.46a16,16,0,0,0,21.35-8.59L462,102l.34-.9C465.79,90.89,462.48,76.05,441.82,67.83Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M409.18,140.86C363.67,122.53,307.68,112,255.56,112a425,425,0,0,0-153.74,28.89c-.53.21-2.06.88-4.29,1.88a16,16,0,0,0-8,21.27c4,8.71,9.42,20.58,15.5,33.89C137.94,270,199.21,404,227.26,462A31.74,31.74,0,0,0,256,480h0a31.73,31.73,0,0,0,28.76-18.06l.06-.13,137.3-297.57a15.94,15.94,0,0,0-8.31-21.45c-2.26-.95-3.85-1.61-4.5-1.87Zm-215.1,83.07a32,32,0,1,1,29.85-29.85A32,32,0,0,1,194.08,223.93Zm64,128a32,32,0,1,1,29.85-29.85A32,32,0,0,1,258.08,351.93Zm64-112a32,32,0,1,1,29.85-29.85A32,32,0,0,1,322.08,239.93Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
