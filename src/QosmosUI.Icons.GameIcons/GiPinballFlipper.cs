// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPinballFlipper : ComponentBase
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
		builder.AddAttribute(14, "d", "M99.162 35.82a78.03 78.03 0 0 0-78.03 78.03 78.03 78.03 0 0 0 78.03 78.03 78.03 78.03 0 0 0 78.03-78.03 78.03 78.03 0 0 0-78.03-78.03zM95.26 47.525a62.423 62.423 0 0 1 30.79 8.172 78.03 78.03 0 0 0-7.38-.37 78.03 78.03 0 0 0-78.03 78.028 78.03 78.03 0 0 0 .422 7.413 62.423 62.423 0 0 1-8.224-30.82A62.423 62.423 0 0 1 95.26 47.524zm52.05 228.46c-20.196-.23-31.676 32.785-12.646 43.386 87.042 50.526 175.913 102.776 261.92 152.034 35.522 13.912 75.596-3.603 89.508-39.125 13.912-35.523-3.607-75.598-39.13-89.51-103.56-22.994-199.013-43.756-295.503-66.28-1.418-.327-2.805-.49-4.15-.506zm273.49 107.94a24.02 22.947 21.388 0 1 9.37 1.72 24.02 22.947 21.388 0 1 13.996 30.128 24.02 22.947 21.388 0 1-30.732 12.61 24.02 22.947 21.388 0 1-13.997-30.127 24.02 22.947 21.388 0 1 21.364-14.332z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
