// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiVkFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M4.26 4.26C3 5.532 3 7.566 3 11.64V12.36C3 16.428 3 18.462 4.26 19.74C5.532 21 7.566 21 11.64 21H12.36C16.428 21 18.462 21 19.74 19.74C21 18.468 21 16.434 21 12.36V11.64C21 7.572 21 5.538 19.74 4.26C18.468 3 16.434 3 12.36 3H11.64C7.572 3 5.538 3 4.26 4.26ZM6.03613 8.47817H8.10013C8.16613 11.9102 9.67813 13.3622 10.8781 13.6622V8.47817H12.8161V11.4362C13.9981 11.3102 15.2461 9.96017 15.6661 8.47217H17.5981C17.4406 9.24243 17.1259 9.97193 16.6737 10.6151C16.2216 11.2582 15.6416 11.8012 14.9701 12.2102C15.7195 12.5831 16.3813 13.1107 16.9118 13.7582C17.4424 14.4056 17.8297 15.1581 18.0481 15.9662H15.9181C15.4621 14.5442 14.3221 13.4402 12.8161 13.2902V15.9662H12.5821H12.5761C8.47213 15.9662 6.13213 13.1582 6.03613 8.47817Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
