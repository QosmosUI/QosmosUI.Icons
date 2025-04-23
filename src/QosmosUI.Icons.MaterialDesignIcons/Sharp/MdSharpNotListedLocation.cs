// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpNotListedLocation : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M12.01 16a.99.99 0 001-1 .99.99 0 00-1-1c-.28 0-.51.1-.71.29-.2.19-.3.43-.3.7s.1.51.29.71c.2.2.44.3.72.3zm-.88-3.66V13h1.85v-.42c0-.33.06-.6.18-.81.12-.21.33-.47.65-.77.4-.38.68-.75.89-1.09.19-.35.3-.76.3-1.25s-.13-.94-.39-1.35a2.57 2.57 0 00-1.05-.96C13.11 6.12 12.58 6 12 6c-.78 0-1.51.32-2.03.79C9.46 7.27 9 7.99 9 9h1.68c0-.52.19-.77.4-.98.21-.2.58-.3.96-.3.35 0 .64.1.85.3.21.2.32.45.32.74 0 .24-.06.46-.19.64-.13.19-.33.41-.61.66-.48.42-.81.79-1 1.12-.19.33-.28.71-.28 1.16zM12 2c4.2 0 8 3.22 8 8.2 0 3.32-2.67 7.25-8 11.8-5.33-4.55-8-8.48-8-11.8C4 5.22 7.8 2 12 2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
