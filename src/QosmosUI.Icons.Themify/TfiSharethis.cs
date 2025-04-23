// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiSharethis : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.5 13.168c0 1.843-1.49 3.332-3.333 3.332-1.844 0-3.333-1.489-3.333-3.332 0-0.116 0.010-0.24 0.020-0.354l-3.75-1.876c-0.593 0.552-1.396 0.896-2.271 0.896-1.844 0-3.333-1.489-3.333-3.334 0-1.843 1.489-3.332 3.333-3.332 0.875 0 1.677 0.343 2.271 0.895l3.75-1.874c-0.010-0.116-0.020-0.24-0.020-0.354 0-1.845 1.489-3.334 3.333-3.334 1.843 0 3.333 1.489 3.333 3.334 0 1.844-1.49 3.333-3.333 3.333-0.875 0-1.677-0.344-2.271-0.896l-3.75 1.875c0.010 0.115 0.021 0.24 0.021 0.354 0 0.115-0.011 0.24-0.021 0.354l3.75 1.877c0.594-0.553 1.397-0.897 2.271-0.897 1.843-0.002 3.333 1.487 3.333 3.333z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
