// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCrosscutSaw : ComponentBase
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
		builder.AddAttribute(14, "d", "M333.2 25.24c-2.6 2.79-4.7 8.5 4.3 17.93l53.2 53.59L406 82.83l-54.2-53.11c-10.5-9.45-16-7.26-18.6-4.48zM25.21 333.3c-2.7 2.6-4.97 8.1 4.48 17.8l53.11 55 15.05-15-54.65-53.5c-9.49-9-15.22-6.9-17.99-4.3zm72.64 85.5l69.65 70.3 3.5-31.3 26.5 15.9c.1-.1.2-.1.3-.1l5.2-33.7 32.7 8.8.2-.1 9-36.4 34 7.8c.1-.1.3-.3.5-.4l6.5-38.1 31 6.7 2.8-35.1 35 1.6-1.4-35 34.9-2.8-6.7-30.7 38-6.8.4-.5-7.7-34.1 36.7-8.8.2-.2-9.2-32.7 33.5-6.7.2-.2-15.9-25.1 31.4-3.5-70.4-70.84z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
