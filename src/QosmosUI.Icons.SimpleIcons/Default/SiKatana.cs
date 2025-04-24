// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiKatana : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.373 0 0 5.373 0 12s5.373 12 12 12 12-5.373 12-12S18.627 0 12 0zm.016 22.762H12c-5.95-.009-10.765-4.84-10.756-10.789.009-5.95 4.839-10.766 10.789-10.757 5.943.009 10.756 4.829 10.756 10.773 0 5.95-4.823 10.773-10.773 10.773zm9.475-10.857a5.562 5.562 0 0 1-9.142 3.214 6.331 6.331 0 0 0 3.251-2.062l.104.169c.339.584.568 1.226.676 1.893a6.281 6.281 0 0 0-.349-2.656 6.328 6.328 0 0 0-8.94-8.63 5.563 5.563 0 0 1 7.418 6.256 6.334 6.334 0 0 0-3.425-1.762l.093-.175a5.53 5.53 0 0 1 1.304-1.533 6.31 6.31 0 0 0-2.122 1.636 6.327 6.327 0 0 0-3.016 12.044 5.564 5.564 0 0 1 1.713-9.562 6.33 6.33 0 0 0 .185 3.818h-.186a5.535 5.535 0 0 1-1.98-.36 6.295 6.295 0 0 0 2.471 1.025 6.328 6.328 0 0 0 8.513 2.758 6.319 6.319 0 0 0 3.432-6.073zm-11.018-1.443a5.582 5.582 0 0 1 3.6.998 5.584 5.584 0 0 1-2.667 2.618 5.57 5.57 0 0 1-.933-3.616z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
