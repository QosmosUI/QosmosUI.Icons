// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneFlipCameraIos : ComponentBase
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
		builder.AddAttribute(21, "d", "M14.12,5H9.88L8.05,7H4v12h16V7h-4.05L14.12,5z M12,18c-2.76,0-5-2.24-5-5H5l2.49-2.49L7.5,10.5L10,13H9.97 H8c0,2.21,1.79,4,4,4c0.58,0,1.13-0.13,1.62-0.35l0.74,0.74C13.65,17.76,12.86,18,12,18z M19,13l-2.49,2.49L16.5,15.5L14,13h0.03 H16c0-2.21-1.79-4-4-4c-0.58,0-1.13,0.13-1.62,0.35L9.64,8.62C10.35,8.24,11.14,8,12,8c2.76,0,5,2.24,5,5H19z");
		builder.AddAttribute(22, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M20,5h-3.17L15,3H9L7.17,5H4C2.9,5,2,5.9,2,7v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V7C22,5.9,21.1,5,20,5z M20,19H4V7 h4.05l1.83-2h4.24l1.83,2H20V19z");
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,17c-2.21,0-4-1.79-4-4h1.97H10l-2.5-2.5l-0.01,0.01L5,13h2c0,2.76,2.24,5,5,5c0.86,0,1.65-0.24,2.36-0.62l-0.74-0.74 C13.13,16.87,12.58,17,12,17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(28, "g");
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M12,8c-0.86,0-1.65,0.24-2.36,0.62l0.74,0.73C10.87,9.13,11.42,9,12,9c2.21,0,4,1.79,4,4h-1.97H14l2.5,2.5l0.01-0.01 L19,13h-2C17,10.24,14.76,8,12,8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
