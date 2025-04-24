// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoCut : ComponentBase
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
		builder.AddAttribute(14, "d", "M103.48,224a71.64,71.64,0,0,0,44.76-15.66l41.5,16.89,6.82-12.63a39.15,39.15,0,0,1,4.32-6.37l14.22-14.42-41.17-24.94A72,72,0,1,0,103.48,224Zm0-112a40,40,0,1,1-40,40A40,40,0,0,1,103.48,112Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M480,169l-5.52-12.58c-4.48-10.42-14.74-16-32.78-17.85-10.12-1-26.95-1.24-49.69,3.81-20,4.45-122.14,28.2-164.95,58.62C206.81,215.39,203,234.67,200,250.16c-2.78,14.14-5,25.31-18,35-15,11.14-27.27,16.38-33.58,18.6a71.74,71.74,0,1,0,24.79,38ZM255.48,256a16,16,0,1,1,16-16A16,16,0,0,1,255.48,256Zm-152,144a40,40,0,1,1,40-40A40,40,0,0,1,103.48,400Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M343.79,259.87l-83.74,48.18,27.63,13.08,3.62,1.74C310,331.92,359.74,356,410.53,359c3.89.23,7.47.34,10.78.34C442,359.31,453,354,459.75,350L480,336Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
