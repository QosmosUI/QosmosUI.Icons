// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBlackKnightHelm : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 16c-36.446 0-73.264 13.433-139.97 40h279.94C329.263 29.433 292.445 16 256 16zM95.344 72L64 448c56 28 112 31.5 168 31.938V240H112v-48h288v48H280v239.938C336 479.5 392 476 448 448L416.656 72H95.344zm64.875 88a8 8 0 0 1 7.78 8 8 8 0 0 1-16 0 8 8 0 0 1 8.22-8zm48 0a8 8 0 0 1 7.78 8 8 8 0 0 1-16 0 8 8 0 0 1 8.22-8zm48 0a8 8 0 0 1 7.78 8 8 8 0 0 1-16 0 8 8 0 0 1 8.22-8zm48 0a8 8 0 0 1 7.78 8 8 8 0 0 1-16 0 8 8 0 0 1 8.22-8zm48 0a8 8 0 0 1 7.78 8 8 8 0 0 1-16 0 8 8 0 0 1 8.22-8zM248 240v240c2.667.002 5.333 0 8 0s5.333.002 8 0V240h-16zm-120 48h16v16h-16v-16zm32 0h16v16h-16v-16zm32 0h16v16h-16v-16zm112 0h16v16h-16v-16zm32 0h16v16h-16v-16zm32 0h16v16h-16v-16zm-240 32h16v16h-16v-16zm32 0h16v16h-16v-16zm32 0h16v16h-16v-16zm112 0h16v16h-16v-16zm32 0h16v16h-16v-16zm32 0h16v16h-16v-16zm-240 32h16v16h-16v-16zm32 0h16v16h-16v-16zm32 0h16v16h-16v-16zm112 0h16v16h-16v-16zm32 0h16v16h-16v-16zm32 0h16v16h-16v-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
