// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSettingsAccessibility : ComponentBase
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
		builder.AddAttribute(20, "d", "M20.74,4.96c-0.13-0.53-0.67-0.85-1.2-0.73C17.16,4.77,14.49,5,12,5S6.84,4.77,4.46,4.24c-0.54-0.12-1.07,0.19-1.2,0.73 L3.24,5.02C3.11,5.56,3.43,6.12,3.97,6.24C5.59,6.61,7.34,6.86,9,7v11c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-5h2v5 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V7c1.66-0.14,3.41-0.39,5.03-0.76c0.54-0.12,0.86-0.68,0.73-1.22L20.74,4.96z M12,4 c1.1,0,2-0.9,2-2s-0.9-2-2-2s-2,0.9-2,2S10.9,4,12,4z M8,24L8,24c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v0 C7,23.55,7.45,24,8,24z M12,24L12,24c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v0C11,23.55,11.45,24,12,24z M16,24L16,24c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v0C15,23.55,15.45,24,16,24z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
