// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDocumentScanner : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M3,6C2.45,6,2,5.55,2,5V2c0-0.55,0.45-1,1-1h3c0.55,0,1,0.45,1,1S6.55,3,6,3H4v2C4,5.55,3.55,6,3,6z M17,2 c0,0.55,0.45,1,1,1h2v2c0,0.55,0.45,1,1,1s1-0.45,1-1V2c0-0.55-0.45-1-1-1h-3C17.45,1,17,1.45,17,2z M3,18c-0.55,0-1,0.45-1,1v3 c0,0.55,0.45,1,1,1h3c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1H4v-2C4,18.45,3.55,18,3,18z M17,22c0,0.55,0.45,1,1,1h3 c0.55,0,1-0.45,1-1v-3c0-0.55-0.45-1-1-1s-1,0.45-1,1v2h-2C17.45,21,17,21.45,17,22z M19,18c0,1.1-0.9,2-2,2H7c-1.1,0-2-0.9-2-2V6 c0-1.1,0.9-2,2-2h10c1.1,0,2,0.9,2,2V18z M9,9c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1h-4C9.45,8,9,8.45,9,9z M9,12c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1h-4C9.45,11,9,11.45,9,12z M9,15c0,0.55,0.45,1,1,1h4 c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1h-4C9.45,14,9,14.45,9,15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
