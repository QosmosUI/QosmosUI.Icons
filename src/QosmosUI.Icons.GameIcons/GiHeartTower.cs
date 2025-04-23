// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHeartTower : ComponentBase
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
		builder.AddAttribute(14, "d", "M67.813 23.03v111.126l61.156 75.813v188.655H89.624l-28.72 92.813h389.158l-28.72-92.813H382V209.97l61.156-75.814V23.03H378.72v52.407h-39.19V23.032h-65.124v52.407h-38.53V23.032H170.75v52.407h-38.5V23.032H67.812zm132.343 143.907c20.707-.04 41.94 10.97 55.156 35.782 32.476-55.953 118.296-42.723 116.094 26.218-2.067 64.67-89.716 86.23-116.094 154.906-27.862-68.683-117.91-86.106-115.75-154.906 1.203-38.326 30.33-61.943 60.594-62zm113.78 20.657c-5.106 0-9.948 1.022-14.373 2.844 12.334 1.777 25.138 10.802 33.28 24.906 7.318 12.674 9.206 26.573 6.157 37.656 7.633-6.842 12.406-16.793 12.406-27.938 0-20.81-16.657-37.468-37.47-37.468z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
