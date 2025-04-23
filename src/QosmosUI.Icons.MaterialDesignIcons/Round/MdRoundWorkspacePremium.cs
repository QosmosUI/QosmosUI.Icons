// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWorkspacePremium : ComponentBase
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
		builder.AddAttribute(18, "d", "M10.92,12.75L12,11.93l1.07,0.81c0.39,0.29,0.92-0.08,0.78-0.55l-0.42-1.36l1.2-0.95C15,9.6,14.79,9,14.31,9h-1.4 l-0.43-1.34c-0.15-0.46-0.8-0.46-0.95,0L11.09,9H9.68C9.21,9,9,9.6,9.37,9.89l1.19,0.95l-0.42,1.36 C10,12.67,10.53,13.04,10.92,12.75z M6,21.61c0,0.68,0.67,1.16,1.32,0.95L12,21l4.68,1.56C17.33,22.78,18,22.3,18,21.61v-6.33 c1.24-1.41,2-3.25,2-5.28c0-4.42-3.58-8-8-8s-8,3.58-8,8c0,2.03,0.76,3.87,2,5.28V21.61z M12,4c3.31,0,6,2.69,6,6s-2.69,6-6,6 s-6-2.69-6-6S8.69,4,12,4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
