// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiMicrophone : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.5 12c2.481 0 4.5-2.019 4.5-4.5v-3c0-2.311-1.756-4.197-4-4.449v-0.051h-1v0.051c-2.244 0.252-4 2.138-4 4.449v3c0 2.481 2.019 4.5 4.5 4.5zM6 2.059v1.941h1v-2.648c0.312-0.149 0.646-0.25 1-0.301v2.949h1v-2.949c0.354 0.051 0.688 0.151 1 0.301v2.648h1v-1.941c0.617 0.631 1 1.491 1 2.441v0.5h-7v-0.5c0-0.95 0.383-1.811 1-2.441zM5 6h7v1.5c0 1.93-1.57 3.5-3.5 3.5s-3.5-1.57-3.5-3.5v-1.5zM15 7v3.25c0 2.067-2.019 3.75-4.5 3.75h-1.5v3h-1v-3h-1.5c-2.481 0-4.5-1.683-4.5-3.75v-3.25h1v3.25c0 1.517 1.57 2.75 3.5 2.75h4c1.93 0 3.5-1.233 3.5-2.75v-3.25h1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
