// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaTruckPlane : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 640 512";

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
		builder.AddAttribute(14, "d", "M200 0c-30.6 0-56 54.7-56 86.1l0 106.5L7.8 274.3C2.9 277.2 0 282.4 0 288l0 64c0 5.1 2.4 9.8 6.4 12.8s9.3 3.9 14.1 2.5l123.4-37 0 81.2-50 40c-3.8 3-6 7.6-6 12.5l0 32c0 5.1 2.5 10 6.6 13s9.5 3.8 14.4 2.2L200 480.9 290.4 511c-1.6-4.7-2.4-9.8-2.4-15l0-32.6c-18.2-10.5-30.7-29.7-31.9-51.8l-.1-.1 0-3.5 0-82.5L256 184l0-1.1s0 0 0 0l0-96.9C256 54.7 231.5 0 200 0zm88 176l0 224c0 20.9 13.4 38.7 32 45.3l0 42.7c0 13.3 10.7 24 24 24l16 0c13.3 0 24-10.7 24-24l0-40 160 0 0 40c0 13.3 10.7 24 24 24l16 0c13.3 0 24-10.7 24-24l0-42.7c18.6-6.6 32-24.4 32-45.3l0-224c0-26.5-21.5-48-48-48l-256 0c-26.5 0-48 21.5-48 48zm79.8 78.7c3.3-8.7 11.2-14.7 20.5-14.7l151.4 0c9.2 0 17.2 6 20.5 14.7L576 304l-224 0 15.8-49.3zM568 352a24 24 0 1 1 0 48 24 24 0 1 1 0-48zM336 376a24 24 0 1 1 48 0 24 24 0 1 1 -48 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
