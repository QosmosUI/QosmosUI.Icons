// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BootstrapIcons.Fill;

public class BsFillMouse3 : ComponentBase
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
		builder.AddAttribute(14, "d", "M8.5.069A15 15 0 0 0 7 0q-.891.002-1.527.463c-.418.302-.717.726-.93 1.208-.386.873-.522 2.01-.54 3.206l4.497 1zM3.71 5.836 3.381 6A2.5 2.5 0 0 0 2 8.236v2.576C2 13.659 4.22 16 7 16h2c2.78 0 5-2.342 5-5.188V8.123l-9-2v.003l.008.353c.007.3.023.715.053 1.175.063.937.186 2.005.413 2.688a.5.5 0 1 1-.948.316c-.273-.817-.4-2-.462-2.937A30 30 0 0 1 4 6.003q0-.05.01-.1zM14 7.1V5.187c0-1.13-.272-2.044-.748-2.772-.474-.726-1.13-1.235-1.849-1.59A7.5 7.5 0 0 0 9.5.212v5.887l4.5 1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
