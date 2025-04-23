// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiJsfiddle : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.5 10.867c0 1.711-1.414 3.102-3.148 3.102-0.062 0-0.117-0.008-0.172-0.008h-9.508c-1.75-0.102-3.172-1.438-3.172-3.172 0-1.164 0.633-2.18 1.578-2.734-0.062-0.203-0.094-0.414-0.094-0.641 0-1.195 0.977-2.164 2.195-2.164 0.5 0 0.969 0.172 1.344 0.453 0.766-1.578 2.391-2.672 4.289-2.672 2.633 0 4.758 2.102 4.758 4.688 0 0.094-0.008 0.188-0.008 0.281 1.133 0.469 1.938 1.578 1.938 2.867zM6.438 12.141c0.766 0 1.32-0.242 1.875-0.773-0.227-0.281-0.477-0.555-0.711-0.836-0.32 0.312-0.672 0.508-1.125 0.508-0.555 0-1.031-0.367-1.031-0.945 0-0.57 0.477-0.945 1.016-0.945 1.719 0 2.086 3 4.586 3 1.219 0 2.25-0.766 2.25-2.047 0-1.297-1.039-2.055-2.273-2.055-0.766 0-1.336 0.219-1.883 0.758 0.25 0.273 0.484 0.562 0.727 0.844 0.312-0.305 0.664-0.5 1.109-0.5 0.516 0 1.031 0.367 1.031 0.914 0 0.602-0.438 0.984-1.023 0.984-1.664 0-2.109-3-4.547-3-1.211 0-2.281 0.742-2.281 2.031-0.002 1.319 1.037 2.062 2.28 2.062z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
