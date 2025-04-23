// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTonePreview : ComponentBase
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
		builder.AddAttribute(19, "d", "M19,19H5V7h14V19z M12,10.5c1.84,0,3.48,0.96,4.34,2.5c-0.86,1.54-2.5,2.5-4.34,2.5S8.52,14.54,7.66,13 C8.52,11.46,10.16,10.5,12,10.5 M12,9c-2.73,0-5.06,1.66-6,4c0.94,2.34,3.27,4,6,4s5.06-1.66,6-4C17.06,10.66,14.73,9,12,9L12,9z M12,14.5c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S12.83,14.5,12,14.5z");
		builder.AddAttribute(20, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M19,3H5C3.89,3,3,3.9,3,5v14c0,1.1,0.89,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.11,3,19,3z M19,19H5V7h14V19z M12,10.5 c1.84,0,3.48,0.96,4.34,2.5c-0.86,1.54-2.5,2.5-4.34,2.5S8.52,14.54,7.66,13C8.52,11.46,10.16,10.5,12,10.5 M12,9 c-2.73,0-5.06,1.66-6,4c0.94,2.34,3.27,4,6,4s5.06-1.66,6-4C17.06,10.66,14.73,9,12,9L12,9z M12,14.5c-0.83,0-1.5-0.67-1.5-1.5 s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S12.83,14.5,12,14.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
