// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpSignLanguage : ComponentBase
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
		builder.AddAttribute(20, "d", "M12.49,13l-1.39-2.7L12.49,9L19,15.2V24H4.5v-2H10v-1H3v-2h7v-1H2v-2h8v-1H3.5v-2H12.49z M11.78,7.12 c-0.84,0.4-1.17,0.62-1.63,1.19L6.76,4.74l1.45-1.38L11.78,7.12z M9.64,9.21C9.41,9.76,9.35,10.45,9.44,11H8.58L5.62,7.89 l1.45-1.38L9.64,9.21z M21.98,12.34L22,3.35l-1.9-0.1l-1,2.86L13.3,0l-1.45,1.38l4.09,4.3l-0.73,0.69L9.74,0.64L8.3,2l3.36,3.53 l1.06,1.11l2.65,2.33l5.08,4.83L21.98,12.34z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
