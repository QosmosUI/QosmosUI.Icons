// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiIngress : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M22.55 6.55v10.9c0 .434-.184.749-.55.95l-9.45 5.45c-.367.2-.733.2-1.1 0L2 18.4c-.366-.201-.55-.516-.55-.95V6.55c0-.434.184-.749.55-.95L11.45.15c.367-.2.733-.2 1.1 0L22 5.6c.366.201.55.516.55.95zM21 17.8l-3.9-2.25.5-.9 3.9 2.249V6.549l-.05-.048-8.95-5.2v4.5h-1v-4.5l-9 5.2v10.398l3.9-2.248.5.899L3 17.8l8.95 5.15h.1L21 17.8zM4.55 7.675c0-.016.016-.025.05-.025h14.8c.033 0 .05.009.05.025v.075l-7.4 12.799c0 .034-.017.05-.05.05-.034 0-.05-.016-.05-.05L4.55 7.75v-.075zm6.95 5.076c0-.301-.15-.533-.45-.7L6.9 9.65h-.05v.05l4.6 7.9c.033 0 .05-.019.05-.051v-4.8zm.9-1.601l4.2-2.45H7.4l.05.051 4.15 2.399a.701.701 0 00.8 0zM17.15 9.7v-.05h-.05l-4.15 2.4c-.3.167-.45.417-.45.749v4.8h.1l4.55-7.899z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
