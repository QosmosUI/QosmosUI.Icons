// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEditNotifications : ComponentBase
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
		builder.OpenElement(17, "g");
		builder.AddAttribute(18, "opacity", ".3");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M16,14.2L15.2,15h-4.6v-4.6l3.68-3.68C13.64,6.26,12.85,6,12,6c-2.21,0-4,1.79-4,4v7h8V14.2z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M17.58,6.25l1.77,1.77L14.37,13H12.6v-1.77L17.58,6.25z M20.85,5.81l-1.06-1.06c-0.2-0.2-0.51-0.2-0.71,0l-0.85,0.85 l1.77,1.77l0.85-0.85C21.05,6.32,21.05,6,20.85,5.81z M18,12.2V17h2v2H4v-2h2v-7c0-2.79,1.91-5.14,4.5-5.8V3.5 C10.5,2.67,11.17,2,12,2s1.5,0.67,1.5,1.5v0.7c0.82,0.21,1.57,0.59,2.21,1.09l-1.43,1.43C13.64,6.26,12.85,6,12,6 c-2.21,0-4,1.79-4,4v7h8v-2.8L18,12.2z M10,20h4c0,1.1-0.9,2-2,2S10,21.1,10,20z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
