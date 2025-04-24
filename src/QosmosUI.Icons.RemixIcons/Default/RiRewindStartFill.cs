// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiRewindStartFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M2 4C1.44772 4 1 4.44772 1 5V19C1 19.5523 1.44772 20 2 20C2.55228 20 3 19.5523 3 19V13.3332L12.2227 19.4816C12.3048 19.5364 12.4013 19.5656 12.5 19.5656C12.7762 19.5656 13 19.3418 13 19.0656V13.3332L22.2227 19.4816C22.3048 19.5364 22.4013 19.5656 22.5 19.5656C22.7762 19.5656 23 19.3418 23 19.0656V4.93413C23 4.83542 22.9708 4.73892 22.9161 4.65679C22.7629 4.42702 22.4524 4.36493 22.2227 4.51811L13 10.6665V4.93413C13 4.83542 12.9708 4.73892 12.9161 4.65679C12.7629 4.42702 12.4524 4.36493 12.2227 4.51811L3 10.6666V5C3 4.44772 2.55228 4 2 4Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
