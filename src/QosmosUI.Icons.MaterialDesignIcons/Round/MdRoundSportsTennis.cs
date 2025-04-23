// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSportsTennis : ComponentBase
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
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M19.52,2.49c-2.34-2.34-6.62-1.87-9.55,1.06c-1.6,1.6-2.52,3.87-2.54,5.46c-0.02,1.58,0.26,3.89-1.35,5.5l-3.54,3.53 c-0.39,0.39-0.39,1.02,0,1.42l0,0c0.39,0.39,1.02,0.39,1.42,0l3.53-3.54c1.61-1.61,3.92-1.33,5.5-1.35s3.86-0.94,5.46-2.54 C21.38,9.11,21.86,4.83,19.52,2.49z M10.32,11.68c-1.53-1.53-1.05-4.61,1.06-6.72s5.18-2.59,6.72-1.06 c1.53,1.53,1.05,4.61-1.06,6.72S11.86,13.21,10.32,11.68z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M18,17c0.53,0,1.04,0.21,1.41,0.59c0.78,0.78,0.78,2.05,0,2.83C19.04,20.79,18.53,21,18,21s-1.04-0.21-1.41-0.59 c-0.78-0.78-0.78-2.05,0-2.83C16.96,17.21,17.47,17,18,17 M18,15c-1.02,0-2.05,0.39-2.83,1.17c-1.56,1.56-1.56,4.09,0,5.66 C15.95,22.61,16.98,23,18,23s2.05-0.39,2.83-1.17c1.56-1.56,1.56-4.09,0-5.66C20.05,15.39,19.02,15,18,15L18,15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
