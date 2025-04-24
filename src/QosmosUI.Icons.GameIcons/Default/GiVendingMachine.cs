// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiVendingMachine : ComponentBase
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
		builder.AddAttribute(14, "d", "M100 29v454h312V29zm18 18h210v338H118zm226 16h50v66h-50zm18 18v30h14V81zm-203 7v23h-16v18h160v-18h-64V80l-16 6-6 25h-26V88zm194 55h32v18h-32zm-90 10.8c-5.4 0-10.1 3-12.8 6.7-2.9 4.9-4.5 9.6-4.1 14.5H143v18h160v-18h-23.1c.3-5.1-1.6-11-4.1-14.5-2.7-3.7-7.4-6.7-12.8-6.7zm90 21.2h32v18h-32zm-194 41v23h-16v18h160v-18h-24v-23h-24v23h-32v-31h-16v31h-32v-15zm8 61.4c-6.1 0-10.8 3.9-13.3 8-3.2 6.1-4 11.5-3.5 17.6H143v18h160v-18h-64v-23h-32v23h-23.2c.6-6-.7-13-3.5-17.6-2.5-4.1-7.2-8-13.3-8zM353 351h32v18h-32zm-235 52h210v62H118zm18 18v26h174v-26z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
