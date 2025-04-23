// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMapsUgc : ComponentBase
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
		builder.AddAttribute(15, "fill-rule", "evenodd");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12,4c4.97,0,8.9,4.56,7.82,9.72c-0.68,3.23-3.4,5.74-6.67,6.2c-1.59,0.22-3.14-0.01-4.58-0.7 c-0.27-0.13-0.56-0.19-0.86-0.19c-0.19,0-0.38,0.03-0.56,0.08l-2.31,0.68c-0.38,0.11-0.74-0.24-0.63-0.63l0.7-2.39 c0.13-0.45,0.07-0.92-0.14-1.35C4.26,14.34,4,13.18,4,12C4,7.59,7.59,4,12,4 M12,2C6.48,2,2,6.48,2,12c0,1.54,0.36,2.98,0.97,4.29 l-1.46,4.96C1.29,22,2,22.71,2.76,22.48l4.96-1.46c1.66,0.79,3.56,1.15,5.58,0.89c4.56-0.59,8.21-4.35,8.66-8.92 C22.53,7.03,17.85,2,12,2L12,2z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M12,8L12,8c-0.55,0-1,0.45-1,1v2H9c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h2v2 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-2h2c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-2V9C13,8.45,12.55,8,12,8z");
		builder.AddAttribute(23, "fill-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
    }
}
