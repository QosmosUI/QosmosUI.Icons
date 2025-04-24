// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiChartPieOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M18.227 7.609l.557-.559c.396-.396.607-.943.582-1.504-.026-.561-.286-1.084-.717-1.443-2.129-1.775-4.711-2.848-7.469-3.097l-.18-.006c-.497 0-.979.186-1.35.523-.414.379-.65.915-.65 1.477v2.229c-3.657.865-6.333 4.188-6.333 8.006 0 4.547 3.688 8.244 8.224 8.244 1.594 0 3.11-.479 4.441-1.345.277.142.583.226.9.226l.109-.004c.569-.03 1.098-.305 1.453-.75 1.421-1.781 2.204-4.019 2.204-6.297.002-2.032-.625-4.027-1.771-5.7zm-7.336 11.87c-3.438 0-6.224-2.793-6.224-6.244 0-3.137 2.317-5.729 5.333-6.164v6.408l4.609 4.754c-1.037.779-2.322 1.246-3.718 1.246zm.109-7.454v-9.025c2.411.218 4.607 1.173 6.366 2.641l-6.366 6.384zm.214 1.269l5.019-5.028c1.104 1.385 1.769 3.141 1.769 5.043 0 1.914-.664 3.666-1.769 5.051l-5.019-5.066z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
