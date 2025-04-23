// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneDoNotDisturbOff : ComponentBase
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
		builder.AddAttribute(20, "d", "M7,13v-2h1.17L5.12,7.94C4.41,9.14,4,10.52,4,12c0,4.41,3.59,8,8,8 c1.48,0,2.86-0.41,4.06-1.12L10.17,13H7z M12,4c-1.48,0-2.86,0.41-4.06,1.12L13.83,11H17v2h-1.17l3.06,3.06 C19.59,14.86,20,13.48,20,12C20,7.59,16.41,4,12,4z");
		builder.AddAttribute(21, "enable-background", "new");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M12,4c4.41,0,8,3.59,8,8c0,1.48-0.41,2.86-1.12,4.06l1.46,1.46C21.39,15.93,22,14.04,22,12c0-5.52-4.48-10-10-10 C9.96,2,8.07,2.61,6.49,3.66l1.46,1.46C9.14,4.41,10.52,4,12,4z M17,13v-2h-3.17l2,2H17z M1.39,4.22l2.27,2.27 C2.61,8.07,2,9.96,2,12c0,5.52,4.48,10,10,10c2.04,0,3.93-0.61,5.51-1.66l2.27,2.27l1.41-1.41L2.81,2.81L1.39,4.22z M5.12,7.94 L8.17,11H7v2h3.17l5.88,5.88C14.86,19.59,13.48,20,12,20c-4.41,0-8-3.59-8-8C4,10.52,4.41,9.14,5.12,7.94z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
