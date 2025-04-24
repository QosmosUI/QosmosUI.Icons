// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCodiepie : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16.042969 3 C 8.8629688 3 3.0429688 8.82 3.0429688 16 C 3.0429688 23.18 8.8629688 29 16.042969 29 C 21.476969 29 26.015984 25.663688 27.958984 20.929688 L 17.125 16 L 27.658203 10.191406 C 25.524203 5.9314063 21.131969 3 16.042969 3 z M 16.042969 5 C 19.576969 5 22.813187 6.6662656 24.867188 9.4472656 L 21.285156 11.421875 C 20.003594 9.9398608 18.113489 9 16 9 C 12.134 9 9 12.134 9 16 C 9 19.866 12.134 23 16 23 C 18.277971 23 20.29176 21.905004 21.568359 20.21875 L 25.228516 21.884766 C 23.246516 25.043766 19.812969 27 16.042969 27 C 9.9779687 27 5.0429688 22.065 5.0429688 16 C 5.0429688 9.935 9.9769688 5 16.042969 5 z M 24 13 L 24 18 L 26 18 L 26 16 L 26.5 16 C 27.328 16 28 15.328 28 14.5 C 28 13.672 27.328 13 26.5 13 L 26 13 L 24 13 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
