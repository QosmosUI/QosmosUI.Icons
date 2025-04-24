// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFootball : ComponentBase
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
		builder.AddAttribute(14, "d", "M256,48C141.31,48,48,141.31,48,256s93.31,208,208,208,208-93.31,208-208S370.69,48,256,48ZM399,352H353.78a8,8,0,0,1-6.91-4l-16.14-27.68a8,8,0,0,1-.86-6l14.86-59.92a8,8,0,0,1,4.65-5.45l28.1-11.9a8,8,0,0,1,8.34,1.3l41.63,35.82a8,8,0,0,1,2.69,7.26,174.75,174.75,0,0,1-24.28,66.68A8,8,0,0,1,399,352ZM134.52,237.13l28.1,11.9a8,8,0,0,1,4.65,5.45l14.86,59.92a8,8,0,0,1-.86,6L165.13,348a8,8,0,0,1-6.91,4H113a8,8,0,0,1-6.82-3.81,174.75,174.75,0,0,1-24.28-66.68,8,8,0,0,1,2.69-7.26l41.63-35.82A8,8,0,0,1,134.52,237.13Zm256.94-87.24-18.07,51.38A8,8,0,0,1,369,206l-29.58,12.53a8,8,0,0,1-8.26-1.24l-56.26-47.19A8,8,0,0,1,272,164V130.42a8,8,0,0,1,3.56-6.65l42.83-28.54a8,8,0,0,1,7.66-.67A176.92,176.92,0,0,1,390,142,8,8,0,0,1,391.46,149.89ZM193.6,95.23l42.84,28.54a8,8,0,0,1,3.56,6.65V164a8,8,0,0,1-2.86,6.13l-56.26,47.19a8,8,0,0,1-8.26,1.24L143,206a8,8,0,0,1-4.43-4.72l-18.07-51.38A8,8,0,0,1,122,142a176.92,176.92,0,0,1,64-47.48A8,8,0,0,1,193.6,95.23Zm17.31,327.46L191.18,373a8,8,0,0,1,.52-7l15.17-26a8,8,0,0,1,6.91-4h84.44a8,8,0,0,1,6.91,4l15.18,26a8,8,0,0,1,.53,7l-19.59,49.67a8,8,0,0,1-5.69,4.87,176.58,176.58,0,0,1-79,0A8,8,0,0,1,210.91,422.69Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
