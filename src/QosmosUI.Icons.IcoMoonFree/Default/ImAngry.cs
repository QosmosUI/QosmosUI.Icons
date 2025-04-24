// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImAngry : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M8 16c4.418 0 8-3.582 8-8s-3.582-8-8-8-8 3.582-8 8 3.582 8 8 8zM8 1.5c3.59 0 6.5 2.91 6.5 6.5s-2.91 6.5-6.5 6.5-6.5-2.91-6.5-6.5 2.91-6.5 6.5-6.5zM11.002 12.199c-0.612-1.018-1.727-1.699-3.002-1.699s-2.389 0.681-3.002 1.699l-1.286-0.772c0.874-1.454 2.467-2.427 4.288-2.427s3.414 0.973 4.288 2.427l-1.286 0.772zM11.985 4.379c0.067 0.268-0.096 0.539-0.364 0.606-0.275 0.070-0.602 0.189-0.89 0.334 0.166 0.179 0.268 0.418 0.268 0.681 0 0.552-0.448 1-1 1s-1-0.448-1-1c0-0.018 0.001-0.036 0.002-0.054 0.032-0.741 0.706-1.234 1.275-1.518 0.543-0.271 1.080-0.407 1.102-0.413 0.268-0.067 0.539 0.096 0.606 0.364zM4.015 4.379c0.067-0.268 0.338-0.431 0.606-0.364 0.023 0.006 0.559 0.141 1.102 0.413 0.568 0.284 1.243 0.776 1.275 1.518 0.001 0.018 0.002 0.036 0.002 0.054 0 0.552-0.448 1-1 1s-1-0.448-1-1c0-0.263 0.102-0.503 0.268-0.681-0.288-0.144-0.614-0.264-0.89-0.334-0.268-0.067-0.431-0.338-0.364-0.606z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
