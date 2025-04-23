// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundApi : ComponentBase
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
		builder.AddAttribute(19, "d", "M13,13L13,13c-0.56,0.56-1.45,0.56-2,0.01L11,13c-0.55-0.55-0.55-1.44,0-1.99L11,11c0.55-0.55,1.44-0.55,1.99,0L13,11 C13.55,11.55,13.55,12.45,13,13z M12,6l2.12,2.12l2.5-2.5l-3.2-3.2c-0.78-0.78-2.05-0.78-2.83,0l-3.2,3.2l2.5,2.5L12,6z M6,12 l2.12-2.12l-2.5-2.5l-3.2,3.2c-0.78,0.78-0.78,2.05,0,2.83l3.2,3.2l2.5-2.5L6,12z M18,12l-2.12,2.12l2.5,2.5l3.2-3.2 c0.78-0.78,0.78-2.05,0-2.83l-3.2-3.2l-2.5,2.5L18,12z M12,18l-2.12-2.12l-2.5,2.5l3.2,3.2c0.78,0.78,2.05,0.78,2.83,0l3.2-3.2 l-2.5-2.5L12,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
