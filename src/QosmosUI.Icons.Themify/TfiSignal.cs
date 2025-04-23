// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiSignal : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.5 4c0-1.654-1.346-3-3-3s-3 1.346-3 3c0 1.483 1.084 2.71 2.5 2.949v8.051h-2v1h5v-1h-2v-8.051c1.416-0.239 2.5-1.466 2.5-2.949zM6.5 4c0-1.103 0.897-2 2-2s2 0.897 2 2-0.897 2-2 2-2-0.897-2-2zM4.504 2.192c-0.378 0.46-0.577 1.004-0.577 1.574s0.199 1.114 0.577 1.574l-0.774 0.636c-0.525-0.641-0.803-1.405-0.803-2.209s0.278-1.569 0.803-2.209l0.774 0.634zM2 3.767c0 1.079 0.387 2.096 1.119 2.938l-0.754 0.656c-0.881-1.012-1.365-2.29-1.365-3.594s0.484-2.582 1.365-3.595l0.754 0.656c-0.732 0.843-1.119 1.86-1.119 2.939zM14.073 3.767c0 0.805-0.278 1.568-0.804 2.209l-0.773-0.635c0.378-0.46 0.577-1.004 0.577-1.574s-0.199-1.114-0.577-1.574l0.773-0.635c0.526 0.64 0.804 1.404 0.804 2.209zM16 3.767c0 1.305-0.484 2.582-1.365 3.595l-0.754-0.656c0.732-0.844 1.119-1.86 1.119-2.939s-0.387-2.096-1.119-2.938l0.754-0.656c0.881 1.012 1.365 2.289 1.365 3.594z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
