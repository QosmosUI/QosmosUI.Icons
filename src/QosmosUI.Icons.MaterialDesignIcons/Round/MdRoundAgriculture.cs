// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAgriculture : ComponentBase
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
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M19.5,11.97c0.93,0,1.78,0.28,2.5,0.76V7.97c0-1.1-0.9-2-2-2h-6.29l-1.06-1.06l1.06-1.06c0.2-0.2,0.2-0.51,0-0.71 s-0.51-0.2-0.71,0l-2.83,2.83c-0.2,0.2-0.2,0.51,0,0.71l0,0c0.2,0.2,0.51,0.2,0.71,0l1.06-1.06L13,6.68v2.29c0,1.1-0.9,2-2,2 h-0.54c0.95,1.06,1.54,2.46,1.54,4c0,0.34-0.04,0.67-0.09,1h3.14C15.3,13.73,17.19,11.97,19.5,11.97z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M19.5,12.97c-1.93,0-3.5,1.57-3.5,3.5s1.57,3.5,3.5,3.5s3.5-1.57,3.5-3.5S21.43,12.97,19.5,12.97z M19.5,17.97 c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S20.33,17.97,19.5,17.97z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M4,8.97h5c0-1.1-0.9-2-2-2H4c-0.55,0-1,0.45-1,1C3,8.53,3.45,8.97,4,8.97z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M9.83,13.79l-0.18-0.47l0.93-0.35c-0.46-1.06-1.28-1.91-2.31-2.43l-0.4,0.89l-0.46-0.21l0.4-0.9 C7.26,10.11,6.64,9.97,6,9.97c-0.53,0-1.04,0.11-1.52,0.26l0.34,0.91l-0.47,0.18L4,10.4c-1.06,0.46-1.91,1.28-2.43,2.31l0.89,0.4 l-0.21,0.46l-0.9-0.4C1.13,13.72,1,14.33,1,14.97c0,0.53,0.11,1.04,0.26,1.52l0.91-0.34l0.18,0.47l-0.93,0.35 c0.46,1.06,1.28,1.91,2.31,2.43l0.4-0.89l0.46,0.21l-0.4,0.9c0.57,0.22,1.18,0.35,1.82,0.35c0.53,0,1.04-0.11,1.52-0.26L7.18,18.8 l0.47-0.18L8,19.55c1.06-0.46,1.91-1.28,2.43-2.31l-0.89-0.4l0.21-0.46l0.9,0.4c0.22-0.57,0.35-1.18,0.35-1.82 c0-0.53-0.11-1.04-0.26-1.52L9.83,13.79z M7.15,17.75c-1.53,0.63-3.29-0.09-3.92-1.62c-0.63-1.53,0.09-3.29,1.62-3.92 c1.53-0.63,3.29,0.09,3.92,1.62C9.41,15.36,8.68,17.11,7.15,17.75z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
