// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoSparklesFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.4 3.419a.639.639 0 0 1 1.2 0l.61 1.668a9.587 9.587 0 0 0 5.703 5.703l1.668.61a.639.639 0 0 1 0 1.2l-1.668.61a9.587 9.587 0 0 0-5.703 5.703l-.61 1.668a.639.639 0 0 1-1.2 0l-.61-1.668a9.587 9.587 0 0 0-5.703-5.703l-1.668-.61a.639.639 0 0 1 0-1.2l1.668-.61a9.587 9.587 0 0 0 5.703-5.703l.61-1.668ZM8 16.675a.266.266 0 0 1 .5 0l.254.694a3.992 3.992 0 0 0 2.376 2.377l.695.254a.266.266 0 0 1 0 .5l-.695.254a3.992 3.992 0 0 0-2.376 2.377l-.254.694a.266.266 0 0 1-.5 0l-.254-.694a3.992 3.992 0 0 0-2.376-2.377l-.695-.254a.266.266 0 0 1 0-.5l.695-.254a3.992 3.992 0 0 0 2.376-2.377L8 16.675ZM4.2.21a.32.32 0 0 1 .6 0l.305.833a4.793 4.793 0 0 0 2.852 2.852l.833.305a.32.32 0 0 1 0 .6l-.833.305a4.793 4.793 0 0 0-2.852 2.852L4.8 8.79a.32.32 0 0 1-.6 0l-.305-.833a4.793 4.793 0 0 0-2.852-2.852L.21 4.8a.32.32 0 0 1 0-.6l.833-.305a4.793 4.793 0 0 0 2.852-2.852L4.2.21Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
