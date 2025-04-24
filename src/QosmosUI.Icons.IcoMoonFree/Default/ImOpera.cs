// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImOpera : ComponentBase
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
		builder.AddAttribute(14, "d", "M16 8v0 0c0 2.369-1.031 4.5-2.669 5.963-2.053 1-3.966 0.3-4.597-0.137 2.016-0.441 3.537-2.878 3.537-5.825s-1.522-5.384-3.537-5.828c0.634-0.438 2.547-1.137 4.597-0.138 1.637 1.466 2.669 3.597 2.669 5.966v0 0z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M5.366 3.491c-0.884 1.044-1.456 2.587-1.494 4.322 0 0.003 0 0.372 0 0.378 0.038 1.731 0.613 3.275 1.497 4.319 1.147 1.491 2.853 2.434 4.759 2.434 1.172 0 2.269-0.356 3.206-0.978-1.419 1.266-3.287 2.034-5.334 2.034-0.128 0-0.256-0.003-0.381-0.009-4.241-0.2-7.619-3.7-7.619-7.991 0-4.419 3.581-8 8-8 0.009 0 0.019 0 0.031 0 2.037 0.006 3.894 0.775 5.303 2.038-0.938-0.622-2.034-0.981-3.206-0.981-1.906 0-3.612 0.944-4.763 2.434z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
