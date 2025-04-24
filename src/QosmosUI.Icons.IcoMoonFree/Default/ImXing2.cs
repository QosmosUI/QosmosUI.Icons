// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImXing2 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M2.431 3.159c-0.138 0-0.256 0.050-0.316 0.144-0.059 0.1-0.050 0.225 0.013 0.353l1.559 2.7c0.003 0.006 0.003 0.009 0 0.013l-2.45 4.331c-0.063 0.128-0.059 0.256 0 0.353 0.059 0.094 0.163 0.156 0.3 0.156h2.306c0.344 0 0.513-0.234 0.628-0.447 0 0 2.397-4.241 2.491-4.406-0.009-0.016-1.588-2.766-1.588-2.766-0.116-0.203-0.287-0.431-0.644-0.431h-2.3z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M12.125 0c-0.344 0-0.494 0.216-0.619 0.441 0 0-4.972 8.816-5.134 9.106 0.009 0.016 3.278 6.016 3.278 6.016 0.116 0.203 0.291 0.441 0.644 0.441h2.306c0.137 0 0.247-0.053 0.306-0.147 0.063-0.1 0.059-0.228-0.006-0.356l-3.25-5.947c-0.003-0.006-0.003-0.009 0-0.016l5.109-9.034c0.063-0.128 0.066-0.256 0.006-0.356-0.059-0.094-0.169-0.147-0.306-0.147h-2.334z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
