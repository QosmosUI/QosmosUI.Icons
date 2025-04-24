// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBicycle : ComponentBase
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
		builder.AddAttribute(14, "d", "M388,448a92,92,0,1,1,92-92A92.1,92.1,0,0,1,388,448Zm0-152a60,60,0,1,0,60,60A60.07,60.07,0,0,0,388,296Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M124,448a92,92,0,1,1,92-92A92.1,92.1,0,0,1,124,448Zm0-152a60,60,0,1,0,60,60A60.07,60.07,0,0,0,124,296Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M320,128a31.89,31.89,0,0,0,32-32.1A31.55,31.55,0,0,0,320.2,64a32,32,0,1,0-.2,64Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M367.55,192H323.79a4,4,0,0,1-3.51-2.08l-31.74-58.17h0A31,31,0,0,0,239.16,124h0L169.3,194.4a32.56,32.56,0,0,0-9.3,22.4c0,17.4,12.6,23.6,18.5,27.1C207,260.32,227.07,272.33,238.08,279a4,4,0,0,1,1.92,3.41v69.12c0,8.61,6.62,16,15.23,16.43A16,16,0,0,0,272,352V266a16,16,0,0,0-6.66-13l-37-26.61a4,4,0,0,1-.58-6l42-44.79a4,4,0,0,1,6.42.79L298,215.77A16,16,0,0,0,312,224h56a16,16,0,0,0,16-16.77C383.58,198.62,376.16,192,367.55,192Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
