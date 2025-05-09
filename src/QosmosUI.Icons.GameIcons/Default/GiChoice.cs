// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiChoice : ComponentBase
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
		builder.AddAttribute(14, "d", "M400 25c-48.2 0-87 38.84-87 87 0 48.2 38.8 87 87 87s87-38.8 87-87c0-48.16-38.8-87-87-87zm40.5 34.01l15 9.98-70.1 105.11-55.8-55.7 12.8-12.8 40.2 40.3 57.9-86.89zM304.7 156.1L186.4 238H32v36h154.4l118.3 81.9c5.1-11 12.1-21 20.5-29.5L223.6 256l101.6-70.4c-8.4-8.5-15.4-18.5-20.5-29.5zM400 313c-48.2 0-87 38.8-87 87s38.8 87 87 87 87-38.8 87-87-38.8-87-87-87zm-41.6 32.6l41.6 41.6 41.6-41.6 12.8 12.8-41.6 41.6 41.6 41.6-12.8 12.8-41.6-41.6-41.6 41.6-12.8-12.8 41.6-41.6-41.6-41.6 12.8-12.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
