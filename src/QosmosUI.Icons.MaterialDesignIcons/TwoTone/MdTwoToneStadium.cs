// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneStadium : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M5,10.04C6.38,10.53,8.77,11,12,11s5.62-0.47,7-0.96C19,9.86,16.22,9,12,9S5,9.86,5,10.04z M20,11.8 c-1.82,0.73-4.73,1.2-8,1.2s-6.18-0.47-8-1.2v6.78c0.61,0.41,2.36,1.01,5,1.28V16h6v3.86c2.64-0.27,4.39-0.87,5-1.28V11.8z");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M7,5L3,7V3L7,5z M18,3v4l4-2L18,3z M11,2v4l4-2L11,2z M13,18h-2l0,4c-5.05-0.15-9-1.44-9-3v-9c0-1.66,4.48-3,10-3 s10,1.34,10,3v9c0,1.56-3.95,2.85-9,3L13,18z M5,10.04C6.38,10.53,8.77,11,12,11s5.62-0.47,7-0.96C19,9.86,16.22,9,12,9 S5,9.86,5,10.04z M20,11.8c-1.82,0.73-4.73,1.2-8,1.2s-6.18-0.47-8-1.2v6.78c0.61,0.41,2.36,1.01,5,1.28V16h6v3.86 c2.64-0.27,4.39-0.87,5-1.28V11.8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
