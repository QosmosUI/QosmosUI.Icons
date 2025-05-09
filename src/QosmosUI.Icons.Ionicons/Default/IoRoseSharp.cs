// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoRoseSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M448,112s-17.62,0-30.51,1.39c-19,2-42.06,8-59.73,13.22C322.7,137,288.43,150.53,249.91,169.2c-18.62,9.05-26,13.35-48,26.13L197.41,198c-32.95,19-57.09,40-73.79,64.3C105.29,288.89,96,320,96,354.64c0,40.74,15.71,77.1,44.24,102.37C169,482.52,209.06,496,256,496c46.76,0,86.89-14.32,116-41.43,28.35-26.35,44-63.39,44-104.29,0-25-6.19-47-12.17-68.22-12.59-44.69-23.46-83.29,24.71-144.13C432.75,132.62,448,112,448,112Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M219,119.55C168.47,92.08,104.72,80,80,80c0,0,23.23,28.19,29.15,55.4s6.54,48.61,2.91,88.6c17.94-20.48,40.59-37.15,69.32-53.73l4.48-2.6C208,154.8,216.23,150,236,140.41c2.88-1.4,5.74-2.76,8.58-4.11A170.77,170.77,0,0,0,219,119.55Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M345.25,48s-42.53.36-86.12,21.3a280.36,280.36,0,0,0-32.27,18.27q3.73,1.89,7.4,3.88c3.44,1.87,7.09,4,10.9,6.29a189.7,189.7,0,0,1,31.46,24.16c24.57-10.41,73-26.1,90.77-31.28C359.39,71.47,345.25,48,345.25,48Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M176,16c-16,10.83-33.24,41.1-33.24,41.1a494.22,494.22,0,0,1,48.92,15.25l17.65-11.56c8.18-5.35,16.55-10.29,25-14.77C234.31,46,202.59,24.17,176,16Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
