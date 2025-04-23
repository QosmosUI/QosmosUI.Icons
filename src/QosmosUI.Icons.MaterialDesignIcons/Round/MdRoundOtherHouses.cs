// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundOtherHouses : ComponentBase
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
		builder.AddAttribute(18, "d", "M1.61,12.19c0.34,0.44,0.96,0.52,1.4,0.19L4,11.62V20c0,0.55,0.45,1,1,1h14c0.55,0,1-0.45,1-1v-8.38l0.99,0.76 c0.44,0.34,1.07,0.25,1.4-0.19c0.34-0.44,0.25-1.07-0.19-1.4l-9.6-7.33c-0.36-0.27-0.86-0.27-1.21,0l-9.6,7.33 C1.36,11.13,1.27,11.76,1.61,12.19z M8,15c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C9,14.55,8.55,15,8,15z M12,15 c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C13,14.55,12.55,15,12,15z M16,15c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1 s1,0.45,1,1C17,14.55,16.55,15,16,15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
