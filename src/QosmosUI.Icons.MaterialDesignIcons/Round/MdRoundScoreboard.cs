// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundScoreboard : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M17.5,13.5H16v-3h1.5V13.5z M16,2c-0.55,0-1,0.45-1,1v1H9V3c0-0.55-0.45-1-1-1S7,2.45,7,3v1H4C2.9,4,2,4.9,2,6v12 c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6c0-1.1-0.9-2-2-2h-3V3C17,2.45,16.55,2,16,2z M9.5,14.25C9.5,14.66,9.16,15,8.75,15H6 c-0.55,0-1-0.45-1-1v-1.5c0-0.55,0.45-1,1-1h2v-1H5.75C5.34,10.5,5,10.16,5,9.75S5.34,9,5.75,9H8.5c0.55,0,1,0.45,1,1v1.5 c0,0.55-0.45,1-1,1h-2v1h2.25C9.16,13.5,9.5,13.84,9.5,14.25z M19,14c0,0.55-0.45,1-1,1h-2.5c-0.55,0-1-0.45-1-1v-4 c0-0.55,0.45-1,1-1H18c0.55,0,1,0.45,1,1V14z M12.75,6.75c0,0.41-0.34,0.75-0.75,0.75s-0.75-0.34-0.75-0.75S11.59,6,12,6 S12.75,6.34,12.75,6.75z M12.75,10.25c0,0.41-0.34,0.75-0.75,0.75s-0.75-0.34-0.75-0.75S11.59,9.5,12,9.5S12.75,9.84,12.75,10.25z M12.75,13.75c0,0.41-0.34,0.75-0.75,0.75s-0.75-0.34-0.75-0.75S11.59,13,12,13S12.75,13.34,12.75,13.75z M12.75,17.25 c0,0.41-0.34,0.75-0.75,0.75s-0.75-0.34-0.75-0.75S11.59,16.5,12,16.5S12.75,16.84,12.75,17.25z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
