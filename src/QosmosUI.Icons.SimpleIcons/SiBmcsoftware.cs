// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBmcsoftware : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.375 23.999c-.95 0-1.95-.749-1.95-2.2v-3.4c0-1.349.85-2.899 2.05-3.548l4.75-2.8-4.75-2.8C5.325 8.5 4.425 7 4.425 5.65V2.2c0-1.45 1-2.2 2.002-2.2.4 0 .849.1 1.249.35l10.7 6.35c.75.45 1.15 1.149 1.15 1.849 0 .75-.452 1.45-1.15 1.85l-2.55 1.5 2.55 1.501c.75.45 1.2 1.15 1.2 1.85 0 .75-.452 1.45-1.2 1.85L7.674 23.65c-.45.25-.85.35-1.3.35zm7.15-10.599l-5.85 3.45c-.45.25-.9 1.05-.9 1.55v3.05l10.15-6zM6.775 2.6v3.05c0 .5.45 1.3.9 1.55l5.85 3.45 3.45-2.05z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
