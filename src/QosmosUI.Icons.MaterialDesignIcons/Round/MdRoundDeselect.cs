// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDeselect : ComponentBase
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
		builder.AddAttribute(24, "d", "M3,13h2v-2H3V13z M7,21h2v-2H7V21z M13,3h-2v2h2V3z M19,3v2h2C21,3.9,20.1,3,19,3z M5,21v-2H3C3,20.1,3.9,21,5,21z M3,17h2 v-2H3V17z M11,21h2v-2h-2V21z M19,13h2v-2h-2V13z M19,9h2V7h-2V9z M15,5h2V3h-2V5z M7.83,5L7,4.17V3h2v2H7.83z M19.83,17L19,16.17 V15h2v2H19.83z M9,15v-3.17L12.17,15H9z M2.1,3.51c-0.39,0.39-0.39,1.02,0,1.41L4.17,7H3v2h2V7.83l2,2V16c0,0.55,0.45,1,1,1h6.17 l2,2H15v2h2v-1.17l2.07,2.07c0.39,0.39,1.02,0.39,1.41,0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51C3.12,3.12,2.49,3.12,2.1,3.51z M17,8c0-0.55-0.45-1-1-1H9.83l2,2H15v3.17l2,2V8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
