// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWarhammer : ComponentBase
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
		builder.AddAttribute(14, "d", "M351.4 31.4l-55.9 27.75 54 34.62 1.9-62.37zM143.2 67.33l20 33.47L182 71.5l-38.8-4.17zm57 9.16l-7.6 11.82 100.2 64.19-9.7 15.1-100.2-64.1-24.8 38.7 100.2 64.1-9.7 15.2-100.2-64.1-7.5 11.7 150 96.1 37.9-7.6 44.8-70L200.2 76.49zm93.2 2.73l-16.2 25.28 38.7 24.7 16.2-25.2-38.7-24.78zM108.7 121.2l20 33.5 18.8-29.3-38.8-4.2zm280.1 76.1L346.7 263l11.8 7.5 42.1-65.7-11.8-7.5zm-224.1 8.5l.6 36 72.8 46.6 33-14.5-106.4-68.1zm250.4 9.9l-33.2 51.8c11.7 2.8 24 7.3 36.5 12.3 19.3 7.6 39.1 16.7 56.6 24-9.5-27.2-22.2-57.9-59.9-88.1zm-242.5 52.1L27.77 494h54.61L211.4 292.6l-38.8-24.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
