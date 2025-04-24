// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoTrophySharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M399.9,80s0-27.88,0-48H112V80H32v38c0,32,9.5,62.79,26.76,86.61,13.33,18.4,34.17,31.1,52.91,37.21,5.44,29.29,20.2,57.13,50.19,79.83,22,16.66,48.45,28.87,72.14,33.86V436H160v44H352V436H278V355.51c23.69-5,50.13-17.2,72.14-33.86,30-22.7,44.75-50.54,50.19-79.83,18.74-6.11,39.58-18.81,52.91-37.21C470.5,180.79,480,150,480,118V80ZM94.4,178.8C83.72,164.12,77.23,144.4,76.16,124H112v67.37C108.06,190.23,99.08,185.25,94.4,178.8Zm323.2,0C413,185.41,406,191.38,400,191.38c0-22.4,0-46.29-.05-67.38h35.9C434.77,144.4,428,163.9,417.6,178.8Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
