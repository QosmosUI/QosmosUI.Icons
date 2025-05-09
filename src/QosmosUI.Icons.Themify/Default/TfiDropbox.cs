// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiDropbox : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.853 4.371l-5.296-3.454-3.057 2.538-3.046-2.538-5.307 3.454 3.1 2.476-3.099 2.482 3.444 2.243v1.533l4.917 2.939 4.926-2.938v-1.548l3.417-2.23-3.098-2.481 3.099-2.476zM11.627 2.157l3.52 2.296-2.232 1.782-3.56-2.19 2.272-1.888zM12 6.847l-3.5 2.159-3.5-2.159 3.5-2.154 3.5 2.154zM1.853 4.453l3.527-2.296 2.265 1.887-3.561 2.191-2.231-1.782zM1.852 9.245l2.232-1.789 3.562 2.198-2.266 1.89-3.528-2.299zM12.435 12.538l-3.925 2.343-3.917-2.342v-0.315l0.862 0.561 3.047-2.54 3.056 2.54 0.878-0.573v0.326zM15.148 9.246l-3.521 2.298-2.273-1.89 3.561-2.198 2.233 1.79z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
