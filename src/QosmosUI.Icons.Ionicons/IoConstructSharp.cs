// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoConstructSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M497.14,111.38l-81.09,80.84-48.58-48.41L448.56,63c-45.22-22-108.65-22.09-146.2,15.35-35.32,35.2-39.73,90.61-22.54,134.2L99.57,391.37a12,12,0,0,0,0,17l52.27,52.11a12,12,0,0,0,17,0l180-180.5c43.16,16.21,98,11.64,132.74-23C519.08,219.53,519,156.64,497.14,111.38Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M365.45,308.62l-71.83,72,75.53,79.92a10.88,10.88,0,0,0,15.65.21l60-60.46a11,11,0,0,0-.24-15.69Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M119,212c0-4.87-4-9.33-7.45-12.78l-.25-.24-1.54-1.47a1.06,1.06,0,0,1-.26-.8,16.16,16.16,0,0,1,9.52-2c1.27.13,5.91.9,12.4,4.91,3.38,2.09,32.63,30.23,43.93,40.7a11,11,0,0,0,.14,15.35l7.43,7.86,65.66-65.17-8.25-7.84a10.87,10.87,0,0,0-15.31-.06c-23-24.68-29-35.45-31-42.45-4.42-15.47,4.14-28,14-36,5.84-4.62,17.88-8.08,29-9a52.72,52.72,0,0,1,11.61.6c3.47.5,6.3,1.14,7.39,1.4a68.51,68.51,0,0,1,11,4l12-19a88.38,88.38,0,0,0-13.4-17.7c-1.59-1.66-3.31-3.37-5.19-5.1-7.78-7.15-28-19.2-54.59-19.2a117.38,117.38,0,0,0-44.77,8.82c-37.44,15.34-61.88,36.25-73.11,47.35l-.07.07A219.55,219.55,0,0,0,67,128.56c-5.35,7.53-4.77,15.84-4.38,21.34,0,.32,0,.67.07,1a18.41,18.41,0,0,0-10.78-3.5A18,18,0,0,0,39,152.73L2,189.62a6.79,6.79,0,0,0,0,9.6L65,262a6.72,6.72,0,0,0,9.5,0l37.06-37C115,221.56,119,216.86,119,212Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
