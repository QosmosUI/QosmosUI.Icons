// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWifi2Bar : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "display", "none");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "display", "inline");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "height", "24");
		builder.AddAttribute(19, "width", "24");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "display", "inline");
		builder.AddAttribute(22, "fill", "none");
		builder.AddAttribute(23, "height", "24");
		builder.AddAttribute(24, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,16c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S13.1,16,12,16z M5.38,14.37c-0.63-0.63-0.59-1.71,0.13-2.24 C7.33,10.79,9.57,10,12,10c2.43,0,4.67,0.79,6.49,2.13c0.72,0.53,0.76,1.6,0.13,2.24c-0.53,0.54-1.37,0.57-1.98,0.12 C15.33,13.55,13.73,13,12,13c-1.73,0-3.33,0.55-4.64,1.49C6.75,14.93,5.91,14.9,5.38,14.37z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
