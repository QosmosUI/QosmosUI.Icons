// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiEraser : ComponentBase
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
		builder.AddAttribute(14, "id", "Eraser");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M20.454,19.028h-7.01l6.62-6.63a2.935,2.935,0,0,0,.87-2.09,2.844,2.844,0,0,0-.87-2.05l-3.42-3.44a2.93,2.93,0,0,0-4.13.01L3.934,13.4a2.946,2.946,0,0,0,0,4.14l1.48,1.49H3.554a.5.5,0,0,0,0,1h16.9A.5.5,0,0,0,20.454,19.028Zm-7.24-13.5a1.956,1.956,0,0,1,2.73,0l3.42,3.44a1.868,1.868,0,0,1,.57,1.35,1.93,1.93,0,0,1-.57,1.37l-5.64,5.64-6.15-6.16Zm-1.19,13.5h-5.2l-2.18-2.2a1.931,1.931,0,0,1,0-2.72l2.23-2.23,6.15,6.15Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
