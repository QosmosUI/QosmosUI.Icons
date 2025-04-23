// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHalfLog : ComponentBase
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
		builder.AddAttribute(14, "d", "M405 28.42c-1.1 0-2.2 0-3.3.1-1.1 0-2.3.11-3.4.2l-63.5 57.52 19.5-45.12c-19.6 9.56-37.3 23.94-48.8 41.1L93 399.5c9.7-4.8 19.7-8.1 29.6-9.9l31.5-44.7-12.1 43.2c2.7 0 5.4.1 8.1.4 17 1.7 33.4 7.5 48.7 16.8l82.8-118.1-56.8 138.4c14.9 14.5 28 32.8 38.3 53.8L475.7 88.03a100.7 100.7 0 0 0-4.3-15.14L350.6 224.7 459.3 51.46c-3.2-3.77-6.6-7.03-10.3-9.8-12.2-9.13-27.5-13.33-44-13.24zM337.1 117L192.6 344.2 243.1 222zM140.7 406h-3.5l-4.5 40.5-19.9-36.1c-26.68 8.9-53.28 31.6-76.49 73.2l48.97-.2 33.62-22.6-5.6 22.5 131.4-.4c-9.4-18-20.9-33.2-33.7-45.3l-36.6 20.9 16.3-36.9c-13.6-8.5-27.9-13.7-42.4-15.2-2.5-.2-5.1-.3-7.6-.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
