// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiNecklaceDisplay : ComponentBase
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
		builder.AddAttribute(14, "d", "M145.5 19c-1 8.59-1.5 17.29-1.5 26 0 51.76 17.6 100.3 47.1 130.3-6.1 29.3-22.4 51.1-44 68.4 48.5 101.8 166 103 216.1 3.6-22.4-17.7-38.1-40.2-43.3-71.1C350 146.3 368 97.3 368 45c0-8.71-.6-17.41-1.6-26zM96.96 273.9C75.79 283.9 53.33 292.5 32 301c0 80 96 192 224 192s224-112 224-192c-23.2-7.7-45.4-15.5-65.6-24.3-9 39.7-29.6 69.9-56.4 90.5 1.9 4.2 3 8.9 3 13.8 0 18.1-14.9 33-33 33-5.5 0-10.6-1.4-15.2-3.8C310.5 443 286.6 470 256 470c-30.6 0-54.5-27-56.8-59.8-4.6 2.4-9.7 3.8-15.2 3.8-18.1 0-33-14.9-33-33 0-4.9 1.1-9.6 3.1-13.8-27.5-21.1-48.6-52.2-57.14-93.3zM256 358c-20.8 0-39 20.2-39 47s18.2 47 39 47 39-20.2 39-47-18.2-47-39-47zm-72 8c-8.4 0-15 6.6-15 15s6.6 15 15 15 15-6.6 15-15-6.6-15-15-15zm144 0c-8.4 0-15 6.6-15 15s6.6 15 15 15 15-6.6 15-15-6.6-15-15-15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
