// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHail : ComponentBase
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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,6c-1.1,0-2-0.9-2-2s0.9-2,2-2s2,0.9,2,2S13.1,6,12,6z M17.95,2L17.95,2c0.59,0,1.06,0.51,1,1.09 C18.93,3.24,18.74,7.15,15,8.4V21c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1v-5h-2v5c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1V10.1 c-0.3,0.1-0.5,0.2-0.6,0.3c-0.46,0.36-1.17,0.87-1.36,2.67C6.99,13.59,6.57,14,6.04,14h0c-0.58,0-1.05-0.49-1-1.07 c0.13-1.6,0.62-2.98,2.07-4.22C8.21,7.81,10,7,12,7s2.68-0.46,3.48-1.06c0.43-0.34,1.28-0.99,1.48-3.02C17.01,2.4,17.43,2,17.95,2z M5,16h1c0.55,0,1,0.45,1,1v4c0,0.55-0.45,1-1,1H5c-0.55,0-1-0.45-1-1v-4C4,16.45,4.45,16,5,16z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
