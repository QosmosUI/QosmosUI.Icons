// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxAlignBaseline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M10.5 1.75003C10.7107 1.75003 10.8988 1.88217 10.9703 2.08042L13.9703 10.4C14.064 10.6598 13.9293 10.9463 13.6696 11.04C13.4098 11.1336 13.1233 10.999 13.0296 10.7392L12.0477 8.01606H8.95227L7.97031 10.7392C7.87664 10.999 7.59012 11.1336 7.33035 11.04C7.07058 10.9463 6.93593 10.6598 7.0296 10.4L10.0296 2.08042C10.1011 1.88217 10.2892 1.75003 10.5 1.75003ZM10.5 3.72402L11.7411 7.16606H9.25877L10.5 3.72402ZM2.49949 2.09997C2.7204 2.09997 2.89949 2.27906 2.89949 2.49997L2.89949 9.53428L4.21664 8.21713C4.37285 8.06092 4.62612 8.06092 4.78233 8.21713C4.93854 8.37334 4.93854 8.6266 4.78233 8.78281L2.78233 10.7828C2.70732 10.8578 2.60557 10.9 2.49949 10.9C2.3934 10.9 2.29166 10.8578 2.21664 10.7828L0.216645 8.78281C0.0604349 8.6266 0.0604349 8.37334 0.216645 8.21713C0.372854 8.06092 0.62612 8.06092 0.78233 8.21713L2.09949 9.53428L2.09949 2.49997C2.09949 2.27906 2.27857 2.09997 2.49949 2.09997ZM0.0999695 13.5001C0.0999695 13.2791 0.279056 13.1001 0.499969 13.1001H14.5C14.7209 13.1001 14.9 13.2791 14.9 13.5001C14.9 13.721 14.7209 13.9001 14.5 13.9001H0.499969C0.279056 13.9001 0.0999695 13.721 0.0999695 13.5001Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
