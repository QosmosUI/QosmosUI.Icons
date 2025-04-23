// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMoneyOffCsred : ComponentBase
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
		builder.AddAttribute(17, "d", "M12.5 6.9c1.42 0 2.13.54 2.39 1.4.13.43.56.7 1.01.7h.06c.7 0 1.22-.71.97-1.36-.44-1.15-1.41-2.08-2.93-2.45V4.5c0-.83-.67-1.5-1.5-1.5S11 3.67 11 4.5v.66c-.39.08-.75.21-1.1.36l1.51 1.51c.32-.08.69-.13 1.09-.13zM4.77 4.62c-.39.39-.39 1.02 0 1.41L7.5 8.77c0 2.08 1.56 3.22 3.91 3.91l3.51 3.51c-.34.49-1.05.91-2.42.91-1.65 0-2.5-.59-2.83-1.43-.15-.39-.49-.67-.9-.67H8.6c-.72 0-1.24.74-.95 1.39.59 1.33 1.89 2.12 3.36 2.44v.67c0 .83.67 1.5 1.5 1.5s1.5-.67 1.5-1.5v-.65c.96-.18 1.83-.55 2.46-1.12l1.51 1.51c.39.39 1.02.39 1.41 0 .39-.39.39-1.02 0-1.41L6.18 4.62c-.39-.39-1.02-.39-1.41 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
