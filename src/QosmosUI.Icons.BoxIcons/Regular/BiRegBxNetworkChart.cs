// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxNetworkChart : ComponentBase
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
		builder.AddAttribute(14, "d", "M19 3c-1.654 0-3 1.346-3 3 0 .502.136.968.354 1.385l-1.116 1.302A3.976 3.976 0 0 0 13 8c-.739 0-1.425.216-2.02.566L9.566 7.152A3.449 3.449 0 0 0 10 5.5C10 3.57 8.43 2 6.5 2S3 3.57 3 5.5 4.57 9 6.5 9c.601 0 1.158-.166 1.652-.434L9.566 9.98A3.972 3.972 0 0 0 9 12c0 .997.38 1.899.985 2.601l-1.692 1.692.025.025A2.962 2.962 0 0 0 7 16c-1.654 0-3 1.346-3 3s1.346 3 3 3 3-1.346 3-3c0-.476-.121-.919-.318-1.318l.025.025 1.954-1.954c.421.15.867.247 1.339.247 2.206 0 4-1.794 4-4a3.96 3.96 0 0 0-.439-1.785l1.253-1.462c.364.158.764.247 1.186.247 1.654 0 3-1.346 3-3s-1.346-3-3-3zM7 20a1 1 0 1 1 0-2 1 1 0 0 1 0 2zM5 5.5C5 4.673 5.673 4 6.5 4S8 4.673 8 5.5 7.327 7 6.5 7 5 6.327 5 5.5zm8 8.5c-1.103 0-2-.897-2-2s.897-2 2-2 2 .897 2 2-.897 2-2 2zm6-7a1 1 0 1 1 0-2 1 1 0 0 1 0 2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
