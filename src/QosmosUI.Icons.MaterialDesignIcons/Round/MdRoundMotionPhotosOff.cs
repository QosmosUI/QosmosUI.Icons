// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMotionPhotosOff : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,6c-0.92,0-1.8,0.22-2.58,0.59l7.99,7.99C17.78,13.8,18,12.92,18,12C18,8.69,15.31,6,12,6z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M2.1,3.51L2.1,3.51c-0.39,0.39-0.39,1.03,0,1.42l1.56,1.56c-1.25,1.88-1.88,4.21-1.59,6.7c0.52,4.54,4.21,8.23,8.75,8.75 c2.49,0.28,4.81-0.34,6.69-1.59l1.56,1.56c0.39,0.39,1.03,0.39,1.42,0l0,0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51 C3.13,3.13,2.49,3.12,2.1,3.51z M12,20c-4.41,0-8-3.59-8-8c0-1.48,0.41-2.86,1.12-4.06l1.47,1.47C6.22,10.2,6,11.08,6,12 c0,3.31,2.69,6,6,6c0.92,0,1.8-0.22,2.58-0.59l1.47,1.47C14.86,19.59,13.48,20,12,20z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,4c4.41,0,8,3.59,8,8c0,1.48-0.41,2.86-1.12,4.05l1.45,1.45C21.39,15.93,22,14.04,22,12c0-5.52-4.48-10-10-10 C9.96,2,8.07,2.61,6.49,3.66l1.45,1.45C9.14,4.41,10.52,4,12,4z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
