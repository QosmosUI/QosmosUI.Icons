// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxLemon : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 22a9.83 9.83 0 0 1-3.26-.55 2.23 2.23 0 0 0-1.7.19 3.51 3.51 0 0 1-2.47.24 3.55 3.55 0 0 1-2.45-2.45A3.51 3.51 0 0 1 2.36 17a2.23 2.23 0 0 0 .19-1.7 10.07 10.07 0 0 1 0-6.53 9.87 9.87 0 0 1 6.18-6.23 10.07 10.07 0 0 1 6.53 0A2.23 2.23 0 0 0 17 2.36a3.51 3.51 0 0 1 2.47-.24 3.55 3.55 0 0 1 2.45 2.45A3.51 3.51 0 0 1 21.64 7a2.23 2.23 0 0 0-.19 1.7 10.07 10.07 0 0 1 0 6.53 9.87 9.87 0 0 1-6.19 6.19A10.33 10.33 0 0 1 12 22zm-3.84-2.64a3.91 3.91 0 0 1 1.23.2 8 8 0 0 0 5.24 0 7.84 7.84 0 0 0 4.94-4.93 8 8 0 0 0 0-5.24 4.19 4.19 0 0 1 .29-3.23 1.53 1.53 0 0 0 .09-1.08 1.49 1.49 0 0 0-1-1 1.53 1.53 0 0 0-1.08.09 4.19 4.19 0 0 1-3.23.29 8 8 0 0 0-5.24 0 7.84 7.84 0 0 0-4.97 4.91 8 8 0 0 0 0 5.24 4.19 4.19 0 0 1-.29 3.23 1.53 1.53 0 0 0-.09 1.08 1.49 1.49 0 0 0 1 1 1.53 1.53 0 0 0 1.08-.09 4.47 4.47 0 0 1 2.03-.47z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M8 12H6a6 6 0 0 1 6-6v2a4 4 0 0 0-4 4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
