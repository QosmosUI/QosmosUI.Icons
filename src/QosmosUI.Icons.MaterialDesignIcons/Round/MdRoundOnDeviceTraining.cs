// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundOnDeviceTraining : ComponentBase
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
		builder.AddAttribute(25, "d", "M11.5,17h1c0.28,0,0.5-0.22,0.5-0.5l0,0c0-0.28-0.22-0.5-0.5-0.5h-1c-0.28,0-0.5,0.22-0.5,0.5l0,0 C11,16.78,11.22,17,11.5,17z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M11.52,11.06c-0.71,0.16-1.29,0.74-1.46,1.44c-0.23,0.94,0.21,1.8,0.94,2.22v0.53c0,0.14,0.11,0.25,0.25,0.25h1.5 c0.14,0,0.25-0.11,0.25-0.25v-0.53c0.6-0.35,1-0.98,1-1.72C14,11.74,12.83,10.75,11.52,11.06z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M18,1.01L6,1C4.9,1,4,1.9,4,3v18c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2V3C20,1.9,19.1,1.01,18,1.01z M18,18H6V6h12V18z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M15.33,15.27c0.36,0.36,0.99,0.26,1.21-0.2C16.83,14.44,17,13.74,17,13s-0.17-1.44-0.46-2.07 c-0.22-0.47-0.84-0.57-1.21-0.2l0,0c-0.22,0.22-0.28,0.56-0.15,0.84c0.2,0.44,0.31,0.92,0.31,1.43s-0.11,0.99-0.31,1.43 C15.06,14.72,15.11,15.05,15.33,15.27L15.33,15.27z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M8.67,15.27c0.22-0.22,0.28-0.56,0.15-0.84C8.61,13.99,8.5,13.51,8.5,13c0-1.93,1.57-3.5,3.5-3.5v0.69 c0,0.22,0.25,0.33,0.42,0.19l1.62-1.44c0.11-0.1,0.11-0.27,0-0.37l-1.62-1.44C12.25,6.98,12,7.09,12,7.31V8c-2.76,0-5,2.24-5,5 c0,0.74,0.17,1.44,0.46,2.07C7.68,15.54,8.3,15.64,8.67,15.27L8.67,15.27z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
