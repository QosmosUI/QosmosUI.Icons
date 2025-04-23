// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEmojiNature : ComponentBase
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
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "18");
		builder.AddAttribute(22, "cy", "6");
		builder.AddAttribute(23, "opacity", ".3");
		builder.AddAttribute(24, "r", "1");
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M21.94,4.88C21.75,4.33,21.19,3.96,20.58,4H19.6l-0.31-0.97C19.15,2.43,18.61,2,18,2h0c-0.61,0-1.15,0.43-1.29,1.04 L16.4,4h-0.98c-0.61-0.04-1.16,0.32-1.35,0.88c-0.19,0.56,0.04,1.17,0.56,1.48l0.87,0.52L15.1,8.12 c-0.23,0.58-0.04,1.25,0.45,1.62c0.5,0.37,1.17,0.35,1.64-0.06L18,8.98l0.81,0.7c0.47,0.4,1.15,0.43,1.64,0.06 c0.5-0.37,0.68-1.04,0.45-1.62l-0.39-1.24l0.87-0.52C21.89,6.05,22.12,5.44,21.94,4.88z M18,7c-0.55,0-1-0.45-1-1 c0-0.55,0.45-1,1-1s1,0.45,1,1C19,6.55,18.55,7,18,7z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(28, "g");
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M6.1,17.9c0.53,0.53,1.27,0.69,1.94,0.5c-0.03-1.19,0.35-2.37,0.92-3.36c-1,0.57-2.17,0.95-3.36,0.92 C5.41,16.63,5.58,17.37,6.1,17.9z");
		builder.AddAttribute(31, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M9.65,11.55l1.61,0.66c0.25,0.1,0.44,0.3,0.54,0.54l0.66,1.61c0.75-0.78,0.74-2.01-0.03-2.78 C11.66,10.8,10.43,10.8,9.65,11.55z");
		builder.AddAttribute(34, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M14.86,12c-0.17-0.67-0.5-1.31-1.03-1.84C13.31,9.64,12.67,9.31,12,9.14V7h-1v2c-1.01,0.01-2.02,0.39-2.79,1.16 c-0.13,0.13-0.33,0.33-0.56,0.56l-1.53-0.63c-1.52-0.63-3.27,0.1-3.89,1.62c-0.6,1.46,0.05,3.11,1.44,3.8 c-0.33,1.31,0,2.76,1.03,3.79c1.03,1.03,2.48,1.36,3.79,1.03c0.69,1.39,2.34,2.04,3.8,1.44c1.52-0.63,2.25-2.37,1.62-3.89 l-0.63-1.53c0.23-0.23,0.43-0.43,0.56-0.56c0.77-0.77,1.16-1.78,1.16-2.79h2v-1H14.86z M4.58,13.8c-0.51-0.21-0.75-0.79-0.54-1.3 c0.21-0.51,0.79-0.75,1.3-0.54l2.92,1.2C7.22,13.84,5.83,14.31,4.58,13.8z M8.04,18.4c-0.67,0.19-1.41,0.02-1.94-0.5 c-0.53-0.53-0.69-1.27-0.5-1.94c1.19,0.03,2.37-0.35,3.36-0.92C8.39,16.03,8.01,17.21,8.04,18.4z M11.5,19.96 c-0.51,0.21-1.09-0.03-1.3-0.54c-0.51-1.25-0.04-2.64,0.64-3.67l1.2,2.92C12.25,19.17,12.01,19.76,11.5,19.96z M12.45,14.35 l-0.66-1.61c-0.1-0.25-0.3-0.44-0.54-0.54l-1.61-0.66c0.78-0.75,2.01-0.74,2.78,0.03C13.2,12.34,13.2,13.57,12.45,14.35z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
