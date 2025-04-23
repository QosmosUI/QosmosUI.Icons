// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiNewShoot : ComponentBase
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
		builder.AddAttribute(14, "d", "M443.8 18.18C374.1 34.78 283.7 95.63 288 174.5l-.6.3c-12.3-33.5-29.6-48.4-62.2-63.2-43-18.66-89.7 0-157.01-37.35C113 130.3 113 205.1 178.4 223.8c44.5 14.8 91.3 6.1 109.7-7.5 21.3 72.8 18.2 144.9-14.6 217.5-1.3-35-11.2-77.8-24.9-108.2-5.6 37.4-1.9 93.4-39.3 130.8 1.9-18.7-13.1-56-28-74.7 0 37.3 3.7 74.7-20.6 112.1h241.1c5.2-17.5 7.2-35 9-37.2-7.5 4.7-14.7 11.1-28.1 13.6 3.7 0 2.3-32.5.4-51.2-14.9 37.4-37.3 56.1-61.6 56.1 26.1-37.4 22.4-56.1 18.7-93.4-13 32.4-24.6 50.8-53.2 67.3 37.7-78.8 41.9-158.4 19.3-237.2 25.1 11.4 53.4 7.2 85.2-25.4 37-37.9 9.4-112.15 52.3-168.22zm-33 438.42c.2 0 .3-.1.4-.2-.1 0-.2.1-.4.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
