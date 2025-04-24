// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRaggedWound : ComponentBase
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
		builder.AddAttribute(14, "d", "M27.438 28c-2.13.008-4.264.054-6.407.156C55.4 55.93 66.44 113.052 81.126 161.344c36.747-81.008 70.31 15.56 85.313 133.187 19.56-157.11 81.692-39.362 117.75 24.19-3.213-72.754 106.18-22.386 126.625 48.436 13.595-60.515 45.038-53.18 82.406 13.156-5.587-75.425-47.698-149.916-98.158-109.562 6.667-98.496-65.15-100.515-91.25-67.406-15.74-40.536-96.467-119.32-106.5-42.313C152.726 72.62 93.442 27.748 27.438 28zM81.5 191.53c-5.156 15.956-49.635 88.657 0 88.657 49.667 0 3.134-72.61 0-88.656zm85.563 129.69c-6.08 22.943-58.522 127.5 0 127.5 58.558 0 3.694-104.426 0-127.5zm243.875 64.28c-4.133 13.405-39.774 74.5 0 74.5 39.797 0 2.51-61.018 0-74.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
