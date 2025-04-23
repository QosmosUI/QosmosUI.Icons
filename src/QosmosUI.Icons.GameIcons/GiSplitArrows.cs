// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSplitArrows : ComponentBase
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
		builder.AddAttribute(14, "d", "M135.3 38.88L25.22 73.93l74.73 87.97 12.75-44.5c44.9 15 73.8 35.5 91.6 58.3 20.6 26.2 27.5 56.2 25.7 88.9-3.6 65.4-45.7 139.7-83.8 185.5l27.6 23c31.7-37.9 65.6-91.6 82.2-149.5 16.6 57.9 50.5 111.6 82.2 149.5l27.6-23C327.7 404.3 285.6 330 282 264.6c-1.8-32.7 5.1-62.7 25.7-88.9 17.8-22.8 46.7-43.3 91.5-58.3l12.8 44.5 74.8-87.97-110.1-35.05 12.6 43.94c-50.8 16.8-86.7 40.98-110 70.68-10.3 13.2-17.9 27.2-23.3 41.9-5.4-14.7-13-28.7-23.3-41.9-23.3-29.7-59.2-53.88-110-70.68z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
