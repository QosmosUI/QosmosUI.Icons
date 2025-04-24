// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImBinoculars : ComponentBase
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
		builder.AddAttribute(14, "d", "M1 0h6v1h-6zM9 0h6v1h-6zM14.875 5h-0.875v-4h-4v4h-4v-4h-4v4h-0.875c-0.619 0-1.125 0.506-1.125 1.125v8.75c0 0.619 0.506 1.125 1.125 1.125h4.75c0.619 0 1.125-0.506 1.125-1.125v-5.875h2v5.875c0 0.619 0.506 1.125 1.125 1.125h4.75c0.619 0 1.125-0.506 1.125-1.125v-8.75c0-0.619-0.506-1.125-1.125-1.125zM5.438 15h-3.875c-0.309 0-0.563-0.225-0.563-0.5s0.253-0.5 0.563-0.5h3.875c0.309 0 0.563 0.225 0.563 0.5s-0.253 0.5-0.563 0.5zM8.5 8h-1c-0.275 0-0.5-0.225-0.5-0.5s0.225-0.5 0.5-0.5h1c0.275 0 0.5 0.225 0.5 0.5s-0.225 0.5-0.5 0.5zM14.438 15h-3.875c-0.309 0-0.563-0.225-0.563-0.5s0.253-0.5 0.563-0.5h3.875c0.309 0 0.563 0.225 0.563 0.5s-0.253 0.5-0.563 0.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
