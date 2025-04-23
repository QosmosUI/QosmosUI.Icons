// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoDeviceCamera : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M21.333 5.333c.734 0 1.334.6 1.334 1.334v12c0 .733-.6 1.333-1.334 1.333H2.667c-.734 0-1.334-.6-1.334-1.333v-12c0-.734.6-1.334 1.334-1.334C2.667 4.6 3.267 4 4 4h5.333c.734 0 1.334.6 1.334 1.333h10.666Zm-6 12A4.655 4.655 0 0 0 20 12.667 4.655 4.655 0 0 0 15.333 8a4.655 4.655 0 0 0-4.666 4.667 4.655 4.655 0 0 0 4.666 4.666Zm3.334-4.666A3.343 3.343 0 0 1 15.333 16 3.352 3.352 0 0 1 12 12.667a3.352 3.352 0 0 1 3.333-3.334 3.352 3.352 0 0 1 3.334 3.334ZM9.333 8V6.667H4V8h5.333Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
