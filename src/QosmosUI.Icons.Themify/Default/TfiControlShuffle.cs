// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiControlShuffle : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M8.94 6.871l1.081-1.34-0.004-0.003c0.855-0.971 2.087-1.528 3.378-1.528h1.898l-1.646-1.646 0.707-0.707 2.853 2.853-2.854 2.854-0.707-0.707 1.647-1.647h-1.898c-0.989 0-1.931 0.425-2.595 1.159l-1.080 1.339-0.78-0.627zM5.851 10.696l-0.011-0.008c-0.667 0.833-1.663 1.312-2.733 1.312h-3.107v1h3.107c1.369 0 2.645-0.611 3.503-1.676l0.011 0.009 0.941-1.166-0.777-0.629-0.934 1.158zM13.646 10.354l1.647 1.646h-1.898c-1.052 0-2.031-0.469-2.7-1.281l-4.269-5.265-0.010 0.008c-0.85-0.926-2.048-1.462-3.309-1.462h-3.107v1h3.107c0.998 0 1.948 0.428 2.611 1.17l4.161 5.132-0.005 0.004c0.86 1.076 2.143 1.694 3.52 1.694h1.898l-1.646 1.646 0.707 0.707 2.854-2.854-2.854-2.854-0.707 0.709z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
