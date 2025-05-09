// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBowlingPropulsion : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M84.04 18.37c-12.7 8.85-20.6 27.75-20.5 45.98.19 34.2 27.8 61.95 61.86 61.95 27 0 49.9-17.2 58.4-41.25.8 5.2 1.2 10.4 1.2 15.75 0 59.2-47.9 107.1-107.06 107.1-22.1 0-42.54-6.7-59.58-18.1v21.8c17.75 9.5 38.08 15 59.58 15 69.26 0 125.76-56.5 125.76-125.8 0-31.47-11.7-60.33-30.8-82.43-85.84.75-12.9.53-88.86 0zM226.5 102.8c0 80.7-65.5 146-146.36 146-22.1 0-43.01-4.9-61.78-13.6v20.4c18.12 8.5 44.48 12.3 65.18 11.9l71.06 98.9-12.1-88.5L263 493.6h21.4L160.9 272.5l172 221.1h160.7V338.5L304.2 196.6l130.1 43-169.2-113.7 68.7 6.6-89.1-42.45c-2-26.01-10.1-50.4-22.9-71.67h-22.3c15.9 27.68 26.7 58.12 27 84.42zm-188.16 5.1c-7.72 0-14.74 3-19.98 7.9v42.9c5.24 4.9 12.26 7.9 19.98 7.9 16.2 0 29.3-13.2 29.3-29.4s-13.1-29.3-29.3-29.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
