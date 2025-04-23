// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImStrikethrough : ComponentBase
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
		builder.AddAttribute(14, "d", "M16 8v1h-3.664c0.43 0.602 0.664 1.292 0.664 2 0 1.107-0.573 2.172-1.572 2.921-0.927 0.696-2.145 1.079-3.428 1.079s-2.501-0.383-3.428-1.079c-0.999-0.749-1.572-1.814-1.572-2.921h2c0 1.084 1.374 2 3 2s3-0.916 3-2c0-1.084-1.374-2-3-2h-8v-1h4.68c-0.037-0.026-0.073-0.052-0.108-0.079-0.999-0.749-1.572-1.814-1.572-2.921s0.573-2.172 1.572-2.921c0.927-0.696 2.145-1.079 3.428-1.079s2.501 0.383 3.428 1.079c0.999 0.749 1.572 1.814 1.572 2.921h-2c0-1.084-1.374-2-3-2s-3 0.916-3 2c0 1.084 1.374 2 3 2 1.234 0 2.407 0.354 3.32 1h4.68z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
