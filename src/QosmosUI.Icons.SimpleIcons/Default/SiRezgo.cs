// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiRezgo : ComponentBase
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
		builder.AddAttribute(15, "d", "M10.147 16.705c-.015-3.076.004-6.175-.024-9.238 0-2.052.836-3.917 2.193-5.274A7.438 7.438 0 0 1 17.59 0c1.482.015 2.999.008 4.493.008v3.728c-1.494 0-3.012-.005-4.493.006a3.713 3.713 0 0 0-3.725 3.725c-.01 3.063.004 6.162.01 9.238zm-5.4-.633l-3.61.965c.845 3.15 3.287 5.236 6.274 6.253a13.74 13.74 0 0 0 4.026.704c1.385.039 2.78-.117 4.092-.469 3.31-.886 6.186-3 7.334-6.371l-3.538-1.199c-.699 2.053-2.574 3.374-4.76 3.96-.982.263-2.013.38-3.025.352a10 10 0 0 1-2.93-.514c-1.868-.636-3.378-1.87-3.862-3.681zM6.986 3.354a2.887 2.887 0 1 1-5.775 0 2.887 2.887 0 0 1 5.775 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
