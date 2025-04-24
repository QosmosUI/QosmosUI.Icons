// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiAirplane : ComponentBase
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
		builder.AddAttribute(14, "d", "M76.183 264.465l11.224 2.393-4.357 11.62a12.27 12.27 0 1 1-10.353-4.73zM378.67 321.61a21.078 21.078 0 1 0 11.968-5.17l-5.81-13.55h-14.257zm69.208-75.53c0 6.578-.221 12.934-.628 18.686h10.18v-33.93h-9.97c.232 4.845.406 9.981.406 15.28zm-22.903 40.438h-80.7c-115.408 0-213.503-28.504-286.336-42.459C26.415 238.018 21 226.526 21 213.151c0-17.894 9.633-59.656 39.24-59.656 24.576 0 53.08 61.364 62.422 61.364 3.986 0 170.033-9.144 170.033-9.144 0 8.354 13.851 12.526 27.714 12.526 13.862 0 27.887-4.218 27.887-12.62v-22.519s23.868 12.782 30.55 22.566h46.107c8.796 0 8.796 80.886.011 80.886zM408.8 247.802c0-3.998-3.66-7.251-8.134-7.251H248.168c-4.508 0-8.134 3.242-8.134 7.25 0 4.01 3.66 7.251 8.134 7.251h152.453c4.508.035 8.168-3.218 8.168-7.215zm73.984-57.007a8.134 8.134 0 0 0-8.134 8.134v94.283a8.175 8.175 0 0 0 16.349 0v-94.214a8.134 8.134 0 0 0-8.227-8.169z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
