// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImSteam2 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M4.749 13.063c0.424 0 0.84-0.205 1.093-0.585 0.402-0.603 0.239-1.418-0.364-1.82l-1.032-0.688c0.177-0.048 0.362-0.074 0.554-0.074 1.162 0 2.105 0.942 2.105 2.105s-0.942 2.105-2.105 2.105c-1.131 0-2.054-0.893-2.102-2.012l1.124 0.749c0.224 0.149 0.477 0.221 0.727 0.221zM13.333 0c1.467 0 2.667 1.2 2.667 2.667v10.666c0 1.468-1.2 2.667-2.667 2.667h-10.666c-1.467 0-2.667-1.199-2.667-2.667v-3.172l1.896 1.264c-0.182 0.987 0.108 2.044 0.872 2.808 1.233 1.233 3.232 1.233 4.465 0 0.757-0.757 1.049-1.804 0.876-2.784l3.892-3.484c0.723-0.104 1.419-0.433 1.975-0.989 1.367-1.367 1.367-3.583 0-4.95s-3.583-1.367-4.95 0c-0.556 0.556-0.886 1.252-0.989 1.975v0l-3.198 4.847c-0.498 0.025-0.99 0.168-1.433 0.428l-3.404-2.269v-4.339c0-1.467 1.2-2.667 2.667-2.667h10.666zM14 4.5c0-1.381-1.119-2.5-2.5-2.5s-2.5 1.119-2.5 2.5 1.119 2.5 2.5 2.5 2.5-1.119 2.5-2.5zM10 4.5c0-0.828 0.672-1.5 1.5-1.5s1.5 0.672 1.5 1.5-0.672 1.5-1.5 1.5-1.5-0.672-1.5-1.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
