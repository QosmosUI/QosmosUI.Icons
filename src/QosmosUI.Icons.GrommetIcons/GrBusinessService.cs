// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrBusinessService : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M4,23 L1,23 L1,5 L1,5 L23,5 L23,23 L16,23 M8,5 L8,1 L8,1 L16,1 L16,5 M9,16 C11.209139,16 13,14.209139 13,12 C13,9.790861 11.209139,8 9,8 C6.790861,8 5,9.790861 5,12 C5,14.209139 6.790861,16 9,16 Z M14.0084967,17.8761594 C14.3255566,17.9570186 14.6577589,18 15,18 C17.209139,18 19,16.209139 19,14 C19,11.790861 17.209139,10 15,10 C14.1717747,10 13.4023412,10.2517171 12.7640287,10.6828219 M7.70199467,15.7255728 C6.67265121,16.4493031 6,17.6460985 6,19 C6,21.209139 7.790861,23 10,23 L10,23 C12.209139,23 14,21.209139 14,19 C14,17.2838286 12.9192205,15.8200868 11.4011657,15.2522789");
		builder.CloseElement();
		builder.CloseElement();
    }
}
