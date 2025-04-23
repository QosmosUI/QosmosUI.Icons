// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiK3s : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.46 2.172H2.54A2.548 2.548 0 0 0 0 4.712v14.575a2.548 2.548 0 0 0 2.54 2.54h18.92a2.548 2.548 0 0 0 2.54-2.54V4.713a2.548 2.548 0 0 0-2.54-2.54ZM10.14 16.465 5.524 19.15a1.235 1.235 0 1 1-1.242-2.137L8.9 14.33a1.235 1.235 0 1 1 1.241 2.136zm1.817-4.088h-.006a1.235 1.235 0 0 1-1.23-1.24l.023-5.32a1.236 1.236 0 0 1 1.236-1.23h.005a1.235 1.235 0 0 1 1.23 1.241l-.023 5.32a1.236 1.236 0 0 1-1.235 1.23zm8.17 6.32a1.235 1.235 0 0 1-1.688.453l-4.624-2.67a1.235 1.235 0 1 1 1.235-2.14l4.624 2.67a1.235 1.235 0 0 1 .452 1.688z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
