// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFlaky : ComponentBase
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
		builder.AddAttribute(24, "d", "M12.16,15.72c-0.29-0.29-0.29-0.77,0-1.06l0,0c0.29-0.29,0.77-0.29,1.06,0 l0.82,0.82l1.96-1.96c0.29-0.29,0.77-0.29,1.06,0l0,0c0.29,0.29,0.29,0.77,0,1.06l-2.65,2.65c-0.19,0.19-0.51,0.2-0.7,0 L12.16,15.72z M12,2C6.5,2,2,6.5,2,12s4.5,10,10,10s10-4.5,10-10S17.5,2,12,2z M7.87,6.81l0.88,0.88l0.88-0.88 c0.29-0.29,0.77-0.29,1.06,0l0,0c0.29,0.29,0.29,0.77,0,1.06L9.81,8.75l0.88,0.88c0.29,0.29,0.29,0.77,0,1.06l0,0 c-0.29,0.29-0.77,0.29-1.06,0L8.75,9.81l-0.88,0.88c-0.29,0.29-0.77,0.29-1.06,0l0,0c-0.29-0.29-0.29-0.77,0-1.06l0.88-0.88 L6.81,7.87c-0.29-0.29-0.29-0.77,0-1.06l0,0C7.1,6.51,7.57,6.51,7.87,6.81z M12,20c-2.2,0-4.2-0.9-5.7-2.3L17.7,6.3 C19.1,7.8,20,9.8,20,12C20,16.4,16.4,20,12,20z");
		builder.AddAttribute(25, "fill-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
