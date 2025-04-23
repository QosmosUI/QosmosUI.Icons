// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiGlassBall : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 23C127.4 23 23 127.4 23 256s104.4 233 233 233 233-104.4 233-233S384.6 23 256 23zm0 18c118.8 0 215 96.2 215 215s-96.2 215-215 215S41 374.8 41 256 137.2 41 256 41zm-26.2 30.98c-31.1 8.77-64.1 25.12-91 48.92 7.6 4.3 15.1 9.1 22.4 14.4 25.1-23.5 57.6-42.36 98.3-51.26-11.1-6.71-22-10.88-29.7-12.06zm49.3 26.85c-44.2 6.27-78.1 24.37-103.7 47.87 10.3 9.1 19.8 19.4 28.1 30.8 21.2-18 52.5-31.9 99-39.5-3.1-15.4-12.3-28.7-23.4-39.17zM125.3 134.1c-20.8 22.4-36.08 50.3-41.05 83.4 2.11 12.3 5.86 22.7 10.71 31.6 6.74-26.9 19.74-57.2 40.54-85 4-5.4 8.3-10.6 12.9-15.7-7.5-5.5-15.3-10.2-23.1-14.3zm37.3 25.5c-4.6 4.9-8.8 10-12.7 15.3-23.1 30.9-35.9 65.9-40.6 93.5 14.7 14.7 33 22 48.5 24.8 2.5-37.7 8.2-74.2 32.8-102.9-8.1-11.4-17.6-21.7-28-30.7zM444 273.5c-32.6 72.6-111.1 153.4-219 156 8.1 9.1 49.8 18.1 76.5 9 93.4-31.8 129.1-119.3 142.5-165z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
