// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiQuoteRight : ComponentBase
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
		builder.AddAttribute(15, "d", "M7.307 6.862c0-1.946-1.583-3.529-3.529-3.529-1.945 0-3.528 1.583-3.528 3.529 0 1.945 1.583 3.528 3.528 3.528 0.734 0 1.416-0.227 1.981-0.611-1.231 3.47-3.99 3.877-4.133 3.896l0.123 0.992c0.051-0.006 5.125-0.703 5.563-7.724l-0.013-0.001c0.001-0.027 0.008-0.052 0.008-0.080zM3.778 9.391c-1.394 0-2.528-1.134-2.528-2.528s1.134-2.529 2.528-2.529c1.395 0 2.529 1.135 2.529 2.529s-1.134 2.528-2.529 2.528zM16.734 6.942c0.001-0.027 0.008-0.053 0.008-0.080 0-1.946-1.583-3.529-3.528-3.529s-3.528 1.583-3.528 3.529c0 1.945 1.583 3.528 3.528 3.528 0.734 0 1.416-0.227 1.981-0.611-1.23 3.47-3.99 3.877-4.133 3.896l0.123 0.992c0.051-0.006 5.125-0.703 5.563-7.724l-0.014-0.001zM13.214 9.391c-1.394 0-2.528-1.134-2.528-2.528s1.134-2.529 2.528-2.529 2.528 1.135 2.528 2.529-1.134 2.528-2.528 2.528z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
