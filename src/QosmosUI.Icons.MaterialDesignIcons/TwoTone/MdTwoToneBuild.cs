// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBuild : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M11.92 8.28c.24-1.4-.16-2.89-1.24-3.96-.94-.95-2.2-1.39-3.44-1.32l3.09 3.09-4.24 4.24L3 7.24c-.07 1.24.37 2.49 1.31 3.44 1.04 1.04 2.47 1.45 3.83 1.25.71-.1 1.4-.38 2-.82l9.46 9.46.88-.88-9.45-9.45c.47-.6.77-1.26.89-1.96z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M22.61 18.97L13.54 9.9c.93-2.34.45-5.1-1.44-7C9.8.6 6.22.39 3.67 2.25L7.5 6.08 6.08 7.5 2.25 3.67C.39 6.21.6 9.79 2.9 12.09c1.86 1.86 4.57 2.35 6.89 1.48l9.11 9.11c.39.39 1.02.39 1.41 0l2.3-2.3c.4-.38.4-1.02 0-1.41zm-3 1.6l-9.46-9.46c-.61.45-1.29.72-2 .82-1.36.2-2.79-.21-3.83-1.25-.95-.94-1.39-2.2-1.32-3.44l3.09 3.09 4.24-4.24L7.24 3c1.24-.07 2.49.37 3.44 1.31 1.08 1.08 1.49 2.57 1.24 3.96-.12.7-.42 1.36-.88 1.95l9.45 9.45-.88.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
