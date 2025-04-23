// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxColor : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M12 2a10 10 0 1 0 10 10A10 10 0 0 0 12 2zm0 13a3 3 0 1 1 3-3 3 3 0 0 1-3 3zm2.75-7.17A5 5 0 0 0 13 7.1v-3a7.94 7.94 0 0 1 3.9 1.62zM11 7.1a5 5 0 0 0-1.75.73L7.1 5.69A7.94 7.94 0 0 1 11 4.07zM7.83 9.25A5 5 0 0 0 7.1 11h-3a7.94 7.94 0 0 1 1.59-3.9zM7.1 13a5 5 0 0 0 .73 1.75L5.69 16.9A7.94 7.94 0 0 1 4.07 13zm2.15 3.17a5 5 0 0 0 1.75.73v3a7.94 7.94 0 0 1-3.9-1.62zm3.75.73a5 5 0 0 0 1.75-.73l2.15 2.14a7.94 7.94 0 0 1-3.9 1.62zm3.17-2.15A5 5 0 0 0 16.9 13h3a7.94 7.94 0 0 1-1.62 3.9zM16.9 11a5 5 0 0 0-.73-1.75l2.14-2.15a7.94 7.94 0 0 1 1.62 3.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
