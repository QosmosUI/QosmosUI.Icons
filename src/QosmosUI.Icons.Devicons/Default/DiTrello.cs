// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiTrello : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M14.96 23.567v-16.642c0-0.152-0.049-0.276-0.146-0.374s-0.222-0.146-0.374-0.146h-7.801c-0.152 0-0.276 0.049-0.374 0.146s-0.146 0.222-0.146 0.374v16.642c0 0.152 0.049 0.276 0.146 0.374s0.222 0.146 0.374 0.146h7.801c0.152 0 0.276-0.049 0.374-0.146s0.146-0.222 0.146-0.374zM25.881 17.326v-10.401c0-0.152-0.049-0.276-0.146-0.374s-0.222-0.146-0.374-0.146h-7.801c-0.152 0-0.276 0.049-0.374 0.146s-0.146 0.222-0.146 0.374v10.401c0 0.152 0.049 0.276 0.146 0.374s0.222 0.146 0.374 0.146h7.801c0.152 0 0.276-0.049 0.374-0.146s0.146-0.222 0.146-0.374zM28.482 4.844v22.883c0 0.282-0.103 0.526-0.309 0.732s-0.45 0.309-0.731 0.309h-22.883c-0.282 0-0.525-0.103-0.731-0.309s-0.309-0.45-0.309-0.732v-22.883c0-0.282 0.103-0.526 0.309-0.731s0.45-0.309 0.731-0.309h22.883c0.282 0 0.526 0.103 0.731 0.309s0.309 0.45 0.309 0.731z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
