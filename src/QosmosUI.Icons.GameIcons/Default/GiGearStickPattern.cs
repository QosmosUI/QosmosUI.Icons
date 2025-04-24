// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiGearStickPattern : ComponentBase
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
		builder.AddAttribute(14, "d", "M82.64 48.26a51.94 51.94 0 0 0-51.68 51.94 51.94 51.94 0 0 0 42.2 50.9v209.7a51.94 51.94 0 0 0-42.2 51 51.94 51.94 0 0 0 51.94 51.9 51.94 51.94 0 0 0 51.9-51.9 51.94 51.94 0 0 0-42.15-51v-95.1H246.2v95.1a51.94 51.94 0 0 0-42.2 51 51.94 51.94 0 0 0 52 51.9 51.94 51.94 0 0 0 51.9-51.9 51.94 51.94 0 0 0-42.2-51v-95.1H438.8V151.1a51.94 51.94 0 0 0 42.2-50.9 51.94 51.94 0 0 0-51.9-51.94 51.94 51.94 0 0 0-.2 0 51.94 51.94 0 0 0-51.7 51.94 51.94 51.94 0 0 0 42.2 50.9v95.1H265.7v-95.1a51.94 51.94 0 0 0 42.2-50.9A51.94 51.94 0 0 0 256 48.26a51.94 51.94 0 0 0-.2 0A51.94 51.94 0 0 0 204 100.2a51.94 51.94 0 0 0 42.2 50.9v95.1H92.65v-95.1a51.94 51.94 0 0 0 42.15-50.9 51.94 51.94 0 0 0-51.9-51.94 51.94 51.94 0 0 0-.26 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
