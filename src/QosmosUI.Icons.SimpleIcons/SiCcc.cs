// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCcc : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 3.4C5.814 3.4.8 7.253.8 12c0 4.75 5.014 8.6 11.2 8.6s11.2-3.85 11.2-8.6c0-4.747-5.015-8.6-11.2-8.6M24 12c0 5.19-5.374 9.4-12 9.4S0 17.19 0 12s5.374-9.4 12-9.4S24 6.81 24 12M10 7c-2.83 0-5.026 2.229-5.026 5 0 2.882 2.487 4.997 5.026 4.997V15.44c-1.708 0-3.442-1.36-3.445-3.44C6.547 9.65 8.476 8.544 10 8.544zm3.8 0c-2.83 0-5.026 2.229-5.026 5 0 2.882 2.484 4.997 5.026 4.997V15.44c-1.705 0-3.442-1.36-3.447-3.44-.007-2.35 1.923-3.456 3.447-3.456zm3.8.003c-2.83 0-5.026 2.23-5.026 4.997 0 2.886 2.487 5 5.026 5v-1.56c-1.708 0-3.442-1.358-3.448-3.44-.005-2.35 1.924-3.456 3.448-3.456z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
