// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundLinkedCamera : ComponentBase
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
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "12");
		builder.AddAttribute(24, "cy", "13");
		builder.AddAttribute(25, "r", "2.5");
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M16.6,2.37c2.1,0.27,3.77,1.93,4.03,4.03C20.67,6.74,20.95,7,21.29,7l0,0c0.39,0,0.71-0.34,0.66-0.73 c-0.33-2.72-2.5-4.89-5.22-5.22C16.34,1,16,1.32,16,1.71l0,0C16,2.05,16.26,2.33,16.6,2.37z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M19.23,6.19C18.93,5,18,4.07,16.81,3.77C16.4,3.67,16,3.99,16,4.42l0,0c0,0.29,0.19,0.57,0.48,0.64 c0.72,0.18,1.29,0.74,1.46,1.46C18.01,6.81,18.28,7,18.58,7l0,0C19.01,7,19.33,6.6,19.23,6.19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M17,8c0-1.1-0.9-2-2-2V4c0-0.55-0.45-1-1-1H9.88C9.32,3,8.78,3.24,8.4,3.65L7.17,5H4C2.9,5,2,5.9,2,7v12 c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2v-9c0-1.1-0.9-2-2-2H17z M12,17.5c-2.48,0-4.5-2.02-4.5-4.5S9.52,8.5,12,8.5 s4.5,2.02,4.5,4.5S14.48,17.5,12,17.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
