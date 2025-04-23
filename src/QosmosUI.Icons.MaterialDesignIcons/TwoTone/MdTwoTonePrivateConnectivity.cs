// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTonePrivateConnectivity : ComponentBase
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
		builder.AddAttribute(18, "d", "M12,7c-2.76,0-5,2.24-5,5s2.24,5,5,5s5-2.24,5-5S14.76,7,12,7z M15,14.5c0,0.55-0.45,1-1,1h-4 c-0.55,0-1-0.45-1-1v-3c0-0.55,0.45-1,1-1v-1c0-1.21,1.08-2.18,2.34-1.97C13.32,7.69,14,8.61,14,9.61v0.89c0.55,0,1,0.45,1,1V14.5z M12.75,13c0,0.41-0.34,0.75-0.75,0.75s-0.75-0.34-0.75-0.75c0-0.41,0.34-0.75,0.75-0.75S12.75,12.59,12.75,13z M13,9.5v1h-2v-1 c0-0.55,0.45-1,1-1S13,8.95,13,9.5z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,7c2.76,0,5,2.24,5,5s-2.24,5-5,5s-5-2.24-5-5S9.24,7,12,7z M5.07,13c0.49,3.39,3.4,6,6.93,6c3.53,0,6.44-2.61,6.93-6 L22,13v-2l-3.07,0c-0.49-3.39-3.4-6-6.93-6l0,0c-3.53,0-6.44,2.61-6.93,6c0,0-3.07,0-3.07,0v2L5.07,13z M14,10.5V9.61 c0-1-0.68-1.92-1.66-2.08C11.08,7.32,10,8.29,10,9.5v1c-0.55,0-1,0.45-1,1v3c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1v-3 C15,10.95,14.55,10.5,14,10.5z M12,13.75c-0.41,0-0.75-0.34-0.75-0.75c0-0.41,0.34-0.75,0.75-0.75s0.75,0.34,0.75,0.75 C12.75,13.41,12.41,13.75,12,13.75z M13,10.5h-2v-1c0-0.55,0.45-1,1-1s1,0.45,1,1V10.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
