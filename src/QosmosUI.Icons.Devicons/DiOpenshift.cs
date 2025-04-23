// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiOpenshift : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "34";

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
    public string ViewBox { get; set; } = "0 0 34 32";

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
		builder.AddAttribute(14, "d", "M11.838 14.851l-3.895 1.417c0.050 0.624 0.158 1.241 0.309 1.846l3.7-1.347c-0.12-0.625-0.163-1.27-0.114-1.916z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M29.050 10.545c-0.272-0.56-0.586-1.102-0.95-1.612l-3.894 1.417c0.453 0.464 0.833 0.985 1.144 1.542l3.7-1.347z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20.482 9.442c0.81 0.378 1.512 0.894 2.104 1.498l3.894-1.417c-1.079-1.513-2.548-2.778-4.348-3.618-5.567-2.596-12.208-0.179-14.804 5.387-0.84 1.801-1.152 3.715-1.006 5.567l3.895-1.417c0.065-0.844 0.271-1.689 0.648-2.5 1.687-3.617 6.001-5.186 9.617-3.5z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M8.494 18.026l-3.7 1.348c0.34 1.349 0.93 2.631 1.74 3.772l3.886-1.414c-0.997-1.025-1.661-2.321-1.926-3.705z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M24.635 16.558c-0.062 0.843-0.275 1.689-0.654 2.5-1.687 3.617-6.001 5.186-9.617 3.5-0.811-0.379-1.518-0.89-2.108-1.496l-3.886 1.415c1.076 1.513 2.544 2.779 4.345 3.619 5.567 2.595 12.207 0.178 14.803-5.388 0.841-1.8 1.151-3.713 1.002-5.564l-3.886 1.414z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M25.592 11.803l-3.7 1.347c0.687 1.231 1.012 2.649 0.906 4.075l3.886-1.414c-0.111-1.395-0.483-2.756-1.092-4.008z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
