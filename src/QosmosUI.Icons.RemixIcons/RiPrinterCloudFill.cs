// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiPrinterCloudFill : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M7 2H17C17.5523 2 18 2.44771 18 3V6H6V3C6 2.44771 6.44772 2 7 2ZM22 9C22 8.44771 21.5523 8 21 8H3C2.44771 8 2 8.44771 2 9V19C2 19.5523 2.44771 20 3 20H5V15H12.1938C12.4371 14.1087 12.9094 13.3124 13.6109 12.6109C14.6848 11.537 15.9812 11 17.5 11C19.0188 11 20.3152 11.537 21.3891 12.6109C21.6169 12.8387 21.8205 13.0765 22 13.3243V9ZM8 10V12H5V10H8ZM21 16.5C21 14.567 19.433 13 17.5 13C15.567 13 14 14.567 14 16.5L14.0034 16.6025C12.8474 16.9279 12 17.99 12 19.25C12 20.7125 13.1417 21.9084 14.5825 21.995L14.75 22H20.25L20.4175 21.995C21.8583 21.9084 23 20.7125 23 19.25C23 17.9903 22.1531 16.9285 20.9985 16.6033L21 16.5ZM7 17H10.562C10.1873 17.6859 10 18.4359 10 19.25C10 20.2823 10.2905 21.199 10.8715 22H7V17Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
