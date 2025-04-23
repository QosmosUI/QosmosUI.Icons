// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAddydotio : ComponentBase
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
		builder.AddAttribute(15, "d", "M18 6.81V6c0-.305-.033-.605-.075-.9C17.489 2.217 15 0 12 0S6.51 2.217 6.075 5.1A5.733 5.733 0 0 0 6 6v.81A5.987 5.987 0 0 0 3 12v6a6 6 0 0 0 6 6h6c0-1.655-1.345-3-3-3H9c-1.655 0-3-1.345-3-3v-6c0-1.655 1.345-3 3-3h6c1.655 0 3 1.345 3 3v1.5a3 3 0 0 1-1.5 2.597V12c0-.83-.67-1.5-1.5-1.5H9c-.83 0-1.5.67-1.5 1.5v6c0 .83.67 1.5 1.5 1.5h6c1.055 0 2.04-.272 2.902-.75A5.996 5.996 0 0 0 21 13.5V12a5.987 5.987 0 0 0-3-5.19Zm-4.5 9.69h-3v-3h3zM9 6c0-.548.15-1.06.408-1.5A2.998 2.998 0 0 1 12 3c1.106 0 2.077.605 2.592 1.5.258.44.408.952.408 1.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
