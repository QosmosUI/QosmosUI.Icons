// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineLightbulbCircle : ComponentBase
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
		builder.AddAttribute(21, "d", "M12,2C6.48,2,2,6.48,2,12s4.48,10,10,10s10-4.48,10-10S17.52,2,12,2z M12,20c-4.41,0-8-3.59-8-8s3.59-8,8-8s8,3.59,8,8 S16.41,20,12,20z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M12,19c0.83,0,1.5-0.67,1.5-1.5h-3C10.5,18.33,11.17,19,12,19z");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "1.5");
		builder.AddAttribute(26, "width", "6");
		builder.AddAttribute(27, "x", "9");
		builder.AddAttribute(28, "y", "15");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M12,5c-2.76,0-5,2.24-5,5c0,1.64,0.8,3.09,2.03,4h5.95C16.2,13.09,17,11.64,17,10C17,7.24,14.76,5,12,5z M14.43,12.5H9.57 C8.89,11.84,8.5,10.95,8.5,10c0-1.93,1.57-3.5,3.5-3.5s3.5,1.57,3.5,3.5C15.5,10.95,15.11,11.84,14.43,12.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
