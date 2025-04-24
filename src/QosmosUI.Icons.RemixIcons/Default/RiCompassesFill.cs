// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiCompassesFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M10.9998 4.12272V1.9967H12.9998V4.12272C14.725 4.56676 15.9998 6.13286 15.9998 7.9967C15.9998 9.11439 15.5414 10.125 14.8023 10.8508L20.8658 21.3531L19.1338 22.3531L13.0708 11.8517C12.7299 11.9462 12.3708 11.9967 11.9998 11.9967C11.6289 11.9967 11.2697 11.9462 10.9288 11.8517L4.86584 22.3531L3.13379 21.3531L9.1973 10.8508C8.45823 10.125 7.99981 9.11439 7.99981 7.9967C7.99981 6.13286 9.27459 4.56676 10.9998 4.12272ZM11.9998 8.9967C12.5521 8.9967 12.9998 8.54899 12.9998 7.9967C12.9998 7.44442 12.5521 6.9967 11.9998 6.9967C11.4475 6.9967 10.9998 7.44442 10.9998 7.9967C10.9998 8.54899 11.4475 8.9967 11.9998 8.9967Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
