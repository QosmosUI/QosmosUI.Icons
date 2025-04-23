// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoStopwatch : ComponentBase
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
		builder.AddAttribute(14, "d", "M10.25 0h3.5a.75.75 0 0 1 0 1.5h-1v1.278a9.954 9.954 0 0 1 5.636 2.276L19.72 3.72a.751.751 0 0 1 1.042.018.751.751 0 0 1 .018 1.042l-1.315 1.316A9.959 9.959 0 0 1 22 12.75c0 5.523-4.477 10-10 10s-10-4.477-10-10a9.959 9.959 0 0 1 2.535-6.654L3.22 4.78a.751.751 0 0 1 .018-1.042.751.751 0 0 1 1.042-.018l1.335 1.334a9.958 9.958 0 0 1 5.635-2.276V1.5h-1a.75.75 0 0 1 0-1.5ZM12 21.25a8.5 8.5 0 1 0-.001-17.001A8.5 8.5 0 0 0 12 21.25Zm4.03-12.53a.75.75 0 0 1 0 1.06l-2.381 2.382a1.75 1.75 0 1 1-1.06-1.06l2.38-2.382a.75.75 0 0 1 1.061 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
