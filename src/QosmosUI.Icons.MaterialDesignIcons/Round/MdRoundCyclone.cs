// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCyclone : ComponentBase
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
		builder.AddAttribute(25, "d", "M12,8c-2.21,0-4,1.79-4,4c0,2.21,1.79,4,4,4c2.21,0,4-1.79,4-4C16,9.79,14.21,8,12,8z M12,14c-1.1,0-2-0.9-2-2 c0-1.1,0.9-2,2-2s2,0.9,2,2C14,13.1,13.1,14,12,14z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M22,6.11L22,6.11c0-0.46-0.3-0.86-0.74-0.97C19.23,4.6,16.03,4,12,4C9.85,4,7.89,4.86,6.46,6.24 c0.1-0.65,0.28-1.69,0.62-2.96C7.25,2.64,6.78,2,6.11,2h0C5.66,2,5.26,2.3,5.14,2.74C4.6,4.77,4,7.97,4,12 c0,2.15,0.86,4.11,2.24,5.54c-0.65-0.1-1.69-0.28-2.96-0.62C2.64,16.75,2,17.22,2,17.89v0c0,0.46,0.3,0.86,0.74,0.97 C4.77,19.4,7.97,20,12,20c2.15,0,4.11-0.86,5.54-2.24c-0.1,0.65-0.28,1.69-0.62,2.96c-0.17,0.64,0.3,1.28,0.97,1.28h0 c0.46,0,0.86-0.3,0.97-0.74C19.4,19.23,20,16.03,20,12c0-2.15-0.86-4.11-2.24-5.54c0.65,0.1,1.69,0.28,2.96,0.62 C21.36,7.25,22,6.78,22,6.11z M12,18c-3.31,0-6-2.69-6-6s2.69-6,6-6s6,2.69,6,6S15.31,18,12,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
