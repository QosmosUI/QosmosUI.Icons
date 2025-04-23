// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneOnDeviceTraining : ComponentBase
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
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "height", "1");
		builder.AddAttribute(22, "opacity", ".3");
		builder.AddAttribute(23, "width", "12");
		builder.AddAttribute(24, "x", "6");
		builder.AddAttribute(25, "y", "20");
		builder.CloseElement();
		builder.OpenElement(26, "rect");
		builder.AddAttribute(27, "height", "1");
		builder.AddAttribute(28, "opacity", ".3");
		builder.AddAttribute(29, "width", "12");
		builder.AddAttribute(30, "x", "6");
		builder.AddAttribute(31, "y", "3");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "1");
		builder.AddAttribute(34, "width", "2");
		builder.AddAttribute(35, "x", "11");
		builder.AddAttribute(36, "y", "16");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M12,11c-1.1,0-2,0.9-2,2c0,0.74,0.4,1.38,1,1.72v0.78h2v-0.78c0.6-0.35,1-0.98,1-1.72C14,11.9,13.1,11,12,11z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M18,1.01L6,1C4.9,1,4,1.9,4,3v18c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2V3C20,1.9,19.1,1.01,18,1.01z M18,21H6v-1h12V21z M18,18H6V6h12V18z M18,4H6V3h12V4z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M16.01,15.95C16.63,15.12,17,14.11,17,13s-0.37-2.12-0.99-2.95l-1.07,1.07c0.35,0.54,0.56,1.19,0.56,1.88 s-0.21,1.34-0.56,1.88L16.01,15.95z");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M9.06,14.88C8.71,14.34,8.5,13.69,8.5,13c0-1.93,1.57-3.5,3.5-3.5v1.25l2.25-2l-2.25-2V8c-2.76,0-5,2.24-5,5 c0,1.11,0.37,2.12,0.99,2.95L9.06,14.88z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
