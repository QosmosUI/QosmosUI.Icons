// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundLocalSee : ComponentBase
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
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M9.5,14c0,1.38,1.12,2.5,2.5,2.5c1.23,0,2.25-0.9,2.46-2.07c-1-1.01-1.83-1.98-2.48-2.93C10.61,11.52,9.5,12.63,9.5,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M18.65,17.08c-0.37,0.32-0.92,0.32-1.3,0c-1.26-1.08-0.7-0.61-1.3-1.14c-0.83,1.74-2.73,2.87-4.85,2.5 c-1.83-0.32-3.31-1.8-3.63-3.63c-0.42-2.44,1.13-4.58,3.31-5.14C10.3,8.45,10,7.28,10,6.15C10,5.4,10.1,4.68,10.28,4h-0.4 c-0.56,0-1.1,0.24-1.48,0.65L7.17,6H4C2.9,6,2,6.9,2,8v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2v-6.03 C20.59,15.46,19.35,16.48,18.65,17.08z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M17.34,14.42c0.37,0.33,0.95,0.33,1.33,0C22.22,11.25,24,8.5,24,6.15C24,2.42,21.15,0,18,0s-6,2.42-6,6.15 C12,8.5,13.78,11.25,17.34,14.42z M17.27,5.25L18,3l0.73,2.25H21l-1.85,1.47L19.85,9L18,7.59L16.15,9l0.7-2.28L15,5.25H17.27z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
