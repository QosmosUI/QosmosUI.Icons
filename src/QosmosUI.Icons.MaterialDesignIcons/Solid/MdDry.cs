// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdDry : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M15.65,4.86l-0.07-0.07c-0.57-0.62-0.82-1.41-0.67-2.2L15,2h-1.89l-0.06,0.43c-0.2,1.36,0.27,2.71,1.3,3.72l0.07,0.06 c0.57,0.62,0.82,1.41,0.67,2.2L14.98,9h1.91l0.06-0.43C17.16,7.21,16.68,5.86,15.65,4.86z M19.65,4.86l-0.07-0.07 c-0.57-0.62-0.82-1.41-0.67-2.2L19,2h-1.89l-0.06,0.43c-0.2,1.36,0.27,2.71,1.3,3.72l0.07,0.06c0.57,0.62,0.82,1.41,0.67,2.2 L18.98,9h1.91l0.06-0.43C21.16,7.21,20.68,5.86,19.65,4.86z M9.12,5l-7.18,6.79C1.34,12.35,1,13.14,1,13.97V20c0,1.66,1.34,3,3,3 h6.25H12h5.75c0.69,0,1.25-0.56,1.25-1.25s-0.56-1.25-1.25-1.25H12v-1h7.75c0.69,0,1.25-0.56,1.25-1.25S20.44,17,19.75,17H12v-1 h8.75c0.69,0,1.25-0.56,1.25-1.25s-0.56-1.25-1.25-1.25H12v-1h6.75c0.69,0,1.25-0.56,1.25-1.25S19.44,10,18.75,10H8.86 c0.64-1.11,1.48-2.58,1.49-2.61c0.09-0.16,0.14-0.33,0.14-0.53c0-0.26-0.09-0.5-0.26-0.7C10.22,6.12,9.12,5,9.12,5L9.12,5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
