// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRepeatOneOn : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M21,1H3C1.9,1,1,1.9,1,3v18c0,1.1,0.9,2,2,2h18c1.1,0,2-0.9,2-2V3C23,1.9,22.1,1,21,1z M19,18c0,0.55-0.45,1-1,1H7v1.79 c0,0.45-0.54,0.67-0.85,0.36l-2.79-2.79c-0.2-0.2-0.2-0.51,0-0.71l2.79-2.79C6.46,14.54,7,14.76,7,15.21V17h10v-3 c0-0.55,0.45-1,1-1s1,0.45,1,1V18z M10.75,10.5c-0.41,0-0.75-0.34-0.75-0.75S10.34,9,10.75,9h1.5C12.66,9,13,9.34,13,9.75v4.5 c0,0.41-0.34,0.75-0.75,0.75s-0.75-0.34-0.75-0.75V10.5H10.75z M20.64,6.35l-2.79,2.79C17.54,9.46,17,9.24,17,8.79V7H7v3 c0,0.55-0.45,1-1,1s-1-0.45-1-1V6c0-0.55,0.45-1,1-1h11V3.21c0-0.45,0.54-0.67,0.85-0.36l2.79,2.79 C20.84,5.84,20.84,6.15,20.64,6.35z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
